namespace MaintenanceAllocationChartDeveloper
{
    partial class Form3
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
            this.rbtnCrewLvlMaint = new System.Windows.Forms.RadioButton();
            this.rbtnMaintLvlMaint = new System.Windows.Forms.RadioButton();
            this.gbxMaintLvl = new System.Windows.Forms.GroupBox();
            this.rbtnDepotMaintLvl = new System.Windows.Forms.RadioButton();
            this.rbtnSRAMaintLvl = new System.Windows.Forms.RadioButton();
            this.rbtnBelowDepotMaintLvl = new System.Windows.Forms.RadioButton();
            this.gbxNSN = new System.Windows.Forms.GroupBox();
            this.lblNSN = new System.Windows.Forms.Label();
            this.txtNSNnumber = new System.Windows.Forms.TextBox();
            this.gbxToolNum = new System.Windows.Forms.GroupBox();
            this.lblToolNum = new System.Windows.Forms.Label();
            this.txtToolNumber = new System.Windows.Forms.TextBox();
            this.gbxNomenclature = new System.Windows.Forms.GroupBox();
            this.rtbNomenclature = new System.Windows.Forms.RichTextBox();
            this.btnAddTool = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxMaintLvl.SuspendLayout();
            this.gbxNSN.SuspendLayout();
            this.gbxToolNum.SuspendLayout();
            this.gbxNomenclature.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnCrewLvlMaint
            // 
            this.rbtnCrewLvlMaint.AutoSize = true;
            this.rbtnCrewLvlMaint.Checked = true;
            this.rbtnCrewLvlMaint.Location = new System.Drawing.Point(25, 19);
            this.rbtnCrewLvlMaint.Name = "rbtnCrewLvlMaint";
            this.rbtnCrewLvlMaint.Size = new System.Drawing.Size(114, 17);
            this.rbtnCrewLvlMaint.TabIndex = 1;
            this.rbtnCrewLvlMaint.TabStop = true;
            this.rbtnCrewLvlMaint.Text = "Crew Maintenance";
            this.rbtnCrewLvlMaint.UseVisualStyleBackColor = true;
            // 
            // rbtnMaintLvlMaint
            // 
            this.rbtnMaintLvlMaint.AutoSize = true;
            this.rbtnMaintLvlMaint.Location = new System.Drawing.Point(25, 44);
            this.rbtnMaintLvlMaint.Name = "rbtnMaintLvlMaint";
            this.rbtnMaintLvlMaint.Size = new System.Drawing.Size(139, 17);
            this.rbtnMaintLvlMaint.TabIndex = 2;
            this.rbtnMaintLvlMaint.Text = "Maintainer Maintenance";
            this.rbtnMaintLvlMaint.UseVisualStyleBackColor = true;
            // 
            // gbxMaintLvl
            // 
            this.gbxMaintLvl.Controls.Add(this.rbtnDepotMaintLvl);
            this.gbxMaintLvl.Controls.Add(this.rbtnSRAMaintLvl);
            this.gbxMaintLvl.Controls.Add(this.rbtnBelowDepotMaintLvl);
            this.gbxMaintLvl.Controls.Add(this.rbtnMaintLvlMaint);
            this.gbxMaintLvl.Controls.Add(this.rbtnCrewLvlMaint);
            this.gbxMaintLvl.Location = new System.Drawing.Point(12, 12);
            this.gbxMaintLvl.Name = "gbxMaintLvl";
            this.gbxMaintLvl.Size = new System.Drawing.Size(228, 150);
            this.gbxMaintLvl.TabIndex = 3;
            this.gbxMaintLvl.TabStop = false;
            this.gbxMaintLvl.Text = "Maintenance Level: ";
            // 
            // rbtnDepotMaintLvl
            // 
            this.rbtnDepotMaintLvl.AutoSize = true;
            this.rbtnDepotMaintLvl.Location = new System.Drawing.Point(25, 94);
            this.rbtnDepotMaintLvl.Name = "rbtnDepotMaintLvl";
            this.rbtnDepotMaintLvl.Size = new System.Drawing.Size(119, 17);
            this.rbtnDepotMaintLvl.TabIndex = 5;
            this.rbtnDepotMaintLvl.Text = "Depot Maintenance";
            this.rbtnDepotMaintLvl.UseVisualStyleBackColor = true;
            // 
            // rbtnSRAMaintLvl
            // 
            this.rbtnSRAMaintLvl.AutoSize = true;
            this.rbtnSRAMaintLvl.Location = new System.Drawing.Point(25, 119);
            this.rbtnSRAMaintLvl.Name = "rbtnSRAMaintLvl";
            this.rbtnSRAMaintLvl.Size = new System.Drawing.Size(181, 17);
            this.rbtnSRAMaintLvl.TabIndex = 3;
            this.rbtnSRAMaintLvl.Text = "Specialized Repair Activity (SRA)";
            this.rbtnSRAMaintLvl.UseVisualStyleBackColor = true;
            // 
            // rbtnBelowDepotMaintLvl
            // 
            this.rbtnBelowDepotMaintLvl.AutoSize = true;
            this.rbtnBelowDepotMaintLvl.Location = new System.Drawing.Point(25, 69);
            this.rbtnBelowDepotMaintLvl.Name = "rbtnBelowDepotMaintLvl";
            this.rbtnBelowDepotMaintLvl.Size = new System.Drawing.Size(151, 17);
            this.rbtnBelowDepotMaintLvl.TabIndex = 4;
            this.rbtnBelowDepotMaintLvl.Text = "Below Depot Maintenance";
            this.rbtnBelowDepotMaintLvl.UseVisualStyleBackColor = true;
            // 
            // gbxNSN
            // 
            this.gbxNSN.Controls.Add(this.lblNSN);
            this.gbxNSN.Controls.Add(this.txtNSNnumber);
            this.gbxNSN.Location = new System.Drawing.Point(247, 12);
            this.gbxNSN.Name = "gbxNSN";
            this.gbxNSN.Size = new System.Drawing.Size(469, 72);
            this.gbxNSN.TabIndex = 4;
            this.gbxNSN.TabStop = false;
            this.gbxNSN.Text = "National Stock Number (NSN): ";
            // 
            // lblNSN
            // 
            this.lblNSN.AutoSize = true;
            this.lblNSN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNSN.Location = new System.Drawing.Point(24, 31);
            this.lblNSN.Name = "lblNSN";
            this.lblNSN.Size = new System.Drawing.Size(112, 13);
            this.lblNSN.TabIndex = 1;
            this.lblNSN.Text = "Ex: 6625-01-336-3372";
            // 
            // txtNSNnumber
            // 
            this.txtNSNnumber.Location = new System.Drawing.Point(142, 28);
            this.txtNSNnumber.Name = "txtNSNnumber";
            this.txtNSNnumber.Size = new System.Drawing.Size(300, 20);
            this.txtNSNnumber.TabIndex = 0;
            // 
            // gbxToolNum
            // 
            this.gbxToolNum.Controls.Add(this.lblToolNum);
            this.gbxToolNum.Controls.Add(this.txtToolNumber);
            this.gbxToolNum.Location = new System.Drawing.Point(247, 90);
            this.gbxToolNum.Name = "gbxToolNum";
            this.gbxToolNum.Size = new System.Drawing.Size(469, 72);
            this.gbxToolNum.TabIndex = 5;
            this.gbxToolNum.TabStop = false;
            this.gbxToolNum.Text = "Tool Number: ";
            // 
            // lblToolNum
            // 
            this.lblToolNum.AutoSize = true;
            this.lblToolNum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblToolNum.Location = new System.Drawing.Point(24, 31);
            this.lblToolNum.Name = "lblToolNum";
            this.lblToolNum.Size = new System.Drawing.Size(61, 13);
            this.lblToolNum.TabIndex = 1;
            this.lblToolNum.Text = "Ex: 77-4BN";
            // 
            // txtToolNumber
            // 
            this.txtToolNumber.Location = new System.Drawing.Point(142, 28);
            this.txtToolNumber.Name = "txtToolNumber";
            this.txtToolNumber.Size = new System.Drawing.Size(300, 20);
            this.txtToolNumber.TabIndex = 0;
            // 
            // gbxNomenclature
            // 
            this.gbxNomenclature.Controls.Add(this.rtbNomenclature);
            this.gbxNomenclature.Location = new System.Drawing.Point(12, 168);
            this.gbxNomenclature.Name = "gbxNomenclature";
            this.gbxNomenclature.Size = new System.Drawing.Size(704, 157);
            this.gbxNomenclature.TabIndex = 6;
            this.gbxNomenclature.TabStop = false;
            this.gbxNomenclature.Text = "Nomenclature: ";
            // 
            // rtbNomenclature
            // 
            this.rtbNomenclature.Location = new System.Drawing.Point(15, 22);
            this.rtbNomenclature.Name = "rtbNomenclature";
            this.rtbNomenclature.Size = new System.Drawing.Size(673, 118);
            this.rtbNomenclature.TabIndex = 0;
            this.rtbNomenclature.Text = "";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Location = new System.Drawing.Point(535, 335);
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(181, 23);
            this.btnAddTool.TabIndex = 7;
            this.btnAddTool.Text = "Add Tool/Test Equipment";
            this.btnAddTool.UseVisualStyleBackColor = true;
            this.btnAddTool.Click += new System.EventHandler(this.BtnAddTool_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 370);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTool);
            this.Controls.Add(this.gbxNomenclature);
            this.Controls.Add(this.gbxToolNum);
            this.Controls.Add(this.gbxNSN);
            this.Controls.Add(this.gbxMaintLvl);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Tool/Test Equipment";
            this.gbxMaintLvl.ResumeLayout(false);
            this.gbxMaintLvl.PerformLayout();
            this.gbxNSN.ResumeLayout(false);
            this.gbxNSN.PerformLayout();
            this.gbxToolNum.ResumeLayout(false);
            this.gbxToolNum.PerformLayout();
            this.gbxNomenclature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnCrewLvlMaint;
        private System.Windows.Forms.RadioButton rbtnMaintLvlMaint;
        private System.Windows.Forms.GroupBox gbxMaintLvl;
        private System.Windows.Forms.RadioButton rbtnDepotMaintLvl;
        private System.Windows.Forms.RadioButton rbtnBelowDepotMaintLvl;
        private System.Windows.Forms.RadioButton rbtnSRAMaintLvl;
        private System.Windows.Forms.GroupBox gbxNSN;
        private System.Windows.Forms.Label lblNSN;
        private System.Windows.Forms.TextBox txtNSNnumber;
        private System.Windows.Forms.GroupBox gbxToolNum;
        private System.Windows.Forms.Label lblToolNum;
        private System.Windows.Forms.TextBox txtToolNumber;
        private System.Windows.Forms.GroupBox gbxNomenclature;
        private System.Windows.Forms.RichTextBox rtbNomenclature;
        private System.Windows.Forms.Button btnAddTool;
        private System.Windows.Forms.Button btnCancel;
    }
}