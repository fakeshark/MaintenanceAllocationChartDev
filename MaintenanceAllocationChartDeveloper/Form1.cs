﻿using System;
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

        public FrmMacDevMain()
        {
            InitializeComponent();
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

                //todo: add validation that item about to be entered isn't already on the list

                toolTestEquipList.Add("Maint. Level:   " + maintLvl + "\tNSN: " + nsn + "\tTool #: " + toolNum + "\tNomenclature: " + nomen);
                UpdateLists();
            }
        }

        private void UpdateLists()
        {
            lbxToolsTestEq.Items.Clear();

            for (int i = 0; i < toolTestEquipList.Count; i++)
            {
                lbxToolsTestEq.Items.Add(toolTestEquipList[i]);
            }
        }

        private void BtnMoveToolUp_Click(object sender, EventArgs e)
        {
            //make sure a list item is selected
            if (lbxToolsTestEq.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tool or test equipment item first.");
            }
            else
            {
                if (lbxToolsTestEq.SelectedIndex != 0)
                {
                    string upperItem = toolTestEquipList[lbxToolsTestEq.SelectedIndex - 1].ToString();
                    string lowerItem = toolTestEquipList[lbxToolsTestEq.SelectedIndex].ToString();
                    string tempContainer = upperItem;
                    int selectedItemIndex = lbxToolsTestEq.SelectedIndex - 1;

                    toolTestEquipList[lbxToolsTestEq.SelectedIndex - 1] = lowerItem;
                    toolTestEquipList[lbxToolsTestEq.SelectedIndex] = tempContainer;
                    UpdateLists();
                    lbxToolsTestEq.SetSelected(selectedItemIndex, true);
                }
                
            }


        }

        private void BtnMoveToolDown_Click(object sender, EventArgs e)
        {
            //make sure a list item is selected
            if (lbxToolsTestEq.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tool or test equipment item first.");
            }
            else
            {
                if (lbxToolsTestEq.SelectedIndex != lbxToolsTestEq.Items.Count - 1)
                {
                    string upperItem = toolTestEquipList[lbxToolsTestEq.SelectedIndex + 1].ToString();
                    string lowerItem = toolTestEquipList[lbxToolsTestEq.SelectedIndex].ToString();
                    string tempContainer = upperItem;
                    int selectedItemIndex = lbxToolsTestEq.SelectedIndex + 1;

                    toolTestEquipList[lbxToolsTestEq.SelectedIndex + 1] = lowerItem;
                    toolTestEquipList[lbxToolsTestEq.SelectedIndex] = tempContainer;
                    UpdateLists();
                    lbxToolsTestEq.SetSelected(selectedItemIndex, true);
                }

            }
        }

        private void BtnClearToolList_Click(object sender, EventArgs e)
        {
            //lbxToolsTestEq.Items.Clear();
            toolTestEquipList.Clear();
            UpdateLists();
        }
    }
}
