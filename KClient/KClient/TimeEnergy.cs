using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KClient
{
    public partial class TimeEnergy : Form
    {
        public TimeEnergy()
        {
            InitializeComponent();
        }

        private void TimeEnergy_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            btnGraph.PerformClick();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            string k = webBrowser1.DocumentText;
            string s = System.Text.RegularExpressions.Regex.Replace(k, "<[^>]*>", "");
            if (s != "\r\n\r\n" && s != "")
            {
                string[] d = s.Split(' ');
                int e1 = int.Parse(d[1]);
                int t1 = int.Parse(d[5]);
                int e2 = int.Parse(d[7]);
                int t2 = int.Parse(d[11]);
                int e3 = int.Parse(d[13]);
                int t3 = int.Parse(d[17]);

                this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                this.chart1.Series["Time->Energy"].Points.AddXY(t1 , e1);
                this.chart2.Series["Time->Energy"].Points.AddXY(t2 , e2);
                this.chart3.Series["Time->Energy"].Points.AddXY(t3 , e3);
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

        private void pbHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Dispose();
        }      

    }
}
