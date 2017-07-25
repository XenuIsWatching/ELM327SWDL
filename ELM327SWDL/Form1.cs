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
    public partial class Form1 : Form
    {
        List<SWDL.VBF_File> VBFFileList = new List<SWDL.VBF_File>();

        public Form1()
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
                SWDL.VBF_File VBFFile = SWDL.parseVBFFile(openVBFDialog.FileName);
                int row = VBFFileGridView.Rows.Add();
                VBFFileGridView.Rows[row].Cells[0].Value = VBFFile.description;
                VBFFileGridView.Rows[row].Cells[1].Value = VBFFile.sw_part_number;
                VBFFileGridView.Rows[row].Cells[2].Value = VBFFile.sw_part_type;
                VBFFileGridView.Rows[row].Cells[3].Value = VBFFile.ecu_address;
                VBFFileGridView.Rows[row].Cells[4].Value = VBFFile.frame_format;
                VBFFileList.Insert(row, VBFFile);
            }
        }

        private void openVBFDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void VBFFileGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static void SwapVBF(IList<SWDL.VBF_File> list, int indexA, int indexB)
        {
            SWDL.VBF_File tmp = list[indexA];
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
    }
}
