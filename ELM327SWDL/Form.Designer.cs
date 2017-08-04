namespace ELM327SWDL
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.robot_com = new System.Windows.Forms.ComboBox();
            this.connect_robot = new System.Windows.Forms.Button();
            this.dvmgr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openVBFDialog = new System.Windows.Forms.OpenFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SWDL = new System.Windows.Forms.TabPage();
            this.UpButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.VBFFileGridView = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sw_part_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sw_part_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecu_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame_format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELM327 = new System.Windows.Forms.TabPage();
            this.RecommendedInitialization = new System.Windows.Forms.Button();
            this.ATProtocol = new System.Windows.Forms.GroupBox();
            this.ReadProtocolButton = new System.Windows.Forms.Button();
            this.AutoSearchOnFailure = new System.Windows.Forms.CheckBox();
            this.saej1939can = new System.Windows.Forms.RadioButton();
            this.iso157654can29id250kbaud = new System.Windows.Forms.RadioButton();
            this.iso157654can11id250kbaud = new System.Windows.Forms.RadioButton();
            this.iso157654can29id500kbaud = new System.Windows.Forms.RadioButton();
            this.iso157654can11id500kbaud = new System.Windows.Forms.RadioButton();
            this.iso142304kwpfastinit = new System.Windows.Forms.RadioButton();
            this.iso142304kwp5baud = new System.Windows.Forms.RadioButton();
            this.iso9141_2 = new System.Windows.Forms.RadioButton();
            this.saej1850vpw = new System.Windows.Forms.RadioButton();
            this.saeJ1850pwm = new System.Windows.Forms.RadioButton();
            this.AutomaticProtocol = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnableSpaces = new System.Windows.Forms.CheckBox();
            this.StoreData = new System.Windows.Forms.Button();
            this.ReadVoltage = new System.Windows.Forms.Button();
            this.ReadData = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DataToStore = new System.Windows.Forms.TextBox();
            this.ShowHeader = new System.Windows.Forms.CheckBox();
            this.EnableLineFeeds = new System.Windows.Forms.CheckBox();
            this.EchoCommand = new System.Windows.Forms.CheckBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.CANHeader = new System.Windows.Forms.GroupBox();
            this.can11header = new System.Windows.Forms.TextBox();
            this.set11bitheader = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monitortxheader = new System.Windows.Forms.TextBox();
            this.monitortx = new System.Windows.Forms.Button();
            this.monitorrx = new System.Windows.Forms.Button();
            this.monitorrxheader = new System.Windows.Forms.TextBox();
            this.monitorall = new System.Windows.Forms.Button();
            this.defaultbutton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.byte0 = new System.Windows.Forms.TextBox();
            this.byte1 = new System.Windows.Forms.TextBox();
            this.byte2 = new System.Windows.Forms.TextBox();
            this.byte3 = new System.Windows.Forms.TextBox();
            this.byte4 = new System.Windows.Forms.TextBox();
            this.byte5 = new System.Windows.Forms.TextBox();
            this.byte6 = new System.Windows.Forms.TextBox();
            this.byte7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.senddata = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SWDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VBFFileGridView)).BeginInit();
            this.ELM327.SuspendLayout();
            this.ATProtocol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CANHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.robot_com);
            this.groupBox3.Controls.Add(this.connect_robot);
            this.groupBox3.Controls.Add(this.dvmgr);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(583, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(280, 46);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect To ELM327";
            // 
            // robot_com
            // 
            this.robot_com.FormattingEnabled = true;
            this.robot_com.Location = new System.Drawing.Point(10, 16);
            this.robot_com.Margin = new System.Windows.Forms.Padding(2);
            this.robot_com.Name = "robot_com";
            this.robot_com.Size = new System.Drawing.Size(75, 21);
            this.robot_com.TabIndex = 5;
            this.robot_com.DropDown += new System.EventHandler(this.elmCom_Enter);
            // 
            // connect_robot
            // 
            this.connect_robot.BackColor = System.Drawing.Color.Red;
            this.connect_robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_robot.Location = new System.Drawing.Point(94, 14);
            this.connect_robot.Name = "connect_robot";
            this.connect_robot.Size = new System.Drawing.Size(93, 23);
            this.connect_robot.TabIndex = 4;
            this.connect_robot.Text = "CONNECT";
            this.connect_robot.UseVisualStyleBackColor = false;
            this.connect_robot.Click += new System.EventHandler(this.connect_robot_Click);
            // 
            // dvmgr
            // 
            this.dvmgr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvmgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvmgr.Location = new System.Drawing.Point(193, 9);
            this.dvmgr.Name = "dvmgr";
            this.dvmgr.Size = new System.Drawing.Size(79, 34);
            this.dvmgr.TabIndex = 1;
            this.dvmgr.Text = "DEVICE MANAGER";
            this.dvmgr.UseVisualStyleBackColor = false;
            this.dvmgr.Click += new System.EventHandler(this.dvgr_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Open_VBF_file);
            // 
            // openVBFDialog
            // 
            this.openVBFDialog.FileName = "openVBFDialog";
            this.openVBFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openVBFDialog_FileOk);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ELM327);
            this.TabControl.Controls.Add(this.SWDL);
            this.TabControl.Location = new System.Drawing.Point(8, 56);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(664, 322);
            this.TabControl.TabIndex = 9;
            // 
            // SWDL
            // 
            this.SWDL.Controls.Add(this.UpButton);
            this.SWDL.Controls.Add(this.DeleteButton);
            this.SWDL.Controls.Add(this.DownButton);
            this.SWDL.Controls.Add(this.VBFFileGridView);
            this.SWDL.Controls.Add(this.button1);
            this.SWDL.Location = new System.Drawing.Point(4, 22);
            this.SWDL.Margin = new System.Windows.Forms.Padding(2);
            this.SWDL.Name = "SWDL";
            this.SWDL.Padding = new System.Windows.Forms.Padding(2);
            this.SWDL.Size = new System.Drawing.Size(563, 296);
            this.SWDL.TabIndex = 0;
            this.SWDL.Text = "SWDL";
            this.SWDL.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(191, 267);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 11;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(353, 267);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(272, 267);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 9;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // VBFFileGridView
            // 
            this.VBFFileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VBFFileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.sw_part_number,
            this.sw_part_type,
            this.ecu_address,
            this.frame_format});
            this.VBFFileGridView.Location = new System.Drawing.Point(4, 4);
            this.VBFFileGridView.Margin = new System.Windows.Forms.Padding(2);
            this.VBFFileGridView.Name = "VBFFileGridView";
            this.VBFFileGridView.RowTemplate.Height = 28;
            this.VBFFileGridView.Size = new System.Drawing.Size(547, 259);
            this.VBFFileGridView.TabIndex = 0;
            this.VBFFileGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VBFFileGridView_CellContentClick);
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // sw_part_number
            // 
            this.sw_part_number.HeaderText = "sw_part_number";
            this.sw_part_number.Name = "sw_part_number";
            this.sw_part_number.ReadOnly = true;
            // 
            // sw_part_type
            // 
            this.sw_part_type.HeaderText = "sw_part_type";
            this.sw_part_type.Name = "sw_part_type";
            this.sw_part_type.ReadOnly = true;
            // 
            // ecu_address
            // 
            this.ecu_address.HeaderText = "ecu_address";
            this.ecu_address.Name = "ecu_address";
            this.ecu_address.ReadOnly = true;
            // 
            // frame_format
            // 
            this.frame_format.HeaderText = "frame_format";
            this.frame_format.Name = "frame_format";
            this.frame_format.ReadOnly = true;
            // 
            // ELM327
            // 
            this.ELM327.Controls.Add(this.groupBox4);
            this.ELM327.Controls.Add(this.groupBox2);
            this.ELM327.Controls.Add(this.CANHeader);
            this.ELM327.Controls.Add(this.RecommendedInitialization);
            this.ELM327.Controls.Add(this.ATProtocol);
            this.ELM327.Controls.Add(this.groupBox1);
            this.ELM327.Location = new System.Drawing.Point(4, 22);
            this.ELM327.Margin = new System.Windows.Forms.Padding(2);
            this.ELM327.Name = "ELM327";
            this.ELM327.Padding = new System.Windows.Forms.Padding(2);
            this.ELM327.Size = new System.Drawing.Size(656, 296);
            this.ELM327.TabIndex = 1;
            this.ELM327.Text = "ELM327";
            this.ELM327.UseVisualStyleBackColor = true;
            // 
            // RecommendedInitialization
            // 
            this.RecommendedInitialization.Location = new System.Drawing.Point(5, 5);
            this.RecommendedInitialization.Name = "RecommendedInitialization";
            this.RecommendedInitialization.Size = new System.Drawing.Size(134, 42);
            this.RecommendedInitialization.TabIndex = 13;
            this.RecommendedInitialization.Text = "Recommended Initialization";
            this.RecommendedInitialization.UseVisualStyleBackColor = true;
            this.RecommendedInitialization.Click += new System.EventHandler(this.RecommendedInitialization_Click);
            // 
            // ATProtocol
            // 
            this.ATProtocol.Controls.Add(this.ReadProtocolButton);
            this.ATProtocol.Controls.Add(this.AutoSearchOnFailure);
            this.ATProtocol.Controls.Add(this.saej1939can);
            this.ATProtocol.Controls.Add(this.iso157654can29id250kbaud);
            this.ATProtocol.Controls.Add(this.iso157654can11id250kbaud);
            this.ATProtocol.Controls.Add(this.iso157654can29id500kbaud);
            this.ATProtocol.Controls.Add(this.iso157654can11id500kbaud);
            this.ATProtocol.Controls.Add(this.iso142304kwpfastinit);
            this.ATProtocol.Controls.Add(this.iso142304kwp5baud);
            this.ATProtocol.Controls.Add(this.iso9141_2);
            this.ATProtocol.Controls.Add(this.saej1850vpw);
            this.ATProtocol.Controls.Add(this.saeJ1850pwm);
            this.ATProtocol.Controls.Add(this.AutomaticProtocol);
            this.ATProtocol.Location = new System.Drawing.Point(145, 5);
            this.ATProtocol.Name = "ATProtocol";
            this.ATProtocol.Size = new System.Drawing.Size(267, 286);
            this.ATProtocol.TabIndex = 10;
            this.ATProtocol.TabStop = false;
            this.ATProtocol.Text = "AT Protocol";
            // 
            // ReadProtocolButton
            // 
            this.ReadProtocolButton.Location = new System.Drawing.Point(178, 40);
            this.ReadProtocolButton.Name = "ReadProtocolButton";
            this.ReadProtocolButton.Size = new System.Drawing.Size(83, 23);
            this.ReadProtocolButton.TabIndex = 12;
            this.ReadProtocolButton.Text = "Read Protocol";
            this.ReadProtocolButton.UseVisualStyleBackColor = true;
            this.ReadProtocolButton.Click += new System.EventHandler(this.ReadProtocolButton_Click);
            // 
            // AutoSearchOnFailure
            // 
            this.AutoSearchOnFailure.AutoSize = true;
            this.AutoSearchOnFailure.Location = new System.Drawing.Point(127, 21);
            this.AutoSearchOnFailure.Name = "AutoSearchOnFailure";
            this.AutoSearchOnFailure.Size = new System.Drawing.Size(134, 17);
            this.AutoSearchOnFailure.TabIndex = 11;
            this.AutoSearchOnFailure.Text = "Auto Search on Failure";
            this.AutoSearchOnFailure.UseVisualStyleBackColor = true;
            // 
            // saej1939can
            // 
            this.saej1939can.AutoSize = true;
            this.saej1939can.Location = new System.Drawing.Point(7, 249);
            this.saej1939can.Name = "saej1939can";
            this.saej1939can.Size = new System.Drawing.Size(213, 17);
            this.saej1939can.TabIndex = 10;
            this.saej1939can.TabStop = true;
            this.saej1939can.Text = "SAE J1939 CAN (29 bit ID, 250* kbaud)";
            this.saej1939can.UseVisualStyleBackColor = true;
            this.saej1939can.Click += new System.EventHandler(this.saej1939can_Click);
            // 
            // iso157654can29id250kbaud
            // 
            this.iso157654can29id250kbaud.AutoSize = true;
            this.iso157654can29id250kbaud.Location = new System.Drawing.Point(7, 226);
            this.iso157654can29id250kbaud.Name = "iso157654can29id250kbaud";
            this.iso157654can29id250kbaud.Size = new System.Drawing.Size(216, 17);
            this.iso157654can29id250kbaud.TabIndex = 9;
            this.iso157654can29id250kbaud.TabStop = true;
            this.iso157654can29id250kbaud.Text = "ISO 15765-4 CAN (29 bit ID, 250 kbaud)";
            this.iso157654can29id250kbaud.UseVisualStyleBackColor = true;
            this.iso157654can29id250kbaud.Click += new System.EventHandler(this.iso157654can29id250kbaud_Click);
            // 
            // iso157654can11id250kbaud
            // 
            this.iso157654can11id250kbaud.AutoSize = true;
            this.iso157654can11id250kbaud.Location = new System.Drawing.Point(7, 203);
            this.iso157654can11id250kbaud.Name = "iso157654can11id250kbaud";
            this.iso157654can11id250kbaud.Size = new System.Drawing.Size(216, 17);
            this.iso157654can11id250kbaud.TabIndex = 8;
            this.iso157654can11id250kbaud.TabStop = true;
            this.iso157654can11id250kbaud.Text = "ISO 15765-4 CAN (11 bit ID, 250 kbaud)";
            this.iso157654can11id250kbaud.UseVisualStyleBackColor = true;
            this.iso157654can11id250kbaud.Click += new System.EventHandler(this.iso157654can11id250kbaud_Click);
            // 
            // iso157654can29id500kbaud
            // 
            this.iso157654can29id500kbaud.AutoSize = true;
            this.iso157654can29id500kbaud.Location = new System.Drawing.Point(7, 180);
            this.iso157654can29id500kbaud.Name = "iso157654can29id500kbaud";
            this.iso157654can29id500kbaud.Size = new System.Drawing.Size(216, 17);
            this.iso157654can29id500kbaud.TabIndex = 7;
            this.iso157654can29id500kbaud.TabStop = true;
            this.iso157654can29id500kbaud.Text = "ISO 15765-4 CAN (29 bit ID, 500 kbaud)";
            this.iso157654can29id500kbaud.UseVisualStyleBackColor = true;
            this.iso157654can29id500kbaud.Click += new System.EventHandler(this.iso157654can29id500kbaud_Click);
            // 
            // iso157654can11id500kbaud
            // 
            this.iso157654can11id500kbaud.AutoSize = true;
            this.iso157654can11id500kbaud.Location = new System.Drawing.Point(7, 157);
            this.iso157654can11id500kbaud.Name = "iso157654can11id500kbaud";
            this.iso157654can11id500kbaud.Size = new System.Drawing.Size(216, 17);
            this.iso157654can11id500kbaud.TabIndex = 6;
            this.iso157654can11id500kbaud.TabStop = true;
            this.iso157654can11id500kbaud.Text = "ISO 15765-4 CAN (11 bit ID, 500 kbaud)";
            this.iso157654can11id500kbaud.UseVisualStyleBackColor = true;
            this.iso157654can11id500kbaud.Click += new System.EventHandler(this.iso157654can11id500kbaud_Click);
            // 
            // iso142304kwpfastinit
            // 
            this.iso142304kwpfastinit.AutoSize = true;
            this.iso142304kwpfastinit.Location = new System.Drawing.Point(7, 134);
            this.iso142304kwpfastinit.Name = "iso142304kwpfastinit";
            this.iso142304kwpfastinit.Size = new System.Drawing.Size(155, 17);
            this.iso142304kwpfastinit.TabIndex = 5;
            this.iso142304kwpfastinit.TabStop = true;
            this.iso142304kwpfastinit.Text = "ISO 14230-4 KWP (fast init)";
            this.iso142304kwpfastinit.UseVisualStyleBackColor = true;
            this.iso142304kwpfastinit.Click += new System.EventHandler(this.iso142304kwpfastinit_Click);
            // 
            // iso142304kwp5baud
            // 
            this.iso142304kwp5baud.AutoSize = true;
            this.iso142304kwp5baud.Location = new System.Drawing.Point(7, 112);
            this.iso142304kwp5baud.Name = "iso142304kwp5baud";
            this.iso142304kwp5baud.Size = new System.Drawing.Size(171, 17);
            this.iso142304kwp5baud.TabIndex = 4;
            this.iso142304kwp5baud.TabStop = true;
            this.iso142304kwp5baud.Text = "ISO 14230-4 KWP (5 baud init)";
            this.iso142304kwp5baud.UseVisualStyleBackColor = true;
            this.iso142304kwp5baud.Click += new System.EventHandler(this.iso142304kwp5baud_Click);
            // 
            // iso9141_2
            // 
            this.iso9141_2.AutoSize = true;
            this.iso9141_2.Location = new System.Drawing.Point(7, 89);
            this.iso9141_2.Name = "iso9141_2";
            this.iso9141_2.Size = new System.Drawing.Size(137, 17);
            this.iso9141_2.TabIndex = 3;
            this.iso9141_2.TabStop = true;
            this.iso9141_2.Text = "ISO 9141-2 (5 baud init)";
            this.iso9141_2.UseVisualStyleBackColor = true;
            this.iso9141_2.Click += new System.EventHandler(this.iso9141_2_Click);
            // 
            // saej1850vpw
            // 
            this.saej1850vpw.AutoSize = true;
            this.saej1850vpw.Location = new System.Drawing.Point(7, 66);
            this.saej1850vpw.Name = "saej1850vpw";
            this.saej1850vpw.Size = new System.Drawing.Size(169, 17);
            this.saej1850vpw.TabIndex = 2;
            this.saej1850vpw.TabStop = true;
            this.saej1850vpw.Text = "SAE J1850 VPW (10.4 kbaud)";
            this.saej1850vpw.UseVisualStyleBackColor = true;
            this.saej1850vpw.Click += new System.EventHandler(this.saej1850vpw_Click);
            // 
            // saeJ1850pwm
            // 
            this.saeJ1850pwm.AutoSize = true;
            this.saeJ1850pwm.Location = new System.Drawing.Point(7, 43);
            this.saeJ1850pwm.Name = "saeJ1850pwm";
            this.saeJ1850pwm.Size = new System.Drawing.Size(171, 17);
            this.saeJ1850pwm.TabIndex = 1;
            this.saeJ1850pwm.TabStop = true;
            this.saeJ1850pwm.Text = "SAE J1850 PWM (41.6 kbaud)";
            this.saeJ1850pwm.UseVisualStyleBackColor = true;
            this.saeJ1850pwm.Click += new System.EventHandler(this.saeJ1850pwm_Click);
            // 
            // AutomaticProtocol
            // 
            this.AutomaticProtocol.AutoSize = true;
            this.AutomaticProtocol.Location = new System.Drawing.Point(7, 20);
            this.AutomaticProtocol.Name = "AutomaticProtocol";
            this.AutomaticProtocol.Size = new System.Drawing.Size(72, 17);
            this.AutomaticProtocol.TabIndex = 0;
            this.AutomaticProtocol.TabStop = true;
            this.AutomaticProtocol.Text = "Automatic";
            this.AutomaticProtocol.UseVisualStyleBackColor = true;
            this.AutomaticProtocol.CheckedChanged += new System.EventHandler(this.AutomaticProtocol_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defaultbutton);
            this.groupBox1.Controls.Add(this.EnableSpaces);
            this.groupBox1.Controls.Add(this.StoreData);
            this.groupBox1.Controls.Add(this.ReadVoltage);
            this.groupBox1.Controls.Add(this.ReadData);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.DataToStore);
            this.groupBox1.Controls.Add(this.ShowHeader);
            this.groupBox1.Controls.Add(this.EnableLineFeeds);
            this.groupBox1.Controls.Add(this.EchoCommand);
            this.groupBox1.Location = new System.Drawing.Point(5, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 241);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Commands";
            // 
            // EnableSpaces
            // 
            this.EnableSpaces.AutoSize = true;
            this.EnableSpaces.Location = new System.Drawing.Point(9, 85);
            this.EnableSpaces.Name = "EnableSpaces";
            this.EnableSpaces.Size = new System.Drawing.Size(98, 17);
            this.EnableSpaces.TabIndex = 8;
            this.EnableSpaces.Text = "Enable Spaces";
            this.EnableSpaces.UseVisualStyleBackColor = true;
            this.EnableSpaces.Click += new System.EventHandler(this.EnableSpaces_Click);
            // 
            // StoreData
            // 
            this.StoreData.Location = new System.Drawing.Point(9, 108);
            this.StoreData.Name = "StoreData";
            this.StoreData.Size = new System.Drawing.Size(75, 23);
            this.StoreData.TabIndex = 0;
            this.StoreData.Text = "Store Data";
            this.StoreData.UseVisualStyleBackColor = true;
            this.StoreData.Click += new System.EventHandler(this.StoreData_Click);
            // 
            // ReadVoltage
            // 
            this.ReadVoltage.Location = new System.Drawing.Point(9, 154);
            this.ReadVoltage.Name = "ReadVoltage";
            this.ReadVoltage.Size = new System.Drawing.Size(91, 23);
            this.ReadVoltage.TabIndex = 7;
            this.ReadVoltage.Text = "Read Voltage";
            this.ReadVoltage.UseVisualStyleBackColor = true;
            this.ReadVoltage.Click += new System.EventHandler(this.ReadVoltage_Click);
            // 
            // ReadData
            // 
            this.ReadData.Location = new System.Drawing.Point(9, 131);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(75, 23);
            this.ReadData.TabIndex = 1;
            this.ReadData.Text = "Read Data";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(9, 177);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DataToStore
            // 
            this.DataToStore.Location = new System.Drawing.Point(90, 109);
            this.DataToStore.MaxLength = 2;
            this.DataToStore.Name = "DataToStore";
            this.DataToStore.Size = new System.Drawing.Size(28, 20);
            this.DataToStore.TabIndex = 2;
            this.DataToStore.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // ShowHeader
            // 
            this.ShowHeader.AutoSize = true;
            this.ShowHeader.Location = new System.Drawing.Point(9, 61);
            this.ShowHeader.Name = "ShowHeader";
            this.ShowHeader.Size = new System.Drawing.Size(91, 17);
            this.ShowHeader.TabIndex = 5;
            this.ShowHeader.Text = "Show Header";
            this.ShowHeader.UseVisualStyleBackColor = true;
            this.ShowHeader.CheckedChanged += new System.EventHandler(this.ShowHeader_CheckedChanged);
            // 
            // EnableLineFeeds
            // 
            this.EnableLineFeeds.AutoSize = true;
            this.EnableLineFeeds.Location = new System.Drawing.Point(9, 15);
            this.EnableLineFeeds.Name = "EnableLineFeeds";
            this.EnableLineFeeds.Size = new System.Drawing.Size(114, 17);
            this.EnableLineFeeds.TabIndex = 3;
            this.EnableLineFeeds.Text = "Enable Line Feeds";
            this.EnableLineFeeds.UseVisualStyleBackColor = true;
            this.EnableLineFeeds.CheckedChanged += new System.EventHandler(this.EnableLineFeeds_CheckedChanged);
            // 
            // EchoCommand
            // 
            this.EchoCommand.AutoSize = true;
            this.EchoCommand.Location = new System.Drawing.Point(9, 38);
            this.EchoCommand.Name = "EchoCommand";
            this.EchoCommand.Size = new System.Drawing.Size(101, 17);
            this.EchoCommand.TabIndex = 4;
            this.EchoCommand.Text = "Echo Command";
            this.EchoCommand.UseVisualStyleBackColor = true;
            this.EchoCommand.CheckedChanged += new System.EventHandler(this.EchoCommand_CheckedChanged);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(677, 78);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(188, 296);
            this.console.TabIndex = 13;
            this.console.Text = "";
            // 
            // CANHeader
            // 
            this.CANHeader.Controls.Add(this.set11bitheader);
            this.CANHeader.Controls.Add(this.can11header);
            this.CANHeader.Location = new System.Drawing.Point(419, 5);
            this.CANHeader.Name = "CANHeader";
            this.CANHeader.Size = new System.Drawing.Size(139, 51);
            this.CANHeader.TabIndex = 14;
            this.CANHeader.TabStop = false;
            this.CANHeader.Text = "CAN Header";
            // 
            // can11header
            // 
            this.can11header.Location = new System.Drawing.Point(6, 20);
            this.can11header.MaxLength = 3;
            this.can11header.Name = "can11header";
            this.can11header.Size = new System.Drawing.Size(35, 20);
            this.can11header.TabIndex = 0;
            this.can11header.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // set11bitheader
            // 
            this.set11bitheader.Location = new System.Drawing.Point(58, 18);
            this.set11bitheader.Name = "set11bitheader";
            this.set11bitheader.Size = new System.Drawing.Size(75, 23);
            this.set11bitheader.TabIndex = 1;
            this.set11bitheader.Text = "Set 11 bit Header";
            this.set11bitheader.UseVisualStyleBackColor = true;
            this.set11bitheader.Click += new System.EventHandler(this.set11bitheader_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monitorall);
            this.groupBox2.Controls.Add(this.monitorrx);
            this.groupBox2.Controls.Add(this.monitorrxheader);
            this.groupBox2.Controls.Add(this.monitortx);
            this.groupBox2.Controls.Add(this.monitortxheader);
            this.groupBox2.Location = new System.Drawing.Point(419, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitor";
            // 
            // monitortxheader
            // 
            this.monitortxheader.Location = new System.Drawing.Point(7, 20);
            this.monitortxheader.Name = "monitortxheader";
            this.monitortxheader.Size = new System.Drawing.Size(34, 20);
            this.monitortxheader.TabIndex = 0;
            this.monitortxheader.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // monitortx
            // 
            this.monitortx.Location = new System.Drawing.Point(58, 20);
            this.monitortx.Name = "monitortx";
            this.monitortx.Size = new System.Drawing.Size(75, 23);
            this.monitortx.TabIndex = 1;
            this.monitortx.Text = "Monitor Tx";
            this.monitortx.UseVisualStyleBackColor = true;
            this.monitortx.Click += new System.EventHandler(this.monitortx_Click);
            // 
            // monitorrx
            // 
            this.monitorrx.Location = new System.Drawing.Point(58, 48);
            this.monitorrx.Name = "monitorrx";
            this.monitorrx.Size = new System.Drawing.Size(75, 23);
            this.monitorrx.TabIndex = 3;
            this.monitorrx.Text = "Monitor Rx";
            this.monitorrx.UseVisualStyleBackColor = true;
            this.monitorrx.Click += new System.EventHandler(this.monitorrx_Click);
            // 
            // monitorrxheader
            // 
            this.monitorrxheader.Location = new System.Drawing.Point(7, 50);
            this.monitorrxheader.Name = "monitorrxheader";
            this.monitorrxheader.Size = new System.Drawing.Size(34, 20);
            this.monitorrxheader.TabIndex = 2;
            this.monitorrxheader.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // monitorall
            // 
            this.monitorall.Location = new System.Drawing.Point(31, 77);
            this.monitorall.Name = "monitorall";
            this.monitorall.Size = new System.Drawing.Size(75, 23);
            this.monitorall.TabIndex = 4;
            this.monitorall.Text = "Monitor All";
            this.monitorall.UseVisualStyleBackColor = true;
            this.monitorall.Click += new System.EventHandler(this.monitorall_Click);
            // 
            // defaultbutton
            // 
            this.defaultbutton.Location = new System.Drawing.Point(9, 200);
            this.defaultbutton.Name = "defaultbutton";
            this.defaultbutton.Size = new System.Drawing.Size(75, 23);
            this.defaultbutton.TabIndex = 9;
            this.defaultbutton.Text = "Default";
            this.defaultbutton.UseVisualStyleBackColor = true;
            this.defaultbutton.Click += new System.EventHandler(this.defaultbutton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.senddata);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.byte7);
            this.groupBox4.Controls.Add(this.byte6);
            this.groupBox4.Controls.Add(this.byte5);
            this.groupBox4.Controls.Add(this.byte4);
            this.groupBox4.Controls.Add(this.byte3);
            this.groupBox4.Controls.Add(this.byte2);
            this.groupBox4.Controls.Add(this.byte1);
            this.groupBox4.Controls.Add(this.byte0);
            this.groupBox4.Location = new System.Drawing.Point(419, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 81);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // byte0
            // 
            this.byte0.Location = new System.Drawing.Point(6, 28);
            this.byte0.MaxLength = 2;
            this.byte0.Name = "byte0";
            this.byte0.Size = new System.Drawing.Size(22, 20);
            this.byte0.TabIndex = 0;
            this.byte0.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte1
            // 
            this.byte1.Location = new System.Drawing.Point(34, 28);
            this.byte1.MaxLength = 2;
            this.byte1.Name = "byte1";
            this.byte1.Size = new System.Drawing.Size(22, 20);
            this.byte1.TabIndex = 1;
            this.byte1.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte2
            // 
            this.byte2.Location = new System.Drawing.Point(62, 28);
            this.byte2.MaxLength = 2;
            this.byte2.Name = "byte2";
            this.byte2.Size = new System.Drawing.Size(22, 20);
            this.byte2.TabIndex = 2;
            this.byte2.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte3
            // 
            this.byte3.Location = new System.Drawing.Point(90, 28);
            this.byte3.MaxLength = 2;
            this.byte3.Name = "byte3";
            this.byte3.Size = new System.Drawing.Size(22, 20);
            this.byte3.TabIndex = 3;
            this.byte3.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte4
            // 
            this.byte4.Location = new System.Drawing.Point(116, 28);
            this.byte4.MaxLength = 2;
            this.byte4.Name = "byte4";
            this.byte4.Size = new System.Drawing.Size(22, 20);
            this.byte4.TabIndex = 4;
            this.byte4.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte5
            // 
            this.byte5.Location = new System.Drawing.Point(144, 28);
            this.byte5.MaxLength = 2;
            this.byte5.Name = "byte5";
            this.byte5.Size = new System.Drawing.Size(22, 20);
            this.byte5.TabIndex = 5;
            this.byte5.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte6
            // 
            this.byte6.Location = new System.Drawing.Point(172, 28);
            this.byte6.MaxLength = 2;
            this.byte6.Name = "byte6";
            this.byte6.Size = new System.Drawing.Size(22, 20);
            this.byte6.TabIndex = 6;
            this.byte6.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // byte7
            // 
            this.byte7.Location = new System.Drawing.Point(200, 28);
            this.byte7.MaxLength = 2;
            this.byte7.Name = "byte7";
            this.byte7.Size = new System.Drawing.Size(22, 20);
            this.byte7.TabIndex = 7;
            this.byte7.TextChanged += new System.EventHandler(this.Hexonly_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "#0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "#1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "#2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "#3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "#4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "#5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "#6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "#7";
            // 
            // senddata
            // 
            this.senddata.Location = new System.Drawing.Point(76, 54);
            this.senddata.Name = "senddata";
            this.senddata.Size = new System.Drawing.Size(75, 23);
            this.senddata.TabIndex = 16;
            this.senddata.Text = "Send Data";
            this.senddata.UseVisualStyleBackColor = true;
            this.senddata.Click += new System.EventHandler(this.senddata_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 389);
            this.Controls.Add(this.console);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.SWDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VBFFileGridView)).EndInit();
            this.ELM327.ResumeLayout(false);
            this.ATProtocol.ResumeLayout(false);
            this.ATProtocol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CANHeader.ResumeLayout(false);
            this.CANHeader.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox robot_com;
        private System.Windows.Forms.Button connect_robot;
        private System.Windows.Forms.Button dvmgr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openVBFDialog;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SWDL;
        private System.Windows.Forms.TabPage ELM327;
        private System.Windows.Forms.DataGridView VBFFileGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn sw_part_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn sw_part_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecu_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame_format;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.TextBox DataToStore;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.Button StoreData;
        private System.Windows.Forms.CheckBox EnableLineFeeds;
        private System.Windows.Forms.CheckBox EchoCommand;
        private System.Windows.Forms.CheckBox ShowHeader;
        private System.Windows.Forms.Button ReadVoltage;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox EnableSpaces;
        private System.Windows.Forms.GroupBox ATProtocol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton saej1939can;
        private System.Windows.Forms.RadioButton iso157654can29id250kbaud;
        private System.Windows.Forms.RadioButton iso157654can11id250kbaud;
        private System.Windows.Forms.RadioButton iso157654can29id500kbaud;
        private System.Windows.Forms.RadioButton iso157654can11id500kbaud;
        private System.Windows.Forms.RadioButton iso142304kwpfastinit;
        private System.Windows.Forms.RadioButton iso142304kwp5baud;
        private System.Windows.Forms.RadioButton iso9141_2;
        private System.Windows.Forms.RadioButton saej1850vpw;
        private System.Windows.Forms.RadioButton saeJ1850pwm;
        private System.Windows.Forms.RadioButton AutomaticProtocol;
        private System.Windows.Forms.Button ReadProtocolButton;
        private System.Windows.Forms.CheckBox AutoSearchOnFailure;
        private System.Windows.Forms.Button RecommendedInitialization;
        private System.Windows.Forms.GroupBox CANHeader;
        private System.Windows.Forms.TextBox can11header;
        private System.Windows.Forms.Button set11bitheader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox monitortxheader;
        private System.Windows.Forms.Button monitortx;
        private System.Windows.Forms.Button monitorrx;
        private System.Windows.Forms.TextBox monitorrxheader;
        private System.Windows.Forms.Button monitorall;
        private System.Windows.Forms.Button defaultbutton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox byte7;
        private System.Windows.Forms.TextBox byte6;
        private System.Windows.Forms.TextBox byte5;
        private System.Windows.Forms.TextBox byte4;
        private System.Windows.Forms.TextBox byte3;
        private System.Windows.Forms.TextBox byte2;
        private System.Windows.Forms.TextBox byte1;
        private System.Windows.Forms.TextBox byte0;
        private System.Windows.Forms.Button senddata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

