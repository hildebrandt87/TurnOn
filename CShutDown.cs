using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using Renci.SshNet;

namespace TurnOn
{
    class CShutDown
    {
        public void  EndWindows(string Servername,string Username,string Password)
        {
            
            //Milestone: Aktuell lässt sich mit dieser Funktion lediglich WIndows Rechner herunterfahren.
            ManagementScope Scope = null;
            ConnectionOptions ConnOptions = null;
            ObjectQuery ObjQuery = null;
            ManagementObjectSearcher ObjSearcher = null;

            try
            {
                ConnOptions = new ConnectionOptions();
                ConnOptions.Impersonation = ImpersonationLevel.Impersonate;
                ConnOptions.EnablePrivileges = true;

                //Einbau zur abfrage
                ConnOptions.Username = "@"+Servername+ @"\"+ Username;
                ConnOptions.Password = Password;

                //name = txb_EingestelltServer.Text;
                Scope = new ManagementScope(@"\\" + Servername + @"\ROOT\CIMV2", ConnOptions);

                Scope.Connect();

                ObjQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

                ObjSearcher = new ManagementObjectSearcher(Scope, ObjQuery);
                foreach (ManagementObject operatingSystem in ObjSearcher.Get())
                {

                    MessageBox.Show("Caption = " + operatingSystem.GetPropertyValue("Caption"));
                    MessageBox.Show("Version = " + operatingSystem.GetPropertyValue("Version"));

                    //Shutdown
                    ManagementBaseObject outParams = operatingSystem.InvokeMethod("Shutdown", null, null);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void EndLinux(string Servername, string Username, string Password)
        {
            //Achtung: auf omv oder Linux system muss ssh aktiv sein 
            //Benutzername zum Herunterfahren mittels SSH muss root sein !
            //Hier sollte über die GUI nochmals ein neues Feld hinzugefügt werden (Only OMV/Linux)

            using (var client = new SshClient(Servername, Username, Password))
            { 
                client.Connect();
                client.RunCommand("/sbin/shutdown -h now");
                client.Disconnect();
            }
        }

    }
}
