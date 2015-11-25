using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;


namespace UsesLibrary.IpUses
{
    internal class IpUses : IUsesIp
    {



        public string GetIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public bool CompareIp()
        {
            throw new NotImplementedException();
        }

        public String GetNetworkUsage()
        {

            UpdateNetworkInterface();


            return UpdateNetworkInterface();
        }

        int bytesSentSpeed = 0;
        int bytesReceivedSpeed = 0;
        private NetworkInterface[] nicArr;
        private string UpdateNetworkInterface()
        {
            // Grab all local interfaces to this computer
            nicArr = NetworkInterface.GetAllNetworkInterfaces();


            // Grab NetworkInterface object that describes the current interface
            NetworkInterface nic = nicArr[0];

            // Grab the stats for that interface
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            // Calculate the speed of bytes going in and out
            // NOTE: we could use something faster and more reliable than Windows Forms Tiemr

            bytesSentSpeed = (int)(interfaceStats.BytesSent - bytesSentSpeed) / 1024;
            bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - bytesReceivedSpeed) / 1024;

            // Update the labels
            return bytesSentSpeed.ToString() + " KB/s  " + bytesReceivedSpeed.ToString() + " KB/s";

            //lblInterfaceType.Text = nic.NetworkInterfaceType.ToString();
            //lblSpeed.Text = nic.Speed.ToString();
            //lblBytesReceived.Text = interfaceStats.BytesReceived.ToString();
            //lblBytesSent.Text = interfaceStats.BytesSent.ToString();
            //lblUpload.Text = bytesSentSpeed.ToString() + " KB/s";
            //lblDownload.Text = bytesReceivedSpeed.ToString() + " KB/s";

        }

    }
}
