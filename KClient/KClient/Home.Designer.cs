namespace KClient
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChannel3 = new System.Windows.Forms.Button();
            this.btnChannel2 = new System.Windows.Forms.Button();
            this.btnChannel1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEnergyCount = new System.Windows.Forms.Button();
            this.btnTimeEnergy = new System.Windows.Forms.Button();
            this.btnTimeCount = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbNetSet = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNetSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(12, 180);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(237, 25);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoToolTip = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 220);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(395, 129);
            this.webBrowser1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Access Channels";
            // 
            // btnChannel3
            // 
            this.btnChannel3.Location = new System.Drawing.Point(423, 301);
            this.btnChannel3.Name = "btnChannel3";
            this.btnChannel3.Size = new System.Drawing.Size(64, 23);
            this.btnChannel3.TabIndex = 54;
            this.btnChannel3.Text = "Channel-3";
            this.btnChannel3.UseVisualStyleBackColor = true;
            this.btnChannel3.Click += new System.EventHandler(this.btnChannel3_Click);
            // 
            // btnChannel2
            // 
            this.btnChannel2.Location = new System.Drawing.Point(423, 262);
            this.btnChannel2.Name = "btnChannel2";
            this.btnChannel2.Size = new System.Drawing.Size(64, 23);
            this.btnChannel2.TabIndex = 53;
            this.btnChannel2.Text = "Channel-2";
            this.btnChannel2.UseVisualStyleBackColor = true;
            this.btnChannel2.Click += new System.EventHandler(this.btnChannel2_Click);
            // 
            // btnChannel1
            // 
            this.btnChannel1.Location = new System.Drawing.Point(423, 224);
            this.btnChannel1.Name = "btnChannel1";
            this.btnChannel1.Size = new System.Drawing.Size(64, 23);
            this.btnChannel1.TabIndex = 52;
            this.btnChannel1.Text = "Channel-1";
            this.btnChannel1.UseVisualStyleBackColor = true;
            this.btnChannel1.Click += new System.EventHandler(this.btnChannel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Version 1.0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(151, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEnergyCount
            // 
            this.btnEnergyCount.Location = new System.Drawing.Point(493, 224);
            this.btnEnergyCount.Name = "btnEnergyCount";
            this.btnEnergyCount.Size = new System.Drawing.Size(85, 23);
            this.btnEnergyCount.TabIndex = 59;
            this.btnEnergyCount.Text = "Energy->Count";
            this.btnEnergyCount.UseVisualStyleBackColor = true;
            this.btnEnergyCount.Click += new System.EventHandler(this.btnEnergyCount_Click);
            // 
            // btnTimeEnergy
            // 
            this.btnTimeEnergy.Location = new System.Drawing.Point(493, 262);
            this.btnTimeEnergy.Name = "btnTimeEnergy";
            this.btnTimeEnergy.Size = new System.Drawing.Size(85, 23);
            this.btnTimeEnergy.TabIndex = 60;
            this.btnTimeEnergy.Text = "Time->Energy";
            this.btnTimeEnergy.UseVisualStyleBackColor = true;
            this.btnTimeEnergy.Click += new System.EventHandler(this.btnTimeEnergy_Click);
            // 
            // btnTimeCount
            // 
            this.btnTimeCount.Location = new System.Drawing.Point(493, 301);
            this.btnTimeCount.Name = "btnTimeCount";
            this.btnTimeCount.Size = new System.Drawing.Size(85, 23);
            this.btnTimeCount.TabIndex = 61;
            this.btnTimeCount.Text = "Time->Count";
            this.btnTimeCount.UseVisualStyleBackColor = true;
            this.btnTimeCount.Click += new System.EventHandler(this.btnTimeCount_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(423, 110);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(150, 20);
            this.txtPath.TabIndex = 63;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(515, 147);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(55, 23);
            this.btnFilePath.TabIndex = 64;
            this.btnFilePath.Text = "Browse";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Set File Path";
            // 
            // pbNetSet
            // 
            this.pbNetSet.Image = ((System.Drawing.Image)(resources.GetObject("pbNetSet.Image")));
            this.pbNetSet.Location = new System.Drawing.Point(508, 12);
            this.pbNetSet.Name = "pbNetSet";
            this.pbNetSet.Size = new System.Drawing.Size(62, 50);
            this.pbNetSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNetSet.TabIndex = 67;
            this.pbNetSet.TabStop = false;
            this.pbNetSet.Click += new System.EventHandler(this.pbNetSet_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pbNetSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnTimeCount);
            this.Controls.Add(this.btnTimeEnergy);
            this.Controls.Add(this.btnEnergyCount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChannel3);
            this.Controls.Add(this.btnChannel2);
            this.Controls.Add(this.btnChannel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNetSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChannel3;
        private System.Windows.Forms.Button btnChannel2;
        private System.Windows.Forms.Button btnChannel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnergyCount;
        private System.Windows.Forms.Button btnTimeEnergy;
        private System.Windows.Forms.Button btnTimeCount;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbNetSet;
    }
}