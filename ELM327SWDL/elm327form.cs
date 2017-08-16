using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ELM327SWDL
{
    public partial class elm327form : System.Windows.Forms.Form
    {
        ELM327Serial ELM327Serial = new ELM327Serial();

        List<VBF.VBF_File> VBFFileList = new List<VBF.VBF_File>();

        public elm327form()
        {
            InitializeComponent();
        }

        public void writeToConsoleBox(string message)
        {
            console.AppendText(message);
            console.ScrollToCaret();
        }

        private void elmCom_Enter(object sender, EventArgs e)
        {
            robot_com.Items.Clear();
            robot_com.Items.AddRange(SerialPort.GetPortNames());
        }

        private void dvgr_click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void Open_VBF_file(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openVBFDialog = new OpenFileDialog();
            openVBFDialog.Filter = "VBF Files|*.vbf|All files (*.*)|*.*";
            openVBFDialog.Title = "Select a VBF File";
            openVBFDialog.FilterIndex = 1;
            openVBFDialog.InitialDirectory = "c:\\";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .VBF file was selected, open it.  
            if (openVBFDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                VBF.VBF_File VBFFile = VBF.parseVBFFile(openVBFDialog.FileName);
                int row = VBFFileGridView.Rows.Add();
                VBFFileGridView.Rows[row].Cells[0].Value = VBFFile.description;
                VBFFileGridView.Rows[row].Cells[1].Value = VBFFile.sw_part_number;
                VBFFileGridView.Rows[row].Cells[2].Value = VBFFile.sw_part_type;
                VBFFileGridView.Rows[row].Cells[3].Value = VBFFile.ecu_address;
                VBFFileGridView.Rows[row].Cells[4].Value = VBFFile.frame_format;
                console.Text = "Opening " + openVBFDialog.FileName + "\r\n";
                VBFFileList.Insert(row, VBFFile);
            }
        }

        private void openVBFDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void VBFFileGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static void SwapVBF(IList<VBF.VBF_File> list, int indexA, int indexB)
        {
            VBF.VBF_File tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            DataGridView dgv = VBFFileGridView;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex - 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
                SwapVBF(VBFFileList, rowIndex, rowIndex - 1);
            }
            catch { }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            DataGridView dgv = VBFFileGridView;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex + 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
                SwapVBF(VBFFileList, rowIndex, rowIndex + 1);
            }
            catch { }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridView dgv = VBFFileGridView;
            dgv.Rows.RemoveAt(dgv.SelectedCells[0].OwningRow.Index);
            VBFFileList.RemoveAt(dgv.SelectedCells[0].OwningRow.Index);
        }

        private void DataToStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void StoreData_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.StoreData, DataToStore.Text);
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.ReadData);
        }

        private void connect_robot_Click(object sender, EventArgs e)
        {
            string connection = connect_robot.Text;
            switch (connection)
            {
                case "CONNECT":
                    console.AppendText("Connecting to ELM327...\n");
                    bool success = ELM327Serial.SetComPort(robot_com.Text);
                    if (!success)
                    {
                        string error = "ERROR: Please select COM port to connect to.\n";
                        AppendErrorText(error);
                        return;
                    }
                    bool connect = ELM327Serial.openPort(this);
                    if (connect)
                    {
                        connect_robot.Text = "DISCONNECT";
                        //ELM327Serial.Initialize();
                        console.AppendText("Connected to ELM327!\n");
                    }
                    else
                    {
                        //send error if connect = false.
                        string error = "ERROR: Could not connect to Robot.  Please check COM port.\n";
                        AppendErrorText(error);
                    }
                    break;
                case "DISCONNECT":
                    string selectedComPort = robot_com.Text;
                    string connectedComPort = ELM327Serial.cPort;
                    if (selectedComPort == connectedComPort)
                    {

                        bool disconnect = ELM327Serial.closePort();
                        if (disconnect)
                        {
                            connect_robot.Text = "CONNECT";
                            console.AppendText("Disconnected from Robot!\n");

                        }
                        else
                        {
                            string error = "ERROR: Cannot disconnect!\n";
                            AppendErrorText(error);
                        }

                    }
                    else
                    {
                        string error = "ERROR: Could not disconnect from Robot on " + connectedComPort + ", Please select correct COM port.\n";
                        AppendErrorText(error);
                    }
                    break;

            }
        }

        private void AppendErrorText(string error)
        {
            int length = console.TextLength;
            console.AppendText(error);
            console.SelectionStart = length;
            console.SelectionLength = error.Length;
            console.SelectionColor = Color.Red;
        }

        private void EnableLineFeeds_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableLineFeeds.Checked == true)
            {
                ELM327Serial.sendCommand(ATCommand.LinefeedsOn);
            }
            else
            {
                ELM327Serial.sendCommand(ATCommand.LinefeedsOff);
            }
        }

        private void EchoCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (EchoCommand.Checked == true)
            {
                ELM327Serial.sendCommand(ATCommand.EchoOn);
            }
            else
            {
                ELM327Serial.sendCommand(ATCommand.EchoOff);
            }
        }

        private void ShowHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHeader.Checked == true)
            {
                ELM327Serial.sendCommand(ATCommand.HeadersOn);
            }
            else
            {
                ELM327Serial.sendCommand(ATCommand.HeadersOff);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.ResetDevice);
        }

        private void EnableSpaces_Click(object sender, EventArgs e)
        {
            if (EnableSpaces.Checked == true)
            {
                ELM327Serial.sendCommand(ATCommand.PrintSpacesOn);
            }
            else
            {
                ELM327Serial.sendCommand(ATCommand.PrintSpacesOff);
            }
        }

        private void ReadVoltage_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.ReadVoltage);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AutomaticProtocol_CheckedChanged(object sender, EventArgs e)
        {
            if(AutomaticProtocol.Checked == true)
            {
                ELM327Serial.sendCommand(ATCommand.SetProtocolAuto);
            }
        }

        private void saeJ1850pwm_Click(object sender, EventArgs e)
        {
            if (saeJ1850pwm.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "1");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "1");
                }
            }
        }

        private void saej1850vpw_Click(object sender, EventArgs e)
        {
            if (saej1850vpw.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "2");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "2");
                }
            }
        }

        private void iso9141_2_Click(object sender, EventArgs e)
        {
            if (iso9141_2.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "3");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "3");
                }
            }
        }

        private void iso142304kwp5baud_Click(object sender, EventArgs e)
        {
            if (iso142304kwp5baud.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "4");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "4");
                }
            }
        }

        private void iso142304kwpfastinit_Click(object sender, EventArgs e)
        {
            if (iso142304kwpfastinit.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "5");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "5");
                }
            }
        }

        private void iso157654can11id500kbaud_Click(object sender, EventArgs e)
        {
            if (iso157654can11id500kbaud.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "6");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "6");
                }
            }
        }

        private void iso157654can29id500kbaud_Click(object sender, EventArgs e)
        {
            if (iso157654can29id500kbaud.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "7");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "7");
                }
            }
        }

        private void iso157654can11id250kbaud_Click(object sender, EventArgs e)
        {
            if (iso157654can11id250kbaud.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "8");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "8");
                }
            }
        }

        private void iso157654can29id250kbaud_Click(object sender, EventArgs e)
        {
            if (iso157654can29id250kbaud.Checked == true)
            {
                if (AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "9");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "9");
                }
            }
        }

        private void saej1939can_Click(object sender, EventArgs e)
        {
            if (saej1939can.Checked == true)
            {
                if(AutoSearchOnFailure.Checked == true)
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocolAuto, "A");
                }
                else
                {
                    ELM327Serial.sendCommand(ATCommand.SetProtocol, "A");
                }
            }
        }

        private void ReadProtocolButton_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.ReadProtocol);
        }

        private void RecommendedInitialization_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.ResetDevice);
            EchoCommand.Checked = true;
            ELM327Serial.sendCommand(ATCommand.EchoOn);
            EnableLineFeeds.Checked = true;
            ELM327Serial.sendCommand(ATCommand.LinefeedsOn);
            ShowHeader.Checked = true;
            ELM327Serial.sendCommand(ATCommand.HeadersOn);
            EnableSpaces.Checked = true;
            ELM327Serial.sendCommand(ATCommand.PrintSpacesOn);
            AutomaticProtocol.Checked = true;
            ELM327Serial.sendCommand(ATCommand.SetProtocolAuto);
        }

        private void set11bitheader_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.Set11BitHeader, can11header.Text);
        }

        private void monitortx_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.MonitorTx, monitortxheader.Text);
        }

        private void monitorrx_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.MonitorRx, monitorrxheader.Text);
        }

        private void monitorall_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.MonitorAll);
        }

        private void defaultbutton_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(ATCommand.Default);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void senddata_Click(object sender, EventArgs e)
        {
            ELM327Serial.sendCommand(byte0.Text.PadLeft(2,'0') + byte1.Text.PadLeft(2, '0') + byte2.Text.PadLeft(2, '0') + byte3.Text.PadLeft(2, '0') + byte4.Text.PadLeft(2, '0') + byte5.Text.PadLeft(2, '0') + byte6.Text.PadLeft(2, '0') + byte7.Text.PadLeft(2, '0'));
        }

        private void Hexonly_TextChanged(object sender, EventArgs e)
        {
            TextBox control = sender as TextBox;
            string item = control.Text;
            int n = 0;
            if (!int.TryParse(item, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) && item != String.Empty)
            {
                control.Text = item.Remove(item.Length - 1, 1);
                control.SelectionStart = control.Text.Length;
            }
        }
    }
}
