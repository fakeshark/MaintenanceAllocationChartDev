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
        private string nsnValue;
        private string toolNumberValue;
        private string maintLevelValue;

        #region Getters & Setters

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

        public string NSNvalue
        {
            get
            {
                return nsnValue;
            }
            set
            {
                nsnValue = value;
            }
        }

        public string ToolNumberValue
        {
            get
            {
                return toolNumberValue;
            }
            set
            {
                toolNumberValue = value;
            }
        }

        public string MaintLevelValue
        {
            get
            {
                return maintLevelValue;
            }
            set
            {
                maintLevelValue = value;
            }
        }

        #endregion

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
            if (ValidateThisForm())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidateThisForm()
        {
            string errorMessage = "";
            string maintLvl = "";

            if (rbtnCrewLvlMaint.Checked)
            {
                maintLvl = "CREW";
            }

            if (rbtnMaintLvlMaint.Checked)
            {
                maintLvl = "MAINTAINER";
            }

            if (rbtnBelowDepotMaintLvl.Checked)
            {
                maintLvl = "BELOW DEPOT";
            }

            if (rbtnDepotMaintLvl.Checked)
            {
                maintLvl = "DEPOT";
            }

            if (rbtnSRAMaintLvl.Checked)
            {
                maintLvl = "SRA";
            }


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
                NomenclatureValue = rtbNomenclature.Text.Trim().ToUpper();
                NSNvalue = txtNSNnumber.Text.Trim().ToUpper();
                ToolNumberValue = txtToolNumber.Text.Trim().ToUpper();
                MaintLevelValue = maintLvl;
                return true;
            }
        }
    }
}
