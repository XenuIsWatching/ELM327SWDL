using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELM327SWDL
{
    class SWDL
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class erase
        {
            public string start_address { get; set; }
            public List<int> data { get; set; }
            public string length { get; set; }
        }

        public class VBF_File
        {
            public string vbf_version { get; set; }
            public string description { get; set; }
            public string sw_part_number { get; set; }
            public string sw_part_type { get; set; }
            public string network { get; set; }
            public string ecu_address { get; set; }
            public string frame_format { get; set; }
            public string file_checksum { get; set; }
            public List<erase> erase_block { get; set; }
        }

        public static VBF_File parseVBFFile(string FileName)
        {
            //open FILE
            VBF_File VBFFile = new VBF_File();
            StreamReader myStreamReader = new StreamReader(FileName);
            String vbfString = myStreamReader.ReadToEnd();

            //parse HEADER
            String pattern = "vbf_version = (?<vbf_version>\\d.\\d);\\s+header {[\\S\\s]*description ?= ?{\"(?<description>.*)\"\\s*};[\\S\\s]*sw_part_number ?= ?\"(?<sw_part_number>.*)\";[\\S\\s]*sw_part_type = (?<sw_part_type>\\w+);[\\S\\s]*network ?= ?(?<network>\\w+);[\\S\\s]*ecu_address = (?<ecu_address>0[xX][0-9a-fA-F]+);[\\S\\s]*frame_format ?= ?(?<frame_format>\\w+);[\\S\\s]*erase = {(?<erase>[\\S\\s]*)};[\\S\\s]*file_checksum = (?<file_checksum>0[xX][0-9a-fA-F]+);[\\n\\r\\s]*}";
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
            VBFFile.erase_block = new List<erase>();

            FileStream sr = File.OpenRead(FileName);
            sr.Seek(match.Length, SeekOrigin.Begin);
            for (int i = 0; i < erase_matches.Count; i++)
            {
                erase block = new erase();
                block.start_address = erase_matches[i].Groups["start_address"].Value;
                block.length = erase_matches[i].Groups["length"].Value;
                block.data = new List<int>();
                sr.Seek(sr.Position + 4, SeekOrigin.Begin); //skip address
                sr.Seek(sr.Position + 4, SeekOrigin.Begin); //skip length
                for (int j = 0; j < Convert.ToInt32(block.length, 16); j++)
                {
                    block.data.Add(sr.ReadByte());
                }
                sr.Seek(sr.Position + 2, SeekOrigin.Begin); //skip checksum
                VBFFile.erase_block.Add(block);
            }

            return VBFFile;
        }
    }
}
