using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworksApi.TCP.CLIENT;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace KClient
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            btnSave.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string k = webBrowser1.DocumentText;
            string s = System.Text.RegularExpressions.Regex.Replace(k, "<[^>]*>", "");
            if (s != "\r\n\r\n" && s != "")
            {
                string[] d = s.Split(' ');
                int kk = int.Parse(d[1]);
                int dd = int.Parse(d[2]);
                TextWriter ttt = new StreamWriter(txtPath.Text, true);
                ttt.Write(d[0] + " ");
                ttt.Write(d[1] + " ");
                ttt.Write(d[2] + " ");
                ttt.Write(d[3] + " ");
                ttt.Write(d[4]);
                ttt.Write(d[5] + " ");
                ttt.Write(d[6] + " ");
                ttt.Write(d[7] + " ");
                ttt.Write(d[8] + " ");
                ttt.Write(d[9] + " ");
                ttt.Write(d[10]);
                ttt.Write(d[11] + " "); 
                ttt.Write(d[12] + " ");
                ttt.Write(d[13] + " ");
                ttt.Write(d[14] + " ");
                ttt.Write(d[15] + " ");
                ttt.Write(d[16]);
                ttt.Write(d[17] + Environment.NewLine + "**********");
                ttt.Close();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(toolStripTextBox1.Text) || toolStripTextBox1.Text.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                toolStripTextBox1.Focus();
                return;
            }
            OpenURLInBrowser(toolStripTextBox1.Text);
        }

        private void OpenURLInBrowser(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "Log";
            // set filters - this can be done in properties as well
            sf.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Excel files (*.xls)|*.xls";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                String s = DateTime.Now.ToString("HH:mm:ss.ffffff");
                txtPath.Text = sf.FileName;
                TextWriter tt = new StreamWriter(txtPath.Text, true);
                tt.Write("Time : " + s + Environment.NewLine +"1.Sensor  " + "2.Energy  " + "3.Count  " + "4.Temperature  " + "5.Time");
                tt.Close();
            }
        }

        private void btnChannel1_Click(object sender, EventArgs e)
        {
            Channel1 c1 = new Channel1();
            c1.ShowDialog();
            c1.Dispose();
        }

        private void btnChannel2_Click(object sender, EventArgs e)
        {
            Channel2 c2 = new Channel2();
            c2.ShowDialog();
            c2.Dispose();
        }

        private void btnChannel3_Click(object sender, EventArgs e)
        {
            Channel3 c3 = new Channel3();
            c3.ShowDialog();
            c3.Dispose();
        }

        private void btnEnergyCount_Click(object sender, EventArgs e)
        {
            EnergyCount ec = new EnergyCount();
            ec.ShowDialog();
            ec.Dispose();
        }

        private void btnTimeEnergy_Click(object sender, EventArgs e)
        {
            TimeEnergy et = new TimeEnergy();
            et.ShowDialog();
            et.Dispose();
        }

        private void btnTimeCount_Click(object sender, EventArgs e)
        {
            TimeCount tc = new TimeCount();
            tc.ShowDialog();
            tc.Dispose();
        }

        private void pbNetSet_Click(object sender, EventArgs e)
        {
            NetworkSettings nt = new NetworkSettings();
            nt.ShowDialog();
            nt.Dispose();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

    }
}
