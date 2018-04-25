using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

using FieldMap;

namespace FieldMapUI
{
    public partial class Form1 : Form
    {

        // Initalises public veriables
        public string inputFilename = null;
        public string outputFilename = null;
        public int mapColor = 0;
        public int intDegree = 0;
        public bool isSettingLocked = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        // Handles LoadDataFile button click
        private void btnLoadDataFile_Click(object sender, EventArgs e)
        {

            // Opens file selector
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "txt files (*.txt)|*.txt";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                lblInputFile.Text = openFile.SafeFileName;
                inputFilename = openFile.FileName;

            }
        }

        // Handles LockSettings button click
        private void btnLockSettings_Click(object sender, EventArgs e)
        {

            intDegree = Convert.ToInt16(comboIntDegree.SelectedItem);

            if (intDegree == 0)
            {

                MessageBox.Show("Please select degree of interpolation, the defaul is 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if(rbPH.Checked == true)
            {

                mapColor = 1;
                

            }
            else if(rbColour.Checked == true)
            {

                mapColor = 2;

            }
            else if(mapColor == 0)
            {

                MessageBox.Show("Please select a map color, the default is pH", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (intDegree != 0 && mapColor != 0)
            {
                comboIntDegree.Enabled = false;
                rbColour.Enabled = false;
                rbPH.Enabled = false;
                isSettingLocked = true;
            }

        }

        // Handles UnlockSettings button click
        private void btnUnlockSettings_Click(object sender, EventArgs e)
        {

            comboIntDegree.Enabled = true;
            rbColour.Enabled = true;
            rbPH.Enabled = true;
            isSettingLocked = false;

        }

        // Handles OutputLocation button click
        private void btnOutputLocation_Click(object sender, EventArgs e)
        {

            // Opens folder dialogue
            folderDialog.ShowDialog();
            outputFilename = folderDialog.SelectedPath + "\\export.jpg";

            lblOutputLocation.Text = outputFilename;
            

        }

        // Handles Interpolation button click
        private void btnInterpolate_Click(object sender, EventArgs e)
        {

            if(inputFilename != null && outputFilename != null && isSettingLocked == true)
            {


                Connect_Matlab(); //Links to function to carry out interpolation

                // Sets filepaths  back to null
                inputFilename = null;
                outputFilename = null;
                lblInputFile.Text = null;
                lblOutputLocation.Text = null;

            }
            else
            {

                // Displays error message
                MessageBox.Show("Please input a data file, specify an output location and lock settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        // Calls the class in the library 'FieldMap'
        public void Connect_Matlab()
        {

            try
            {
                Interpolate_Data obj = new Interpolate_Data(); // Creates object

                obj.FieldMap(inputFilename, outputFilename, intDegree, mapColor); // Uses object to call fieldmap function and pass arguments

                MessageBox.Show("Analysis Complete, exported image saved to chosen location", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch(Exception e)
            {

                MessageBox.Show("An error has occurred: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            rbPH.Checked = true;
            comboIntDegree.SelectedItem = "2";
            intDegree = 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            help help_info = new help();
            help_info.Show();

        }
    }
}
