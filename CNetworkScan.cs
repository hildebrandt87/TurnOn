using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;



namespace TurnOn
{
    class CNetworkScan
    {
        private int startIP = 0;
        private int endIP = 0;
        private string ipPrefix = "";
        public ArrayList computerList = null;

        //Getter / Setter
        public int StartIP
        {
            get
            {
                return startIP;
            }

            set
            {
                startIP = value;
            }
        }
        public int EndIP
        {
            get
            {
                return endIP;
            }

            set
            {
                endIP = value;
            }
        }
        public string IpPrefix
        {
            get
            {
                return ipPrefix;
            }

            set
            {
                ipPrefix = value;
            }
        }

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        public CNetworkScan()
        {
        }

        public async Task <bool> SearchNetwork(TextBox TxtBox_Ausgabe, ProgressBar progressNetScan)
        {
            TxtBox_Ausgabe.Clear();
            String Liste ="";
            String MAC="";

            for (int i = startIP; i <= endIP; i++)
            {
                string scanIP = ipPrefix + "." + i.ToString();
                IPAddress myScanIP = IPAddress.Parse(scanIP);
                IPHostEntry myScanHost = null;
                string[] arr = new string[2];
                try
                {
                    myScanHost = await Dns.GetHostEntryAsync(myScanIP);
                }
                catch
                {
                    continue;
                }
                if (myScanHost != null)
                {
                    // Mac adreese ermitteln
                    MAC =  await RequestMACAddress(myScanIP.ToString());

                    Liste = "Hostname: " + myScanHost.HostName.ToString() + " IP: " + scanIP.ToString() +" MAC: "+ MAC+ "\r\n";
                    TxtBox_Ausgabe.AppendText(Liste);
                }
                
            }
            return true;
        }
        private static async Task <string> RequestMACAddress(string IP)
        {
            IPAddress addr = IPAddress.Parse(IP);
            byte[] mac = new byte[6];
            int length = mac.Length;
            SendARP((int)addr.Address, 0, mac, ref length);
            string macAddress = BitConverter.ToString(mac, 0, length);
            return macAddress;
        }


    }


}
