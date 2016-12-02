using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;


namespace TurnOn
{
    class CNetworkScan
    {
        private int startIP = 0;
        private int endIP = 0;
        private string ipPrefix = "";
        private ArrayList computerList = null;

        public CNetworkScan(string ipPrefix, int startIP, int endIP)
        {
            this.startIP = startIP;
            this.endIP = endIP;
            this.ipPrefix = ipPrefix;
            computerList = new ArrayList();
        }

        public void SearchNetwork(TextBox TxtBox_Ausgabe)
        {

            for (int i = startIP; i <= endIP; i++)
            {
                string scanIP = ipPrefix + "." + i.ToString();
                IPAddress myScanIP = IPAddress.Parse(scanIP);
                IPHostEntry myScanHost = null;
                string[] arr = new string[2];
                try
                {
                    myScanHost = Dns.GetHostByAddress(myScanIP);
                }
                catch
                {
                    continue;
                }
                if (myScanHost != null)
                {
                    arr[0] = myScanHost.HostName;
                    arr[1] = scanIP;
                    computerList.Add(arr);
                    TxtBox_Ausgabe.Text = "Hostname: " +myScanHost.HostName.ToString() + " IP: "+ scanIP.ToString();
                    
                }
  
        }


    }

    }
}
