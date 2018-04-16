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

        public string inputFilename = null;
        public string outputFilename = null;
        public int mapColor = 0;
        public int intDegree = 0;
        public bool isSettingLocked = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadDataFile_Click(object sender, EventArgs e)
        {

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

        private void btnLockSettings_Click(object sender, EventArgs e)
        {

            intDegree = Convert.ToInt16(comboIntDegree.SelectedItem);

            if (intDegree == 0)
            {

                MessageBox.Show("Please select degree of interpolation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Please select a map color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (intDegree != 0 && mapColor != 0)
            {
                comboIntDegree.Enabled = false;
                rbColour.Enabled = false;
                rbPH.Enabled = false;
                isSettingLocked = true;
            }

        }

        private void btnUnlockSettings_Click(object sender, EventArgs e)
        {

            comboIntDegree.Enabled = true;
            rbColour.Enabled = true;
            rbPH.Enabled = true;
            isSettingLocked = false;

        }

        private void btnOutputLocation_Click(object sender, EventArgs e)
        {

            folderDialog.ShowDialog();
            outputFilename = folderDialog.SelectedPath + "\\export.jpg";

            lblOutputLocation.Text = outputFilename;
            

        }

        private void btnInterpolate_Click(object sender, EventArgs e)
        {

            if(inputFilename != null && outputFilename != null && isSettingLocked == true)
            {

                MessageBox.Show(outputFilename);
                Connect_Matlab();
                inputFilename = null;
                outputFilename = null;
                lblInputFile.Text = null;
                lblOutputLocation.Text = null;

            }
            else
            {

                MessageBox.Show("Please input a data file, specify an output location and lock settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Connect_Matlab()
        {

            Main obj = new Main();

            obj.FieldMap(inputFilename, outputFilename, intDegree, mapColor);

        }
    }
}
