using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnOn
{
    class CNetworkScan
    {
        public  void SearchOnline(RichTextBox ListComp)
        {
            // Alle PCs im Netzwerk auflisten
            System.DirectoryServices.DirectoryEntry root = new System.DirectoryServices.DirectoryEntry("WinNT:");
            foreach (System.DirectoryServices.DirectoryEntry dDom in root.Children)
            {
                foreach (System.DirectoryServices.DirectoryEntry dPC in dDom.Children)
                {

                    ListComp.Text.Insert(1,dDom.Name + " / " + dPC.Name);

                }
            }
          
        }

        public static void RemoveComp()
        { }

    
    }
}
