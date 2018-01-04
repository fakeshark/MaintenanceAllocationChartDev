using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string passedMaintLvl;
        private string passedNSN;
        private string passedToolNum;
        private string passedNomen;

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

        //constructor for editing existing list item
        public Form3(string maintLvl, string nsn, string toolNum, string nomen, int rowIndex)
        {
            InitializeComponent();

            this.passedNSN = maintLvl;
            this.passedNSN = nsn;
            this.passedToolNum = toolNum;
            this.passedNomen = nomen;

            this.Text = "Edit Tool / Test Equipment";
            if (maintLvl == "CREW")
            {
                rbtnCrewLvlMaint.Checked = true;
            }
            else if (maintLvl == "MAINTAINER")
            {
                rbtnMaintLvlMaint.Checked = true;
            }
            else if (maintLvl == "BELOW DEPOT")
            {
                rbtnBelowDepotMaintLvl.Checked = true;
            }
            else if (maintLvl == "DEPOT")
            {
                rbtnDepotMaintLvl.Checked = true;
            }
            else if (maintLvl == "SRA")
            {
                rbtnSRAMaintLvl.Checked = true;
            }

            txtNSNnumber.Text = nsn;
            txtToolNumber.Text = toolNum;
            rtbNomenclature.Text = nomen;
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
            //todo: Add validation for NSN length
            string errorMessage = string.Empty;
            string maintLvl = string.Empty;
            NSNvalue = string.Empty;
            string regexNsnPatternWithDashes = @"(\d{4}-?\d{2}-?\d{3}-?\d{4})"; //  1234-12-123-1234 (with dashes)
            string regexNsnPatternNoDashes = @"(\d{13})"; //  1234121231234 (without dashes)

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
            else
            {
                Match dashesMatch = Regex.Match(txtNSNnumber.Text.Trim(), regexNsnPatternWithDashes);
                Match noDashesMatch = Regex.Match(txtNSNnumber.Text.Trim(), regexNsnPatternNoDashes);
                if (!dashesMatch.Success && !noDashesMatch.Success)
                {
                    errorMessage += "NSN is improperly formatted.\n";
                }
                else if (noDashesMatch.Success)
                {
                    // Add dashes if none exist
                    //todo: refactor this method to use regex for inserting dashes

                    char[] NSNCharArr = txtNSNnumber.Text.Trim().ToUpper().ToCharArray();

                    for (int i = 0; i < NSNCharArr.Length; i++)
                    {
                        string dash = "";
                        if (i == 3 || i == 5 || i == 8)
                        {
                            dash = "-";
                        }
                        else
                        {
                            dash = "";
                        }
                        NSNvalue += NSNCharArr[i] + dash;
                    }
                }
                else
                {
                    NSNvalue = txtNSNnumber.Text.Trim();
                }
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
                MessageBox.Show(errorMessage, "Missing/Invalid Data");
                return false;
            }
            else
            {
                NomenclatureValue = rtbNomenclature.Text.Trim().ToUpper();
                ToolNumberValue = txtToolNumber.Text.Trim().ToUpper();
                MaintLevelValue = maintLvl;
                return true;
            }
        }
    }
}
