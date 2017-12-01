using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceAllocationChartDeveloper
{
    public partial class Form2 : Form
    {
        private string projectName;

        public string ProjectName
        {
            get
            {
                return projectName;
            }
            set
            {
                projectName = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void BtnNewProjectCreate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to create a new project, any unsaved changes to the current project will be lost.\n\nAre you sure you want to continue?", "Create New?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                // Create new project
                ProjectName = txtNewProjectName.Text.Trim();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                // Resume application.
            }
        }

        private void BtnNewProjectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
