using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELM327SWDL
{
    static class SWDL
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

        public struct erase
        {
            public string start_address;
            public string length;
        }

        public struct VBF_File
        {
            public string vbf_version;
            public string description;
            public string sw_part_number;
            public string sw_part_type;
            public string network;
            public string ecu_address;
            public string frame_format;
            public erase[] erase_block;
            public string file_checksum;
            public string[] data;
        }
    }
}
