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
    public partial class Form : System.Windows.Forms.Form
    {
        ELM327Serial ELM327Serial = new ELM327Serial();

        List<VBF.VBF_File> VBFFileList = new List<VBF.VBF_File>();

        public Form()
        {
            InitializeComponent();
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
            string item = DataToStore.Text;
            int n = 0;
            if (!int.TryParse(item, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) && item != String.Empty)
            {
                DataToStore.Text = item.Remove(item.Length - 1, 1);
                DataToStore.SelectionStart = DataToStore.Text.Length;
            }
        }

        private void StoreData_Click(object sender, EventArgs e)
        {
            console.AppendText(">" + ELM327Serial.ATCommand.StoreData.ToString() + DataToStore.Text);
            console.AppendText(ELM327Serial.sendCommand(ELM327Serial.ATCommand.StoreData, DataToStore.Text));
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            console.AppendText(">" + ELM327Serial.ATCommand.ReadData.ToString());
            console.AppendText(ELM327Serial.sendCommand(ELM327Serial.ATCommand.ReadData));
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
                    bool connect = ELM327Serial.openPort();
                    if (connect)
                    {
                        connect_robot.Text = "DISCONNECT";
                        console.AppendText("Connected to Robot!\n");
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
    }
}
