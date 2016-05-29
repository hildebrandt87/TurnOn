using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace TurnOn
{
    class CShutDown
    {
        public void  ShutDown(string Servername,string Username,string Password)
        {
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

    }
}
