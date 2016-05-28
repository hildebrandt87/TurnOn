using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TurnOn
{
    public class CWol
    {
        //*Übergabe des MAC Adresse als byte Array
        public void WakeOnLan(byte[] mac)
        {
            //Test 
            //Gesendet an Broadcast 255.255.255.0  Port:40000
            UdpClient Client = new UdpClient();
            Client.Connect(IPAddress.Broadcast, 40000);

            // nochmals prüfen
            byte[] packet = new byte[17 * 6];

            //byte array füllen
            for (int i = 0; i < 6; i++)
            {
                packet[i] = 0xFF;
            }

            for (int i = 1; i <= 16; i++)
            {
                for (int k = 0; k < 6; k++)
                {
                    packet[i * 6 + k] = mac[k];
                }
            }

            //Senden WOL
            Client.Send(packet, packet.Length);

        }

        public byte[] GetMacArray(string mac)
        {
            if (string.IsNullOrEmpty(mac)) throw new ArgumentNullException("mac");
            byte[] ret = new byte[6];
            try
            {
                string[] tmp = mac.Split(':', '-');
                if (tmp.Length != 6)
                {
                    //tmp = mac.Split('.');
                    if (tmp.Length == 3)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            ret[i * 2] = byte.Parse(tmp[i].Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                            ret[i * 2 + 1] = byte.Parse(tmp[i].Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                        }
                    }
                    else
                        for (int i = 0; i < 12; i += 2)
                            ret[i / 2] = byte.Parse(mac.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                }
                else
                    for (int i = 0; i < 6; i++)
                        ret[i] = byte.Parse(tmp[i], System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                throw new ArgumentException("Argument doesn't have the correct format: " + mac, "mac");
            }
            return ret;
        }


    }
}
