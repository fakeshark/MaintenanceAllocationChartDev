namespace MaintenanceAllocationChartDeveloper
{
    partial class frmMacDevMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMacDevMain));
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompAssy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintFunct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.projectSettings = new System.Windows.Forms.TabPage();
            this.gbxRemarks = new System.Windows.Forms.GroupBox();
            this.gbxToolsTestEquip = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.lblTMnumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableEditor = new System.Windows.Forms.TabPage();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.fileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblVersionNum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainTabControl.SuspendLayout();
            this.projectSettings.SuspendLayout();
            this.gbxToolsTestEquip.SuspendLayout();
            this.gbxGeneralSettings.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupNo
            // 
            this.GroupNo.HeaderText = "GROUP NO.";
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            // 
            // CompAssy
            // 
            this.CompAssy.HeaderText = "COMPONENT/ASSEMBLY";
            this.CompAssy.Name = "CompAssy";
            this.CompAssy.ReadOnly = true;
            // 
            // MaintFunct
            // 
            this.MaintFunct.HeaderText = "MAINTENANCE FUNCTION";
            this.MaintFunct.Name = "MaintFunct";
            this.MaintFunct.ReadOnly = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.projectSettings);
            this.MainTabControl.Controls.Add(this.tableEditor);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Location = new System.Drawing.Point(12, 28);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1199, 550);
            this.MainTabControl.TabIndex = 0;
            // 
            // projectSettings
            // 
            this.projectSettings.BackColor = System.Drawing.Color.DarkGray;
            this.projectSettings.Controls.Add(this.gbxRemarks);
            this.projectSettings.Controls.Add(this.gbxToolsTestEquip);
            this.projectSettings.Controls.Add(this.gbxGeneralSettings);
            this.projectSettings.Location = new System.Drawing.Point(4, 22);
            this.projectSettings.Name = "projectSettings";
            this.projectSettings.Padding = new System.Windows.Forms.Padding(3);
            this.projectSettings.Size = new System.Drawing.Size(1191, 524);
            this.projectSettings.TabIndex = 0;
            this.projectSettings.Text = "Project Settings";
            // 
            // gbxRemarks
            // 
            this.gbxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRemarks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxRemarks.Location = new System.Drawing.Point(599, 77);
            this.gbxRemarks.Name = "gbxRemarks";
            this.gbxRemarks.Size = new System.Drawing.Size(577, 428);
            this.gbxRemarks.TabIndex = 4;
            this.gbxRemarks.TabStop = false;
            this.gbxRemarks.Text = "Remarks:";
            // 
            // gbxToolsTestEquip
            // 
            this.gbxToolsTestEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxToolsTestEquip.Controls.Add(this.listBox1);
            this.gbxToolsTestEquip.Controls.Add(this.button6);
            this.gbxToolsTestEquip.Controls.Add(this.button5);
            this.gbxToolsTestEquip.Controls.Add(this.button4);
            this.gbxToolsTestEquip.Controls.Add(this.button3);
            this.gbxToolsTestEquip.Controls.Add(this.button2);
            this.gbxToolsTestEquip.Controls.Add(this.button1);
            this.gbxToolsTestEquip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxToolsTestEquip.Location = new System.Drawing.Point(15, 77);
            this.gbxToolsTestEquip.Name = "gbxToolsTestEquip";
            this.gbxToolsTestEquip.Size = new System.Drawing.Size(578, 428);
            this.gbxToolsTestEquip.TabIndex = 3;
            this.gbxToolsTestEquip.TabStop = false;
            this.gbxToolsTestEquip.Text = "Tools and Test Equipment:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(6, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "+  Add Tool / Test Equipment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbxGeneralSettings
            // 
            this.gbxGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGeneralSettings.BackColor = System.Drawing.Color.DarkGray;
            this.gbxGeneralSettings.Controls.Add(this.label1);
            this.gbxGeneralSettings.Controls.Add(this.textBox2);
            this.gbxGeneralSettings.Controls.Add(this.lblTMnumber);
            this.gbxGeneralSettings.Controls.Add(this.textBox1);
            this.gbxGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxGeneralSettings.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxGeneralSettings.Location = new System.Drawing.Point(15, 10);
            this.gbxGeneralSettings.Name = "gbxGeneralSettings";
            this.gbxGeneralSettings.Size = new System.Drawing.Size(1161, 61);
            this.gbxGeneralSettings.TabIndex = 2;
            this.gbxGeneralSettings.TabStop = false;
            this.gbxGeneralSettings.Text = "General Settings:";
            // 
            // lblTMnumber
            // 
            this.lblTMnumber.AutoSize = true;
            this.lblTMnumber.Location = new System.Drawing.Point(18, 26);
            this.lblTMnumber.Name = "lblTMnumber";
            this.lblTMnumber.Size = new System.Drawing.Size(66, 13);
            this.lblTMnumber.TabIndex = 0;
            this.lblTMnumber.Text = "TM Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tableEditor
            // 
            this.tableEditor.Location = new System.Drawing.Point(4, 22);
            this.tableEditor.Name = "tableEditor";
            this.tableEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tableEditor.Size = new System.Drawing.Size(1191, 524);
            this.tableEditor.TabIndex = 1;
            this.tableEditor.Text = "MAC Table Editor";
            this.tableEditor.UseVisualStyleBackColor = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton,
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1223, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "Menu";
            // 
            // fileToolStripDropDownButton
            // 
            this.fileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveFileToolStripMenuItem,
            this.saveAsFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripDropDownButton.Image")));
            this.fileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripDropDownButton.Name = "fileToolStripDropDownButton";
            this.fileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.fileToolStripDropDownButton.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "&New";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "&Save";
            // 
            // saveAsFileToolStripMenuItem
            // 
            this.saveAsFileToolStripMenuItem.Name = "saveAsFileToolStripMenuItem";
            this.saveAsFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsFileToolStripMenuItem.Text = "Save &As...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "&Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.howToToolStripMenuItem.Text = "How To &Use This Tool...";
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.reportBugToolStripMenuItem.Text = "&Report Bug";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem1.Text = "About...";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "Save + Quit";
            // 
            // lblVersionNum
            // 
            this.lblVersionNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersionNum.AutoSize = true;
            this.lblVersionNum.Location = new System.Drawing.Point(1138, 583);
            this.lblVersionNum.Name = "lblVersionNum";
            this.lblVersionNum.Size = new System.Drawing.Size(69, 13);
            this.lblVersionNum.TabIndex = 2;
            this.lblVersionNum.Text = "Version: 0.1a";
            this.lblVersionNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(6, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Selected Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(386, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear List";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(196, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete Selected Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TM Name/Title:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(391, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(754, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(518, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Down";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button6.Location = new System.Drawing.Point(458, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "Up";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1191, 524);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Preview / Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(565, 329);
            this.listBox1.TabIndex = 8;
            // 
            // frmMacDevMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 605);
            this.Controls.Add(this.lblVersionNum);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "frmMacDevMain";
            this.Text = "TRG Maintenance Allocation Chart Development Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabControl.ResumeLayout(false);
            this.projectSettings.ResumeLayout(false);
            this.gbxToolsTestEquip.ResumeLayout(false);
            this.gbxGeneralSettings.ResumeLayout(false);
            this.gbxGeneralSettings.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompAssy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintFunct;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage projectSettings;
        private System.Windows.Forms.TabPage tableEditor;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblVersionNum;
        private System.Windows.Forms.GroupBox gbxGeneralSettings;
        private System.Windows.Forms.Label lblTMnumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxToolsTestEquip;
        private System.Windows.Forms.GroupBox gbxRemarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

