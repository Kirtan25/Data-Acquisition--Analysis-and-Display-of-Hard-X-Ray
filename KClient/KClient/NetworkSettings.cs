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
    public delegate void UpdateText(string txt);

    public partial class NetworkSettings : Form
    {
            Client client;

            public NetworkSettings()
            {
                InitializeComponent();
            }

            string GetIPAddress()
                {
                    IPHostEntry myHost;
                    string ip = "?";
                    myHost = Dns.GetHostEntry(Dns.GetHostName());
                    foreach(IPAddress ipa in myHost.AddressList )
                    {
                        if (ipa.AddressFamily.ToString() == "InterNetwork")
                        {
                            ip = ipa.ToString();
                        }
                    }
                    return ip;
                }

            private void Form1_Load(object sender, EventArgs e)
            {
            }

            private void ChangeTextBox(string txt)
            {
                if(txtHwData.InvokeRequired)
                {
                    Invoke(new UpdateText(ChangeTextBox), new object[] { txt });
                }
                else
                {
                    txtHwData.Text += txt + "\r\n";
                }
            }
       
            private void btnConnect_Click(object sender, EventArgs e)
            {
                IPAddress ip;
                string ipaddress = txtIpAddr.Text;
                bool ValidateIP = IPAddress.TryParse(ipaddress, out ip);
            
                    if (txtIpAddr.Text != "" && txtName.Text != "" && txtPort.Text != "")
                    {
                        client = new Client();
                        client.ClientName = txtName.Text;
                        if (ValidateIP)
                        {
                            client.ServerIp = txtIpAddr.Text;
                            btnConnect.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid IP Address !!!");
                            btnConnect.Visible = true;
                        }
                    
                        client.ServerPort = txtPort.Text;
                        client.OnClientConnected += new OnClientConnectedDelegate(client_OnClientConnected);
                        client.OnClientConnecting += new OnClientConnectingDelegate(client_OnClientConnecting);
                        client.OnClientDisconnected += new OnClientDisconnectedDelegate(client_OnClientDisConnected);
                        client.OnClientError += new OnClientErrorDelegate(client_OnClientError);
                        client.OnClientFileSending += new OnClientFileSendingDelegate(client_OnClientFileSending);
                        client.OnDataReceived += new OnClientReceivedDelegate(client_OnDataReceived);
                        client.Connect();                   
                    }
                    else
                    {
                        MessageBox.Show("Fill All The TextBoxes First !!!");
                        btnConnect.Visible = true;
                    }            
            }

            private void client_OnDataReceived(object Sender, ClientReceivedArguments R)
            {
                ChangeTextBox(R.ReceivedData);
            }

            private void client_OnClientFileSending(object Sender, ClientFileSendingArguments R)
            {
           
            }

            private void client_OnClientError(object Sender, ClientErrorArguments R)
            {
                ChangeTextBox(R.ErrorMessage);
            }

            private void client_OnClientDisConnected(object Sender, ClientDisconnectedArguments R)
            {
                ChangeTextBox(txtName.Text + " Has Been " + R.EventMessage);
            }

            private void client_OnClientConnecting(object Sender, ClientConnectingArguments R)
            {
            //    ChangeTextBox(R.EventMessage);
            }

            private void client_OnClientConnected(object Sender, ClientConnectedArguments R)
            {
                ChangeTextBox(R.EventMessage);
            }

            private void btnSend_Click(object sender, EventArgs e)
            {
                    if (client != null && client.IsConnected)
                    {
                        String s = DateTime.Now.ToString("HH:mm:ss.ffffff");
                        client.Send(txtHwInstr.Text + "               " + s);
                        txtHwInstr.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please Connect Before Send !!!");
                    }
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                txtHwInstr.Clear();
            }

            private void txtHwInstr_KeyDown(object sender, KeyEventArgs e)
            {
                if (client != null && client.IsConnected && e.KeyCode == Keys.Enter)
                {
                    client.Send(txtHwInstr.Text);
                    txtHwInstr.Clear();
                }
            }

            private void btnDisconnect_Click(object sender, EventArgs e)
            {
                if (client != null && client.IsConnected)
                {
                    client.Disconnect();
                    btnConnect.Visible = true;
                }
            }

            private void btnLog_Click(object sender, EventArgs e)
            {
                if (client != null && client.IsConnected)
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    // set a default file name
                    savefile.FileName = "Log";
                    // set filters - this can be done in properties as well
                    savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Excel files (*.xls)|*.xls";
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(savefile.FileName))
                            sw.WriteLine(txtHwData.Text);
                        MessageBox.Show("Log File Generated Successfully !!!");
                    }
                }            
                else
                {
                    if (btnConnect.Visible == true)
                    {
                        MessageBox.Show("Please Connect First !!!");
                    } 
                }
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                bytReceived.Text = "Bytes Received: " + performanceCounter1.NextValue();
                bytSent.Text = "Bytes Sent: " + performanceCounter2.NextValue();
                totalBytes.Text = "Total Bytes: " + performanceCounter3.NextValue();
                Bandwidth.Text = "Bandwidth: " + performanceCounter4.NextValue();
                lblIP.Text = "Local Machine IP: " + GetIPAddress();              
            }

            private void btnPing_Click(object sender, EventArgs e)
            {
                if (client != null && client.IsConnected)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        using (Ping p = new Ping())
                        {
                            listPing.Items.Add(p.Send(txtIpAddr.Text).RoundtripTime.ToString() + "ms\n");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Connect First !!!");
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
