namespace MaintenanceAllocationChartDeveloper
{
    partial class Form2
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
            this.btnNewProjectCancel = new System.Windows.Forms.Button();
            this.btnNewProjectCreate = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtNewProjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewProjectCancel
            // 
            this.btnNewProjectCancel.Location = new System.Drawing.Point(243, 54);
            this.btnNewProjectCancel.Name = "btnNewProjectCancel";
            this.btnNewProjectCancel.Size = new System.Drawing.Size(106, 29);
            this.btnNewProjectCancel.TabIndex = 1;
            this.btnNewProjectCancel.Text = "Cancel";
            this.btnNewProjectCancel.UseVisualStyleBackColor = true;
            this.btnNewProjectCancel.Click += new System.EventHandler(this.BtnNewProjectCancel_Click);
            // 
            // btnNewProjectCreate
            // 
            this.btnNewProjectCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewProjectCreate.Location = new System.Drawing.Point(355, 54);
            this.btnNewProjectCreate.Name = "btnNewProjectCreate";
            this.btnNewProjectCreate.Size = new System.Drawing.Size(106, 29);
            this.btnNewProjectCreate.TabIndex = 2;
            this.btnNewProjectCreate.Text = "Create New";
            this.btnNewProjectCreate.UseVisualStyleBackColor = true;
            this.btnNewProjectCreate.Click += new System.EventHandler(this.BtnNewProjectCreate_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(19, 31);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 13);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "Project Name:";
            // 
            // txtNewProjectName
            // 
            this.txtNewProjectName.Location = new System.Drawing.Point(102, 28);
            this.txtNewProjectName.Name = "txtNewProjectName";
            this.txtNewProjectName.Size = new System.Drawing.Size(359, 20);
            this.txtNewProjectName.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 109);
            this.Controls.Add(this.txtNewProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnNewProjectCreate);
            this.Controls.Add(this.btnNewProjectCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProjectCancel;
        private System.Windows.Forms.Button btnNewProjectCreate;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtNewProjectName;
    }
}