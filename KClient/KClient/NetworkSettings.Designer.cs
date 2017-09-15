namespace KClient
{
    partial class NetworkSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkSettings));
            this.lblHardwareData = new System.Windows.Forms.Label();
            this.txtHwData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtHwInstr = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIpAddr = new System.Windows.Forms.Label();
            this.txtIpAddr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHardwareInstr = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.bytReceived = new System.Windows.Forms.Label();
            this.bytSent = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.listPing = new System.Windows.Forms.ListView();
            this.lblPing = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNetworkStats = new System.Windows.Forms.Label();
            this.totalBytes = new System.Windows.Forms.Label();
            this.performanceCounter3 = new System.Diagnostics.PerformanceCounter();
            this.Bandwidth = new System.Windows.Forms.Label();
            this.performanceCounter4 = new System.Diagnostics.PerformanceCounter();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHardwareData
            // 
            this.lblHardwareData.AutoSize = true;
            this.lblHardwareData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardwareData.Location = new System.Drawing.Point(330, 357);
            this.lblHardwareData.Name = "lblHardwareData";
            this.lblHardwareData.Size = new System.Drawing.Size(130, 17);
            this.lblHardwareData.TabIndex = 41;
            this.lblHardwareData.Text = "General Instruction";
            // 
            // txtHwData
            // 
            this.txtHwData.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHwData.Location = new System.Drawing.Point(284, 377);
            this.txtHwData.Multiline = true;
            this.txtHwData.Name = "txtHwData";
            this.txtHwData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHwData.Size = new System.Drawing.Size(212, 93);
            this.txtHwData.TabIndex = 32;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(284, 309);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.toolTip2.SetToolTip(this.btnSend, "Send Instruction to the Hardware");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtHwInstr
            // 
            this.txtHwInstr.Location = new System.Drawing.Point(284, 210);
            this.txtHwInstr.Multiline = true;
            this.txtHwInstr.Name = "txtHwInstr";
            this.txtHwInstr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHwInstr.Size = new System.Drawing.Size(212, 93);
            this.txtHwInstr.TabIndex = 7;
            this.txtHwInstr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHwInstr_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(421, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Name:";
            // 
            // lblIpAddr
            // 
            this.lblIpAddr.AutoSize = true;
            this.lblIpAddr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpAddr.Location = new System.Drawing.Point(12, 75);
            this.lblIpAddr.Name = "lblIpAddr";
            this.lblIpAddr.Size = new System.Drawing.Size(120, 17);
            this.lblIpAddr.TabIndex = 39;
            this.lblIpAddr.Text = "Hardware IP Add.:";
            // 
            // txtIpAddr
            // 
            this.txtIpAddr.Location = new System.Drawing.Point(133, 72);
            this.txtIpAddr.Name = "txtIpAddr";
            this.txtIpAddr.Size = new System.Drawing.Size(153, 20);
            this.txtIpAddr.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(133, 144);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.toolTip1.SetToolTip(this.btnConnect, "This Button Set Out the Connection");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(133, 108);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(153, 20);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(13, 108);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(102, 17);
            this.lblPort.TabIndex = 38;
            this.lblPort.Text = "Hardware Port:";
            // 
            // lblHardwareInstr
            // 
            this.lblHardwareInstr.AutoSize = true;
            this.lblHardwareInstr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardwareInstr.Location = new System.Drawing.Point(297, 190);
            this.lblHardwareInstr.Name = "lblHardwareInstr";
            this.lblHardwareInstr.Size = new System.Drawing.Size(190, 17);
            this.lblHardwareInstr.TabIndex = 37;
            this.lblHardwareInstr.Text = "Send Instruction to Hardware";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(211, 144);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(346, 476);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(84, 23);
            this.btnLog.TabIndex = 13;
            this.btnLog.Text = "Create Log";
            this.toolTip3.SetToolTip(this.btnLog, "This Button Creates a Log of Received Data");
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Network Interface";
            this.performanceCounter1.CounterName = "Bytes Received/sec";
            this.performanceCounter1.InstanceName = "Qualcomm Atheros AR8151 PCI-E Gigabit Ethernet Controller [NDIS 6.30]";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Network Interface";
            this.performanceCounter2.CounterName = "Bytes Sent/sec";
            this.performanceCounter2.InstanceName = "Qualcomm Atheros AR8151 PCI-E Gigabit Ethernet Controller [NDIS 6.30]";
            // 
            // bytReceived
            // 
            this.bytReceived.AutoSize = true;
            this.bytReceived.Location = new System.Drawing.Point(42, 413);
            this.bytReceived.Name = "bytReceived";
            this.bytReceived.Size = new System.Drawing.Size(0, 13);
            this.bytReceived.TabIndex = 18;
            // 
            // bytSent
            // 
            this.bytSent.AutoSize = true;
            this.bytSent.Location = new System.Drawing.Point(42, 393);
            this.bytSent.Name = "bytSent";
            this.bytSent.Size = new System.Drawing.Size(0, 13);
            this.bytSent.TabIndex = 19;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(99, 309);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 6;
            this.btnPing.Text = "Ping";
            this.toolTip4.SetToolTip(this.btnPing, "Check the RTT of Connection");
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // listPing
            // 
            this.listPing.Location = new System.Drawing.Point(45, 210);
            this.listPing.Name = "listPing";
            this.listPing.Size = new System.Drawing.Size(189, 93);
            this.listPing.TabIndex = 21;
            this.listPing.UseCompatibleStateImageBehavior = false;
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPing.Location = new System.Drawing.Point(83, 190);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(122, 17);
            this.lblPing.TabIndex = 35;
            this.lblPing.Text = "Check Connection";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNetworkStats
            // 
            this.lblNetworkStats.AutoSize = true;
            this.lblNetworkStats.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkStats.Location = new System.Drawing.Point(73, 357);
            this.lblNetworkStats.Name = "lblNetworkStats";
            this.lblNetworkStats.Size = new System.Drawing.Size(120, 17);
            this.lblNetworkStats.TabIndex = 32;
            this.lblNetworkStats.Text = "Network Statistics";
            // 
            // totalBytes
            // 
            this.totalBytes.AutoSize = true;
            this.totalBytes.Location = new System.Drawing.Point(42, 434);
            this.totalBytes.Name = "totalBytes";
            this.totalBytes.Size = new System.Drawing.Size(0, 13);
            this.totalBytes.TabIndex = 30;
            // 
            // performanceCounter3
            // 
            this.performanceCounter3.CategoryName = "Network Interface";
            this.performanceCounter3.CounterName = "Bytes Total/sec";
            this.performanceCounter3.InstanceName = "Qualcomm Atheros AR8151 PCI-E Gigabit Ethernet Controller [NDIS 6.30]";
            // 
            // Bandwidth
            // 
            this.Bandwidth.AutoSize = true;
            this.Bandwidth.Location = new System.Drawing.Point(42, 456);
            this.Bandwidth.Name = "Bandwidth";
            this.Bandwidth.Size = new System.Drawing.Size(0, 13);
            this.Bandwidth.TabIndex = 31;
            // 
            // performanceCounter4
            // 
            this.performanceCounter4.CategoryName = "Network Interface";
            this.performanceCounter4.CounterName = "Current Bandwidth";
            this.performanceCounter4.InstanceName = "Qualcomm Atheros AR8151 PCI-E Gigabit Ethernet Controller [NDIS 6.30]";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(42, 478);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 13);
            this.lblIP.TabIndex = 43;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(83, 9);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(137, 17);
            this.lblConnection.TabIndex = 36;
            this.lblConnection.Text = "Establish Connection";
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(431, 9);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(66, 61);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 44;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NetworkSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 506);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.Bandwidth);
            this.Controls.Add(this.totalBytes);
            this.Controls.Add(this.lblNetworkStats);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.listPing);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.bytSent);
            this.Controls.Add(this.bytReceived);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblHardwareInstr);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIpAddr);
            this.Controls.Add(this.lblIpAddr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtHwInstr);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtHwData);
            this.Controls.Add(this.lblHardwareData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetworkSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.toolTip5.SetToolTip(this, "Network Tool");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHardwareData;
        private System.Windows.Forms.TextBox txtHwData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtHwInstr;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIpAddr;
        private System.Windows.Forms.TextBox txtIpAddr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHardwareInstr;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.Label bytReceived;
        private System.Windows.Forms.Label bytSent;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.ListView listPing;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNetworkStats;
        private System.Windows.Forms.Label totalBytes;
        private System.Diagnostics.PerformanceCounter performanceCounter3;
        private System.Windows.Forms.Label Bandwidth;
        private System.Diagnostics.PerformanceCounter performanceCounter4;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Timer timer1;
    }
}

