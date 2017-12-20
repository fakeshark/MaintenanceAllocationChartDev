using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace MaintenanceAllocationChartDeveloper
{
    public partial class FrmMacDevMain : Form
    {
        OpenFileDialog fileSelected;
        ArrayList toolTestEquipList = new ArrayList();
        string[] addItem;

        public FrmMacDevMain()
        {
            InitializeComponent();
            this.dgvToolTestEquipment.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            this.dgvToolTestEquipment.AlternatingRowsDefaultCellStyle.BackColor =  Color.Silver;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to close this application, any unsaved work will be lost.\n\nAre you sure you want to quit?", "Close Application?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                // Resume application.
            }
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear all lists and variables, prompt user to name new project
            //ClearAllForNewProject();

            // Create a new instance of the Form2 class
            Form2 createNewProjectForm = new Form2();

            if (createNewProjectForm.ShowDialog() == DialogResult.OK)
            {
                lblProjectName.Text = createNewProjectForm.ProjectName;
                lblProjectName.Left = (this.ClientSize.Width - lblProjectName.Size.Width) / 2;
            }

        }

        private void ClearAllForNewProject()
        {

        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open save file to load existing project

            fileSelected = new OpenFileDialog();
            fileSelected.Filter = "All Files (*.*)|*.*|MAC Developer Project Files (*.macx)|*.macx";
            fileSelected.Multiselect = false;

            if (fileSelected.ShowDialog() == DialogResult.OK)
            {
                // read in data from save file
            }
        }

        private void ImportTMtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Import, validate, and parse XML document to retrieve MAC Intro and MAC Wps
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save project into csv or similar text based format
            //If project hasn't been saved previously or loaded from a file, use saveAs method
        }

        private void SaveAsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Same as save, but with save-file browsing and renaming options
        }

        private void HowToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Popup form with video or other instructions on how to use the software
        }

        private void ReportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Build bug reporting mechanism
        }

        private void SaveQuitToolStripButton_Click(object sender, EventArgs e)
        {
            // Save with quit 
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Popup with info about the company, developer
        }

        private void BtnAddToolTest_Click(object sender, EventArgs e)
        {
            Form3 addNewToolTest = new Form3();
            string nomen;
            string nsn;
            string toolNum;
            string maintLvl;

            if (addNewToolTest.ShowDialog() == DialogResult.OK)
            {
                //add values to array list and display in 'lbxToolTestEquipList'
                nomen = addNewToolTest.NomenclatureValue;
                nsn = addNewToolTest.NSNvalue;
                toolNum = addNewToolTest.ToolNumberValue;
                maintLvl = addNewToolTest.MaintLevelValue;

                addItem = new string[] { maintLvl, nsn, toolNum, nomen };
                dgvToolTestEquipment.Rows.Add(addItem[0], addItem[1], addItem[2], addItem[3]);
            }
        }

        private void UpdateLists()
        {

        }

        private void BtnMoveToolUp_Click(object sender, EventArgs e)
        {

        }

        private void BtnMoveToolDown_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearToolList_Click(object sender, EventArgs e)
        {
            if (dgvToolTestEquipment.Rows.Count == 1)
            {
                MessageBox.Show("Data table empty. No list data to clear.", "Clear List Failed");
            }
            else
            {
                DialogResult clearListResult = MessageBox.Show("Are you sure you want to clear the entire tool/test equipment list?", "Clear List?", MessageBoxButtons.OKCancel);
                if (clearListResult == DialogResult.OK)
                {
                    dgvToolTestEquipment.Rows.Clear();
                }
            }
        }

        private void BtnDeleteTool_Click(object sender, EventArgs e)
        {
            if (dgvToolTestEquipment.Rows.Count == 1)
            {
                MessageBox.Show("Data table empty. No rows to delete.", "Delete Row Failed");
            }
            else
            {
                //todo: make delete row functionality
            }
        }

        private void BtnEditTool_Click(object sender, EventArgs e)
        {
            //todo: get data from selected list item and pass it into Form3 for editing

            Form3 addNewToolTest = new Form3("Crew", "test NSN", "test Tool Number", "test Nomenclaure");
            if (addNewToolTest.ShowDialog() == DialogResult.OK)
            {
                //todo: make edited data update the selected list item
            }
        }
    }
}
