namespace ELM327SWDL
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.VBFFileGridView = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sw_part_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sw_part_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecu_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame_format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VBFFileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.robot_com);
            this.groupBox3.Controls.Add(this.connect_robot);
            this.groupBox3.Controls.Add(this.dvmgr);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(445, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect To ELM327";
            // 
            // robot_com
            // 
            this.robot_com.FormattingEnabled = true;
            this.robot_com.Location = new System.Drawing.Point(15, 25);
            this.robot_com.Name = "robot_com";
            this.robot_com.Size = new System.Drawing.Size(110, 28);
            this.robot_com.TabIndex = 5;
            this.robot_com.DropDown += new System.EventHandler(this.elmCom_Enter);
            // 
            // connect_robot
            // 
            this.connect_robot.BackColor = System.Drawing.Color.Red;
            this.connect_robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_robot.Location = new System.Drawing.Point(141, 22);
            this.connect_robot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connect_robot.Name = "connect_robot";
            this.connect_robot.Size = new System.Drawing.Size(140, 35);
            this.connect_robot.TabIndex = 4;
            this.connect_robot.Text = "CONNECT";
            this.connect_robot.UseVisualStyleBackColor = false;
            // 
            // dvmgr
            // 
            this.dvmgr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvmgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvmgr.Location = new System.Drawing.Point(290, 14);
            this.dvmgr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvmgr.Name = "dvmgr";
            this.dvmgr.Size = new System.Drawing.Size(118, 52);
            this.dvmgr.TabIndex = 1;
            this.dvmgr.Text = "DEVICE MANAGER";
            this.dvmgr.UseVisualStyleBackColor = false;
            this.dvmgr.Click += new System.EventHandler(this.dvgr_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
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
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 86);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(841, 440);
            this.TabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VBFFileGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.VBFFileGridView.Location = new System.Drawing.Point(6, 6);
            this.VBFFileGridView.Name = "VBFFileGridView";
            this.VBFFileGridView.RowTemplate.Height = 28;
            this.VBFFileGridView.Size = new System.Drawing.Size(821, 353);
            this.VBFFileGridView.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 583);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VBFFileGridView)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView VBFFileGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn sw_part_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn sw_part_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecu_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame_format;
    }
}

