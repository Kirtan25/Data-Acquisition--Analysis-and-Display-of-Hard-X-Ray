﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KClient
{
    public partial class EnergyCount : Form
    {
        public EnergyCount()
        {
            InitializeComponent();
        }

        private void EnergyCount_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
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
                int c1 = int.Parse(d[2]);
                int e2 = int.Parse(d[7]);
                int c2 = int.Parse(d[8]);
                int e3 = int.Parse(d[13]);
                int c3 = int.Parse(d[14]);
               
                this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                this.chart1.Series["Energy->Count"].Points.AddXY(e1, c1);
                this.chart2.Series["Energy->Count"].Points.AddXY(e2,c2 );
                this.chart3.Series["Energy->Count"].Points.AddXY(e3, c3);
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

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousepoint = new Point(e.X, e.Y);

            chart1.ChartAreas[0].CursorX.Interval = 0;
            chart1.ChartAreas[0].CursorY.Interval = 0;

            chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(mousepoint, true);
            chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(mousepoint, true);
          
            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if (result.PointIndex > -1 && result.ChartArea != null)
            {
                if (result.Series.Points[result.PointIndex].XValue >= 2200 && result.Series.Points[result.PointIndex].XValue < 2400)
                {
                    label4.Text = "Element: Zr (40, Zirconium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2400 && result.Series.Points[result.PointIndex].XValue < 2600)
                {
                    label4.Text = "Element: Nb (41, Niobium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2600 && result.Series.Points[result.PointIndex].XValue < 2700)
                {
                    label4.Text = "Element: Mo (42, Molybdenum)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2700 && result.Series.Points[result.PointIndex].XValue < 2800)
                {
                    label4.Text = "Element: Tc (43, Technetium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2800 && result.Series.Points[result.PointIndex].XValue < 3000)
                {
                    label4.Text = "Element: Ru (44, Ruthenium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3000 && result.Series.Points[result.PointIndex].XValue < 3150)
                {
                    label4.Text = "Element: Rh (45, Rhodium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3150 && result.Series.Points[result.PointIndex].XValue < 3400)
                {
                    label4.Text = "Element: Pd (46, Palladium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3400 && result.Series.Points[result.PointIndex].XValue < 3600)
                {
                    label4.Text = "Element: Ag (47, Silver)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3600 && result.Series.Points[result.PointIndex].XValue < 3800)
                {
                    label4.Text = "Element: Cd (48, Cadmium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3800 && result.Series.Points[result.PointIndex].XValue < 4000)
                {
                    label4.Text = "Element: In (49, Indium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 4000 && result.Series.Points[result.PointIndex].XValue < 4200)
                {
                    label4.Text = "Element: Sn (50, Tin)";
                }
                else { label4.Text = String.Empty; }
            }
        }

        private void chart2_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousepoint = new Point(e.X, e.Y);

            chart2.ChartAreas[0].CursorX.Interval = 0;
            chart2.ChartAreas[0].CursorY.Interval = 0;

            chart2.ChartAreas[0].CursorX.SetCursorPixelPosition(mousepoint, true);
            chart2.ChartAreas[0].CursorY.SetCursorPixelPosition(mousepoint, true);

            HitTestResult result = chart2.HitTest(e.X, e.Y);
            if (result.PointIndex > -1 && result.ChartArea != null)
            {
                if (result.Series.Points[result.PointIndex].XValue >= 2200 && result.Series.Points[result.PointIndex].XValue < 2400)
                {
                    label5.Text = "Element: Zr (40, Zirconium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2400 && result.Series.Points[result.PointIndex].XValue < 2600)
                {
                    label5.Text = "Element: Nb (41, Niobium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2600 && result.Series.Points[result.PointIndex].XValue < 2700)
                {
                    label5.Text = "Element: Mo (42, Molybdenum)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2700 && result.Series.Points[result.PointIndex].XValue < 2800)
                {
                    label5.Text = "Element: Tc (43, Technetium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2800 && result.Series.Points[result.PointIndex].XValue < 3000)
                {
                    label5.Text = "Element: Ru (44, Ruthenium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3000 && result.Series.Points[result.PointIndex].XValue < 3150)
                {
                    label5.Text = "Element: Rh (45, Rhodium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3150 && result.Series.Points[result.PointIndex].XValue < 3400)
                {
                    label5.Text = "Element: Pd (46, Palladium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3400 && result.Series.Points[result.PointIndex].XValue < 3600)
                {
                    label5.Text = "Element: Ag (47, Silver)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3600 && result.Series.Points[result.PointIndex].XValue < 3800)
                {
                    label5.Text = "Element: Cd (48, Cadmium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3800 && result.Series.Points[result.PointIndex].XValue < 4000)
                {
                    label5.Text = "Element: In (49, Indium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 4000 && result.Series.Points[result.PointIndex].XValue < 4200)
                {
                    label5.Text = "Element: Sn (50, Tin)";
                }
                else { label5.Text = String.Empty; }
            }
        }

        private void chart3_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousepoint = new Point(e.X, e.Y);

            chart3.ChartAreas[0].CursorX.Interval = 0;
            chart3.ChartAreas[0].CursorY.Interval = 0;

            chart3.ChartAreas[0].CursorX.SetCursorPixelPosition(mousepoint, true);
            chart3.ChartAreas[0].CursorY.SetCursorPixelPosition(mousepoint, true);

            HitTestResult result = chart3.HitTest(e.X, e.Y);
            if (result.PointIndex > -1 && result.ChartArea != null)
            {
                if (result.Series.Points[result.PointIndex].XValue >= 2200 && result.Series.Points[result.PointIndex].XValue < 2400)
                {
                    label6.Text = "Element: Zr (40, Zirconium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2400 && result.Series.Points[result.PointIndex].XValue < 2600)
                {
                    label6.Text = "Element: Nb (41, Niobium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2600 && result.Series.Points[result.PointIndex].XValue < 2700)
                {
                    label6.Text = "Element: Mo (42, Molybdenum)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2700 && result.Series.Points[result.PointIndex].XValue < 2800)
                {
                    label6.Text = "Element: Tc (43, Technetium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 2800 && result.Series.Points[result.PointIndex].XValue < 3000)
                {
                    label6.Text = "Element: Ru (44, Ruthenium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3000 && result.Series.Points[result.PointIndex].XValue < 3150)
                {
                    label6.Text = "Element: Rh (45, Rhodium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3150 && result.Series.Points[result.PointIndex].XValue < 3400)
                {
                    label6.Text = "Element: Pd (46, Palladium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3400 && result.Series.Points[result.PointIndex].XValue < 3600)
                {
                    label6.Text = "Element: Ag (47, Silver)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3600 && result.Series.Points[result.PointIndex].XValue < 3800)
                {
                    label6.Text = "Element: Cd (48, Cadmium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 3800 && result.Series.Points[result.PointIndex].XValue < 4000)
                {
                    label6.Text = "Element: In (49, Indium)";
                }
                else if (result.Series.Points[result.PointIndex].XValue >= 4000 && result.Series.Points[result.PointIndex].XValue < 4200)
                {
                    label6.Text = "Element: Sn (50, Tin)";
                }
                else { label6.Text = String.Empty; }
            }
        }

        private void EnergyCount_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Dispose();
        }

    }
}