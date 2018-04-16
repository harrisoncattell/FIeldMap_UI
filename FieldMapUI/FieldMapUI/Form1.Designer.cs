namespace FieldMapUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.btnLoadDataFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnlockSettings = new System.Windows.Forms.Button();
            this.btnLockSettings = new System.Windows.Forms.Button();
            this.rbColour = new System.Windows.Forms.RadioButton();
            this.rbPH = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboIntDegree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInterpolate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.btnOutputLocation = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnLoadDataFile);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInputFile);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(168, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected File";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(8, 32);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(0, 23);
            this.lblInputFile.TabIndex = 0;
            // 
            // btnLoadDataFile
            // 
            this.btnLoadDataFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadDataFile.Location = new System.Drawing.Point(8, 40);
            this.btnLoadDataFile.Name = "btnLoadDataFile";
            this.btnLoadDataFile.Size = new System.Drawing.Size(128, 56);
            this.btnLoadDataFile.TabIndex = 1;
            this.btnLoadDataFile.Text = "Select Data Files";
            this.btnLoadDataFile.UseVisualStyleBackColor = true;
            this.btnLoadDataFile.Click += new System.EventHandler(this.btnLoadDataFile_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnlockSettings);
            this.groupBox3.Controls.Add(this.btnLockSettings);
            this.groupBox3.Controls.Add(this.rbColour);
            this.groupBox3.Controls.Add(this.rbPH);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboIntDegree);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 232);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 2";
            // 
            // btnUnlockSettings
            // 
            this.btnUnlockSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnlockSettings.Location = new System.Drawing.Point(200, 168);
            this.btnUnlockSettings.Name = "btnUnlockSettings";
            this.btnUnlockSettings.Size = new System.Drawing.Size(136, 55);
            this.btnUnlockSettings.TabIndex = 6;
            this.btnUnlockSettings.Text = "Unlock Settings";
            this.btnUnlockSettings.UseVisualStyleBackColor = true;
            this.btnUnlockSettings.Click += new System.EventHandler(this.btnUnlockSettings_Click);
            // 
            // btnLockSettings
            // 
            this.btnLockSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLockSettings.Location = new System.Drawing.Point(8, 168);
            this.btnLockSettings.Name = "btnLockSettings";
            this.btnLockSettings.Size = new System.Drawing.Size(184, 55);
            this.btnLockSettings.TabIndex = 5;
            this.btnLockSettings.Text = "Lock Settings";
            this.btnLockSettings.UseVisualStyleBackColor = true;
            this.btnLockSettings.Click += new System.EventHandler(this.btnLockSettings_Click);
            // 
            // rbColour
            // 
            this.rbColour.AutoSize = true;
            this.rbColour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbColour.Location = new System.Drawing.Point(120, 136);
            this.rbColour.Name = "rbColour";
            this.rbColour.Size = new System.Drawing.Size(78, 28);
            this.rbColour.TabIndex = 4;
            this.rbColour.TabStop = true;
            this.rbColour.Text = "Colour";
            this.rbColour.UseVisualStyleBackColor = true;
            // 
            // rbPH
            // 
            this.rbPH.AutoSize = true;
            this.rbPH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbPH.Location = new System.Drawing.Point(120, 104);
            this.rbPH.Name = "rbPH";
            this.rbPH.Size = new System.Drawing.Size(52, 28);
            this.rbPH.TabIndex = 3;
            this.rbPH.TabStop = true;
            this.rbPH.Text = "pH";
            this.rbPH.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Map Type:";
            // 
            // comboIntDegree
            // 
            this.comboIntDegree.FormattingEnabled = true;
            this.comboIntDegree.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboIntDegree.Location = new System.Drawing.Point(232, 48);
            this.comboIntDegree.Name = "comboIntDegree";
            this.comboIntDegree.Size = new System.Drawing.Size(88, 32);
            this.comboIntDegree.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Degree of Interpolation: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInterpolate);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnOutputLocation);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(360, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 360);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 3";
            // 
            // btnInterpolate
            // 
            this.btnInterpolate.Location = new System.Drawing.Point(8, 200);
            this.btnInterpolate.Name = "btnInterpolate";
            this.btnInterpolate.Size = new System.Drawing.Size(232, 136);
            this.btnInterpolate.TabIndex = 3;
            this.btnInterpolate.Text = "Start Interpolation";
            this.btnInterpolate.UseVisualStyleBackColor = true;
            this.btnInterpolate.Click += new System.EventHandler(this.btnInterpolate_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblOutputLocation);
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(8, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 64);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected File";
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Location = new System.Drawing.Point(8, 32);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(0, 23);
            this.lblOutputLocation.TabIndex = 0;
            // 
            // btnOutputLocation
            // 
            this.btnOutputLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOutputLocation.Location = new System.Drawing.Point(8, 40);
            this.btnOutputLocation.Name = "btnOutputLocation";
            this.btnOutputLocation.Size = new System.Drawing.Size(232, 56);
            this.btnOutputLocation.TabIndex = 1;
            this.btnOutputLocation.Text = "Select Output File Location";
            this.btnOutputLocation.UseVisualStyleBackColor = true;
            this.btnOutputLocation.Click += new System.EventHandler(this.btnOutputLocation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FieldMapUI.Properties.Resources.FieldMap_Logo_v31;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(625, 481);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FieldMap_UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadDataFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboIntDegree;
        private System.Windows.Forms.Button btnUnlockSettings;
        private System.Windows.Forms.Button btnLockSettings;
        private System.Windows.Forms.RadioButton rbColour;
        private System.Windows.Forms.RadioButton rbPH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.Button btnOutputLocation;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btnInterpolate;
    }
}

