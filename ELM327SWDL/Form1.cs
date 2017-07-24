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
            openVBFDialog.FilterIndex = 2;
            openVBFDialog.InitialDirectory = "c:\\";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .VBF file was selected, open it.  
            if (openVBFDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SWDL.VBF_File VBFFile;
                //String fileName = openVBFDialog.FileName();
                Stream myStream = openVBFDialog.OpenFile();
                StreamReader myStreamReader = new StreamReader(myStream);
                String vbfString = myStreamReader.ReadToEnd();
                String pattern = "vbf_version = (?<vbf_version>\\d.\\d);\\s+header {[\\S\\s]*description ?= ?{\"(?<description>.*)\"\\s*};[\\S\\s]*sw_part_number ?= ?\"(?<sw_part_number>.*)\";[\\S\\s]*sw_part_type = (?<sw_part_type>\\w+);[\\S\\s]*network ?= ?(?<network>\\w+);[\\S\\s]*ecu_address = (?<ecu_address>0[xX][0-9a-fA-F]+);[\\S\\s]*frame_format ?= ?(?<frame_format>\\w+);[\\S\\s]*erase = {(?<erase>[\\S\\s]*)};[\\S\\s]*file_checksum = (?<file_checksum>0[xX][0-9a-fA-F]+);[\\S\\s]*}";
                MatchCollection matches = Regex.Matches(vbfString, pattern);
                Match match = matches[0];
                VBFFile.vbf_version = match.Groups["vbf_version"].Value;
                VBFFile.description = match.Groups["description"].Value;
                VBFFile.sw_part_number = match.Groups["sw_part_number"].Value;
                VBFFile.sw_part_type = match.Groups["sw_part_type"].Value;
                VBFFile.network = match.Groups["network"].Value;
                VBFFile.ecu_address = match.Groups["ecu_address"].Value;
                VBFFile.frame_format = match.Groups["frame_format"].Value;
                VBFFile.file_checksum = match.Groups["file_checksum"].Value;
                string data_group = match.Groups["data"].Value;

                string erase_group = match.Groups["erase"].Value;
                String erase_pattern = "{\\s*(?<start_address>0[xX][0-9a-fA-F]+),\\s*(?<length>0[xX][0-9a-fA-F]+)\\s*}";
                MatchCollection erase_matches = Regex.Matches(erase_group, erase_pattern);
                for(int i = 0; i <= erase_matches.Count; i++)
                {
                    SWDL.erase crap;
                    crap.start_address = erase_matches[i].Groups["start_address"].Value;
                    crap.length = erase_matches[i].Groups["length"].Value;
                    //VBFFile.erase_block[i] = crap;
                }
                //FileStream sr = File.OpenRead(fileName);
                //sr.Seek(match.Length, SeekOrigin.Begin);
            }
        }

        private void openVBFDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
