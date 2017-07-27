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
            public string length { get; set; }
            public List<byte> data { get; set; }
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
            public string call { get; set; }
            public string omit { get; set; }
            public string data_format_identifier { get; set; }
            public List<erase> binary_block { get; set; }
        }

        public static VBF_File parseVBFFile(string FileName)
        {
            //open FILE
            VBF_File VBFFile = new VBF_File();
            StreamReader myStreamReader = new StreamReader(FileName);
            String vbfString = myStreamReader.ReadToEnd();

            //parse HEADER
            String pattern = "[\\S\\s]*header *\\{(?<header>((?>[^{}]+|{(?<c>)|\\}(?<-c>))*(?(c)(?!))))\\}";
            Match header = Regex.Match(vbfString, pattern);
            String headerString = header.Groups["header"].Value;

            VBFFile.vbf_version = Regex.Match(vbfString, "vbf_version *= *(?<vbf_version>\\d.\\d);").Groups["vbf_version"].Value;
            //VBFFile.vbf_version = match.Groups["vbf_version"].Value;

            VBFFile.description = Regex.Match(vbfString, "description *= *{\"(?<description>.*)\"\\s*};").Groups["description"].Value;
            //VBFFile.description = match.Groups["description"].Value;

            VBFFile.sw_part_number = Regex.Match(vbfString, "sw_part_number *= *\"(?<sw_part_number>.*)\";").Groups["sw_part_number"].Value;
            //VBFFile.sw_part_number = match.Groups["sw_part_number"].Value;

            VBFFile.sw_part_type = Regex.Match(vbfString, "sw_part_type *= *(?<sw_part_type>\\w+);").Groups["sw_part_type"].Value;
            //VBFFile.sw_part_type = match.Groups["sw_part_type"].Value;

            VBFFile.network = Regex.Match(vbfString, "network *= *(?<network>\\w+);").Groups["network"].Value;
            //VBFFile.network = match.Groups["network"].Value;

            VBFFile.ecu_address = Regex.Match(vbfString, "ecu_address *= *(?<ecu_address>0[xX][0-9a-fA-F]+);").Groups["ecu_address"].Value;
            //VBFFile.ecu_address = match.Groups["ecu_address"].Value;

            VBFFile.frame_format = Regex.Match(vbfString, "frame_format *= *(?<frame_format>\\w+);").Groups["frame_format"].Value;
            //VBFFile.frame_format = match.Groups["frame_format"].Value;

            VBFFile.file_checksum = Regex.Match(vbfString, "file_checksum *= *(?<file_checksum>0[xX][0-9a-fA-F]+);").Groups["file_checksum"].Value;
            //VBFFile.file_checksum = match.Groups["file_checksum"].Value;

            if (VBFFile.sw_part_type == "SBL" || VBFFile.sw_part_type == "GBL")
            {
                VBFFile.call = Regex.Match(vbfString, "call *= *(?<call>0[xX][0-9a-fA-F]+);").Groups["call"].Value;
                VBFFile.binary_block = new List<erase>();
                FileStream sr = File.OpenRead(FileName);
                sr.Seek(header.Length, SeekOrigin.Begin);
                erase block = new erase();
                block.data = new List<byte>();
                //sr.Seek(sr.Position + 4, SeekOrigin.Begin); //skip address
                block.start_address = "0x";
                for(int i = 0; i < 4; i++)
                {
                    block.start_address += Convert.ToByte(sr.ReadByte()).ToString("X2");
                }
                //sr.Seek(sr.Position + 4, SeekOrigin.Begin); //skip length
                block.length = "0x";
                for (int i = 0; i < 4; i++)
                {
                    block.length += Convert.ToByte(sr.ReadByte()).ToString("X2");
                }
                for (int j = 0; j < Convert.ToInt32(block.length, 16); j++)
                {
                    byte dataByte = Convert.ToByte(sr.ReadByte());
                    block.data.Add(dataByte);
                }
                sr.Seek(sr.Position + 2, SeekOrigin.Begin); //skip checksum
                VBFFile.binary_block.Add(block);
            }
            else if(VBFFile.sw_part_type == "TEST")
            {
                //TODO: 'attempt to find call'
            }
            else
            {
                string erase_group;
                erase_group = Regex.Match(vbfString, "erase *= *{(?<erase>[\\S\\s]*)};").Groups["erase"].Value;
                //string erase_group = match.Groups["erase"].Value;
                String erase_pattern = "{\\s*(?<start_address>0[xX][0-9a-fA-F]+),\\s*(?<length>0[xX][0-9a-fA-F]+)\\s*}";
                MatchCollection erase_matches = Regex.Matches(erase_group, erase_pattern);
                VBFFile.binary_block = new List<erase>();
                FileStream sr = File.OpenRead(FileName);
                sr.Seek(header.Length, SeekOrigin.Begin);
                for (int i = 0; i < erase_matches.Count; i++)
                {
                    erase block = new erase();
                    block.start_address = erase_matches[i].Groups["start_address"].Value;
                    block.length = erase_matches[i].Groups["length"].Value;
                    block.data = new List<byte>();
                    sr.Seek(sr.Position + 4, SeekOrigin.Begin); //skip address
                    sr.Seek(sr.Position + 4, SeekOrigin.Begin); //skip length
                    for (int j = 0; j < Convert.ToInt32(block.length, 16); j++)
                    {
                        block.data.Add(Convert.ToByte(sr.ReadByte()));
                    }
                    sr.Seek(sr.Position + 2, SeekOrigin.Begin); //skip checksum
                    VBFFile.binary_block.Add(block);
                }
            }

            return VBFFile;
        }
    }
}
