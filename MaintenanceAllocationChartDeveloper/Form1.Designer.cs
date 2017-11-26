﻿namespace MaintenanceAllocationChartDeveloper
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
            this.lbxRemarksList = new System.Windows.Forms.ListBox();
            this.btnAddRemark = new System.Windows.Forms.Button();
            this.btnMoveRemarkUp = new System.Windows.Forms.Button();
            this.btnEditRemark = new System.Windows.Forms.Button();
            this.btnMoveRemarkDown = new System.Windows.Forms.Button();
            this.btnClearRemarkList = new System.Windows.Forms.Button();
            this.btnDeleteRemark = new System.Windows.Forms.Button();
            this.gbxToolsTestEquip = new System.Windows.Forms.GroupBox();
            this.lbxToolTestEquipList = new System.Windows.Forms.ListBox();
            this.btnMoveToolUp = new System.Windows.Forms.Button();
            this.btnMoveToolDown = new System.Windows.Forms.Button();
            this.btnDeleteTool = new System.Windows.Forms.Button();
            this.btnClearToolList = new System.Windows.Forms.Button();
            this.btnEditTool = new System.Windows.Forms.Button();
            this.btnAddToolTest = new System.Windows.Forms.Button();
            this.gbxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.lblTMname = new System.Windows.Forms.Label();
            this.txtTMname = new System.Windows.Forms.TextBox();
            this.lblTMnumber = new System.Windows.Forms.Label();
            this.txtTMnumber = new System.Windows.Forms.TextBox();
            this.tableEditor = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.saveQuitToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblVersionNum = new System.Windows.Forms.Label();
            this.importTMtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.projectSettings.SuspendLayout();
            this.gbxRemarks.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(1200, 550);
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
            this.projectSettings.Size = new System.Drawing.Size(1192, 524);
            this.projectSettings.TabIndex = 0;
            this.projectSettings.Text = "Project Settings";
            // 
            // gbxRemarks
            // 
            this.gbxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRemarks.Controls.Add(this.lbxRemarksList);
            this.gbxRemarks.Controls.Add(this.btnAddRemark);
            this.gbxRemarks.Controls.Add(this.btnMoveRemarkUp);
            this.gbxRemarks.Controls.Add(this.btnEditRemark);
            this.gbxRemarks.Controls.Add(this.btnMoveRemarkDown);
            this.gbxRemarks.Controls.Add(this.btnClearRemarkList);
            this.gbxRemarks.Controls.Add(this.btnDeleteRemark);
            this.gbxRemarks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxRemarks.Location = new System.Drawing.Point(599, 77);
            this.gbxRemarks.Name = "gbxRemarks";
            this.gbxRemarks.Size = new System.Drawing.Size(578, 428);
            this.gbxRemarks.TabIndex = 4;
            this.gbxRemarks.TabStop = false;
            this.gbxRemarks.Text = "Remarks:";
            // 
            // lbxRemarksList
            // 
            this.lbxRemarksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxRemarksList.FormattingEnabled = true;
            this.lbxRemarksList.Location = new System.Drawing.Point(6, 54);
            this.lbxRemarksList.Name = "lbxRemarksList";
            this.lbxRemarksList.Size = new System.Drawing.Size(565, 329);
            this.lbxRemarksList.TabIndex = 15;
            // 
            // btnAddRemark
            // 
            this.btnAddRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRemark.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddRemark.Location = new System.Drawing.Point(6, 18);
            this.btnAddRemark.Name = "btnAddRemark";
            this.btnAddRemark.Size = new System.Drawing.Size(446, 30);
            this.btnAddRemark.TabIndex = 9;
            this.btnAddRemark.Text = "+  Add Remark";
            this.btnAddRemark.UseVisualStyleBackColor = true;
            // 
            // btnMoveRemarkUp
            // 
            this.btnMoveRemarkUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveRemarkUp.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnMoveRemarkUp.Location = new System.Drawing.Point(458, 18);
            this.btnMoveRemarkUp.Name = "btnMoveRemarkUp";
            this.btnMoveRemarkUp.Size = new System.Drawing.Size(54, 30);
            this.btnMoveRemarkUp.TabIndex = 14;
            this.btnMoveRemarkUp.Text = "Up";
            this.btnMoveRemarkUp.UseVisualStyleBackColor = true;
            // 
            // btnEditRemark
            // 
            this.btnEditRemark.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditRemark.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEditRemark.Location = new System.Drawing.Point(7, 389);
            this.btnEditRemark.Name = "btnEditRemark";
            this.btnEditRemark.Size = new System.Drawing.Size(186, 30);
            this.btnEditRemark.TabIndex = 10;
            this.btnEditRemark.Text = "Edit Selected Item";
            this.btnEditRemark.UseVisualStyleBackColor = true;
            // 
            // btnMoveRemarkDown
            // 
            this.btnMoveRemarkDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveRemarkDown.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnMoveRemarkDown.Location = new System.Drawing.Point(518, 18);
            this.btnMoveRemarkDown.Name = "btnMoveRemarkDown";
            this.btnMoveRemarkDown.Size = new System.Drawing.Size(54, 30);
            this.btnMoveRemarkDown.TabIndex = 13;
            this.btnMoveRemarkDown.Text = "Down";
            this.btnMoveRemarkDown.UseVisualStyleBackColor = true;
            // 
            // btnClearRemarkList
            // 
            this.btnClearRemarkList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearRemarkList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClearRemarkList.Location = new System.Drawing.Point(387, 389);
            this.btnClearRemarkList.Name = "btnClearRemarkList";
            this.btnClearRemarkList.Size = new System.Drawing.Size(186, 30);
            this.btnClearRemarkList.TabIndex = 11;
            this.btnClearRemarkList.Text = "Clear List";
            this.btnClearRemarkList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRemark
            // 
            this.btnDeleteRemark.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteRemark.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteRemark.Location = new System.Drawing.Point(197, 389);
            this.btnDeleteRemark.Name = "btnDeleteRemark";
            this.btnDeleteRemark.Size = new System.Drawing.Size(186, 30);
            this.btnDeleteRemark.TabIndex = 12;
            this.btnDeleteRemark.Text = "Delete Selected Item";
            this.btnDeleteRemark.UseVisualStyleBackColor = true;
            // 
            // gbxToolsTestEquip
            // 
            this.gbxToolsTestEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxToolsTestEquip.Controls.Add(this.lbxToolTestEquipList);
            this.gbxToolsTestEquip.Controls.Add(this.btnMoveToolUp);
            this.gbxToolsTestEquip.Controls.Add(this.btnMoveToolDown);
            this.gbxToolsTestEquip.Controls.Add(this.btnDeleteTool);
            this.gbxToolsTestEquip.Controls.Add(this.btnClearToolList);
            this.gbxToolsTestEquip.Controls.Add(this.btnEditTool);
            this.gbxToolsTestEquip.Controls.Add(this.btnAddToolTest);
            this.gbxToolsTestEquip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxToolsTestEquip.Location = new System.Drawing.Point(15, 77);
            this.gbxToolsTestEquip.Name = "gbxToolsTestEquip";
            this.gbxToolsTestEquip.Size = new System.Drawing.Size(578, 428);
            this.gbxToolsTestEquip.TabIndex = 3;
            this.gbxToolsTestEquip.TabStop = false;
            this.gbxToolsTestEquip.Text = "Tools and Test Equipment:";
            // 
            // lbxToolTestEquipList
            // 
            this.lbxToolTestEquipList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxToolTestEquipList.FormattingEnabled = true;
            this.lbxToolTestEquipList.Location = new System.Drawing.Point(6, 54);
            this.lbxToolTestEquipList.Name = "lbxToolTestEquipList";
            this.lbxToolTestEquipList.Size = new System.Drawing.Size(565, 329);
            this.lbxToolTestEquipList.TabIndex = 8;
            // 
            // btnMoveToolUp
            // 
            this.btnMoveToolUp.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnMoveToolUp.Location = new System.Drawing.Point(458, 18);
            this.btnMoveToolUp.Name = "btnMoveToolUp";
            this.btnMoveToolUp.Size = new System.Drawing.Size(54, 30);
            this.btnMoveToolUp.TabIndex = 7;
            this.btnMoveToolUp.Text = "Up";
            this.btnMoveToolUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveToolDown
            // 
            this.btnMoveToolDown.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnMoveToolDown.Location = new System.Drawing.Point(518, 18);
            this.btnMoveToolDown.Name = "btnMoveToolDown";
            this.btnMoveToolDown.Size = new System.Drawing.Size(54, 30);
            this.btnMoveToolDown.TabIndex = 6;
            this.btnMoveToolDown.Text = "Down";
            this.btnMoveToolDown.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteTool.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteTool.Location = new System.Drawing.Point(196, 389);
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(186, 30);
            this.btnDeleteTool.TabIndex = 4;
            this.btnDeleteTool.Text = "Delete Selected Item";
            this.btnDeleteTool.UseVisualStyleBackColor = true;
            // 
            // btnClearToolList
            // 
            this.btnClearToolList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearToolList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClearToolList.Location = new System.Drawing.Point(386, 389);
            this.btnClearToolList.Name = "btnClearToolList";
            this.btnClearToolList.Size = new System.Drawing.Size(186, 30);
            this.btnClearToolList.TabIndex = 3;
            this.btnClearToolList.Text = "Clear List";
            this.btnClearToolList.UseVisualStyleBackColor = true;
            // 
            // btnEditTool
            // 
            this.btnEditTool.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditTool.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEditTool.Location = new System.Drawing.Point(6, 389);
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(186, 30);
            this.btnEditTool.TabIndex = 2;
            this.btnEditTool.Text = "Edit Selected Item";
            this.btnEditTool.UseVisualStyleBackColor = true;
            // 
            // btnAddToolTest
            // 
            this.btnAddToolTest.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddToolTest.Location = new System.Drawing.Point(6, 18);
            this.btnAddToolTest.Name = "btnAddToolTest";
            this.btnAddToolTest.Size = new System.Drawing.Size(446, 30);
            this.btnAddToolTest.TabIndex = 1;
            this.btnAddToolTest.Text = "+  Add Tool / Test Equipment";
            this.btnAddToolTest.UseVisualStyleBackColor = true;
            // 
            // gbxGeneralSettings
            // 
            this.gbxGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGeneralSettings.BackColor = System.Drawing.Color.DarkGray;
            this.gbxGeneralSettings.Controls.Add(this.lblTMname);
            this.gbxGeneralSettings.Controls.Add(this.txtTMname);
            this.gbxGeneralSettings.Controls.Add(this.lblTMnumber);
            this.gbxGeneralSettings.Controls.Add(this.txtTMnumber);
            this.gbxGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxGeneralSettings.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxGeneralSettings.Location = new System.Drawing.Point(15, 10);
            this.gbxGeneralSettings.Name = "gbxGeneralSettings";
            this.gbxGeneralSettings.Size = new System.Drawing.Size(1162, 61);
            this.gbxGeneralSettings.TabIndex = 2;
            this.gbxGeneralSettings.TabStop = false;
            this.gbxGeneralSettings.Text = "General Settings:";
            // 
            // lblTMname
            // 
            this.lblTMname.AutoSize = true;
            this.lblTMname.Location = new System.Drawing.Point(303, 26);
            this.lblTMname.Name = "lblTMname";
            this.lblTMname.Size = new System.Drawing.Size(82, 13);
            this.lblTMname.TabIndex = 2;
            this.lblTMname.Text = "TM Name/Title:";
            // 
            // txtTMname
            // 
            this.txtTMname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTMname.Location = new System.Drawing.Point(391, 23);
            this.txtTMname.Name = "txtTMname";
            this.txtTMname.Size = new System.Drawing.Size(755, 20);
            this.txtTMname.TabIndex = 3;
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
            // txtTMnumber
            // 
            this.txtTMnumber.Location = new System.Drawing.Point(90, 23);
            this.txtTMnumber.Name = "txtTMnumber";
            this.txtTMnumber.Size = new System.Drawing.Size(207, 20);
            this.txtTMnumber.TabIndex = 1;
            // 
            // tableEditor
            // 
            this.tableEditor.Location = new System.Drawing.Point(4, 22);
            this.tableEditor.Name = "tableEditor";
            this.tableEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tableEditor.Size = new System.Drawing.Size(1192, 524);
            this.tableEditor.TabIndex = 1;
            this.tableEditor.Text = "MAC Table Editor";
            this.tableEditor.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1192, 524);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Preview / Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton,
            this.toolStripDropDownButton1,
            this.saveQuitToolStripButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1224, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "Menu";
            // 
            // fileToolStripDropDownButton
            // 
            this.fileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.importTMtoolStripMenuItem,
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
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newFileToolStripMenuItem.Text = "&New";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openFileToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveFileToolStripMenuItem.Text = "&Save";
            // 
            // saveAsFileToolStripMenuItem
            // 
            this.saveAsFileToolStripMenuItem.Name = "saveAsFileToolStripMenuItem";
            this.saveAsFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveAsFileToolStripMenuItem.Text = "Save &As...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            // saveQuitToolStripButton1
            // 
            this.saveQuitToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveQuitToolStripButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.saveQuitToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveQuitToolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveQuitToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveQuitToolStripButton1.Image")));
            this.saveQuitToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveQuitToolStripButton1.Name = "saveQuitToolStripButton1";
            this.saveQuitToolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.saveQuitToolStripButton1.Text = "Save + Quit";
            // 
            // lblVersionNum
            // 
            this.lblVersionNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersionNum.AutoSize = true;
            this.lblVersionNum.Location = new System.Drawing.Point(1139, 583);
            this.lblVersionNum.Name = "lblVersionNum";
            this.lblVersionNum.Size = new System.Drawing.Size(69, 13);
            this.lblVersionNum.TabIndex = 2;
            this.lblVersionNum.Text = "Version: 0.1a";
            this.lblVersionNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // importTMtoolStripMenuItem
            // 
            this.importTMtoolStripMenuItem.Name = "importTMtoolStripMenuItem";
            this.importTMtoolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.importTMtoolStripMenuItem.Text = "Import XML TM File";
            // 
            // frmMacDevMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 605);
            this.Controls.Add(this.lblVersionNum);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(1240, 600);
            this.Name = "frmMacDevMain";
            this.Text = "TRG Maintenance Allocation Chart Development Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabControl.ResumeLayout(false);
            this.projectSettings.ResumeLayout(false);
            this.gbxRemarks.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton saveQuitToolStripButton1;
        private System.Windows.Forms.Label lblVersionNum;
        private System.Windows.Forms.GroupBox gbxGeneralSettings;
        private System.Windows.Forms.Label lblTMnumber;
        private System.Windows.Forms.TextBox txtTMnumber;
        private System.Windows.Forms.GroupBox gbxToolsTestEquip;
        private System.Windows.Forms.GroupBox gbxRemarks;
        private System.Windows.Forms.Button btnAddToolTest;
        private System.Windows.Forms.Button btnDeleteTool;
        private System.Windows.Forms.Button btnClearToolList;
        private System.Windows.Forms.Button btnEditTool;
        private System.Windows.Forms.Label lblTMname;
        private System.Windows.Forms.TextBox txtTMname;
        private System.Windows.Forms.ListBox lbxToolTestEquipList;
        private System.Windows.Forms.Button btnMoveToolUp;
        private System.Windows.Forms.Button btnMoveToolDown;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbxRemarksList;
        private System.Windows.Forms.Button btnAddRemark;
        private System.Windows.Forms.Button btnMoveRemarkUp;
        private System.Windows.Forms.Button btnEditRemark;
        private System.Windows.Forms.Button btnMoveRemarkDown;
        private System.Windows.Forms.Button btnClearRemarkList;
        private System.Windows.Forms.Button btnDeleteRemark;
        private System.Windows.Forms.ToolStripMenuItem importTMtoolStripMenuItem;
    }
}

