using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace serverSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       

        private void btnSendMessages_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPort.Text == "")
                {
                    MessageBox.Show("Please Enter a port number");
                    return;
                }
                int port = Convert.ToInt32(txtPort);
                Socket mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, port);
                mainSocket.Bind(ipLocal);
                mainSocket.Listen(4);
                mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

                UpdateControl(true);
                
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void UpdateControl(bool listening)
        {
            btnConnectToServer.Enabled = !listening;
            btnDisconnectServer.Enabled = listening;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        public void OnClientConnect(IAsyncResult asyn)
        {
            try
            {

            }
            catch (ObjectDisposedException)
            {

            }
            
        }
    }
}
