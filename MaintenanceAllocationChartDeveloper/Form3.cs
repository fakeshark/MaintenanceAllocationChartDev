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
    public partial class Form3 : Form
    {
        private string nomenclatureValue;

        public string NomenclatureValue
        {
            get
            {
                return nomenclatureValue;
            }
            set
            {
                nomenclatureValue = value;
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddTool_Click(object sender, EventArgs e)
        {
            if (ValidateThisForm() == true)
            {
                this.Close();
            }
        }

        private bool ValidateThisForm()
        {
            string errorMessage = "";

            if (txtNSNnumber.Text.Trim() == "" || txtNSNnumber.Text.Trim() == null)
            {
                errorMessage += "NSN field must contain a value.\n";
            }

            if (txtToolNumber.Text.Trim() == "" || txtToolNumber.Text.Trim() == null)
            {
                errorMessage += "Tool number field must contain a value.\n";
            }

            if (rtbNomenclature.Text.Trim() == "" || rtbNomenclature.Text.Trim() == null)
            {
                errorMessage += "Nomenclature field must contain a value.\n";
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Missing Required Information.");
                return false;
            }
            else
            {
                NomenclatureValue = rtbNomenclature.Text.Trim();
                return true;
            }
        }
    }
}
