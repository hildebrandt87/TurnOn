using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnOn
{
    class CReg
    {
        RegistryKey Key;

        //Daten in Registry Speichern
        public bool Set_Registry(string Servername, string Username, string Password,string hex,string UserNameLinux,string ServerPWLinux)
        {
            try
            {
                Key = Registry.CurrentUser.CreateSubKey("TurnOnSettings");

                //Werte setzen
                Key.SetValue("Servername", Servername);
                Key.SetValue("Username", Username);
                Key.SetValue("Password", Password);
                Key.SetValue("Hex", hex);

                //set Linux Value
                Key.SetValue("UsernameLinux", UserNameLinux);
                Key.SetValue("ServerPWLinux", ServerPWLinux);

            }
            catch (Exception)
            {

                return false;
            }

            Key.Close();
            return true;

        }
        public static string[] GetAll_RegistryKeys()
        {
            string[] Daten = new string[5];

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                Daten[0] = Key.GetValue("Servername").ToString();
                Daten[1] = Key.GetValue("Username").ToString();
                Daten[2] = Key.GetValue("Password").ToString();
                Daten[3] = Key.GetValue("UsernameLinux").ToString();
                Daten[4] = Key.GetValue("ServerPWLinux").ToString();
          
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            return Daten;
        }

        //Auslesen des Servername
        public static string Get_Servername()
        {
            string name = null;


                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                name = Key.GetValue("Servername").ToString();


            return name;
        }

        //Auslesen des Username
        public static string Get_Username()
        {
            string name = null;

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                name = Key.GetValue("Username").ToString();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return name;
        }

        //Auslesen des Passwords
        public static string Get_Password()
        {
            string name = null;

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                name = Key.GetValue("Password").ToString();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return name;
        }

        //Hex Adresse holen
        public static string Get_Hex()
        {
            string name = null;

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                name = Key.GetValue("Hex").ToString();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return name;
        }

        //Linux Username
        public static string Get_LinuxUsername()
        {
            string name = null;

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                if(Key.GetValue("UsernameLinux")!= null)
                {
                    name = Key.GetValue("UsernameLinux").ToString();
                }
                else
                {
                    name = "";
                }
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return name;
        }

        //Linux Server Passwort
        public static string Get_LinuxServerPW()
        {
            string name = null;

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                if (Key.GetValue("ServerPWLinux") != null)
                {
                    name = Key.GetValue("ServerPWLinux").ToString();
                }
                else
                {
                    name = "";
                }
                //name = Key.GetValue("ServerPWLinux").ToString();s
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return name;
        }

    }
}
