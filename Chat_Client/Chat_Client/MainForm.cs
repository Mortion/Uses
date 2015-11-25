using System;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace Chat_Client
{
    public partial class FrmMain : Form
    {

        #region Properties

        private Socket _socket;
        EndPoint _epLocal, _epRemote;
        #endregion


        public FrmMain()
        {
            InitializeComponent();

            //initializer
            Initialize();
        }
        /// <summary>
        /// - Initializes your _socket
        /// - Gets your local ip
        /// </summary>
        private void Initialize()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtIpClient1.Text = GetLocalIp();
            txtIpClient2.Text = GetLocalIp();

        }

        private void MessageCallBack(IAsyncResult result)
        {
            try
            {
                int size = _socket.EndReceiveFrom(result, ref _epRemote);

                if (size > 0)
                {
                    var recievedData = (byte[])result.AsyncState;

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string receivedMessage = encoding.GetString(recievedData);

                    lstChatbox.Items.Add("Friend: " + receivedMessage);
                }

                byte[] buffer = new byte[1500];
                _socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote,
                    MessageCallBack, buffer);
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }


        private string GetLocalIp()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }



        private void btnConnectClients_Click(object sender, EventArgs e)
        {
            try
            {
                //bind local
                _epLocal= new IPEndPoint(
                    IPAddress.Parse(txtIpClient1.Text),int.Parse(txtPortClient1.Text));
                lstChatbox.Items.Add("Bound "+ txtIpClient1.Text + "  port "+txtPortClient1.Text);
                _socket.Bind(_epLocal);

                //connect remote
                _epRemote = new IPEndPoint(
                   IPAddress.Parse(txtIpClient2.Text), int.Parse(txtPortClient2.Text));
                lstChatbox.Items.Add("connected " + txtIpClient2.Text + "  port " + txtPortClient2.Text);
                _socket.Connect(_epRemote);

                byte[] buffer = new byte[1500];
                _socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _epRemote,
                    new AsyncCallback(MessageCallBack), buffer);
                btnConnectClients.Enabled = false;
                btnConnectClients.Text = @"Connected";

                btnSendMessage.Enabled = true;

                txtMessageWriter.Focus();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                var encoding = new ASCIIEncoding();//todo
                var message = encoding.GetBytes(txtMessageWriter.Text);

                _socket.Send(message);

                lstChatbox.Items.Add("You: " + txtMessageWriter.Text);
                txtMessageWriter.Clear();

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }
    }
}
