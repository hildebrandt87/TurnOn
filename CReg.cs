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
        public bool Set_Registry(string Servername, string Username, string Password,string hex)
        {
            try
            {
                Key = Registry.CurrentUser.CreateSubKey("TurnOnSettings");

                //Werte setzen
                Key.SetValue("Servername", Servername);
                Key.SetValue("Username", Username);
                Key.SetValue("Password", Password);
                Key.SetValue("Hex", hex);

            }
            catch (Exception)
            {

                return false;
            }


            Key.Close();
            return true;

        }

        //DIese Methode kann eigentlich gelöscht werden
        public static string[] GetAll_RegistryKeys()
        {
            string[] Daten = new string[3];

            try
            {
                RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
                RegistryKey Key = BaseKey.OpenSubKey("TurnOnSettings");

                //Werte holen
                Daten[0] = Key.GetValue("Servername").ToString();
                Daten[1] = Key.GetValue("Username").ToString();
                Daten[2] = Key.GetValue("Password").ToString();

            }
            catch (Exception)
            {
 
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

    }
}
