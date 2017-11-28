﻿using System;
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
    public partial class FrmMacDevMain : Form
    {
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
            //Clear all lists and variables to start a new project
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open save file to load existing project
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
    }
}
