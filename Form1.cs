﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Timers;
using System.Net;
using System.Threading;

namespace TurnOn
{
    public partial class Form1 : Form
    {
        public Form MyForm;


        public Form1()
        {

            MyForm = Form1.ActiveForm;
            InitializeComponent();

            //////////////////////////////////////////////////
            ////////////////TIMER////////////////////////////

            System.Timers.Timer aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += aTimer_Elapsed;
            aTimer.Enabled = true;


        }



        async void aTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
          
            try
            {
                
                IPHostEntry hostName = Dns.GetHostByName(CReg.Get_Servername());

                //InvokeRequired dient nur als Abfrage damit der Thread Save ausgeführt werden kann !
                //Sehr wichtig da eigentlich kein fremder thread auf den thread zugreifen kann welcher die steurelemente erstellt hat
                if (InvokeRequired)
                {
                    Invoke((Func<bool>)WriteStatusOnline);
                }
            }
            catch (Exception)
            {
                if (InvokeRequired)
                {
                    //Methoden aufruf mit einem Invoke
                    Invoke((Func<bool>)WriteStatusOffline);
                }
            }



        }

        //Methoden müssen auserhalb deklariert werden da sonst kein thread save aufruf nicht klappt
        bool WriteStatusOnline()
        {
            Status_front.Text = ">> Rechner ist online <<";
            Status_front.BackColor = System.Drawing.Color.Green;
            return true;
        }
        bool WriteStatusOffline()
        {
            Status_front.Text = ">> Rechner ist offline <<";
            Status_front.BackColor = System.Drawing.Color.Red;
            return false;
        }

        private void Btn_Starten_Click(object sender, EventArgs e)
        {
            byte[] macByte;
            byte[] ret = new byte[6];

            //Wenn alles ok ist bitte wieder löschen
            //macStr = "9C-B6-54-A9-DE-FA";


            //Klasseninstanz eröffnen
            CWol Up = new CWol();

            //Hex String umwandeln
            macByte = Up.GetMacArray(CReg.Get_Hex());

            //Übergabe 
            Up.WakeOnLan(macByte);

            //Klasse beenden
            Up = null;

        }


        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            CShutDown End = new CShutDown();
            try
            {
                End.ShutDown(CReg.Get_Servername(), CReg.Get_Username(), CReg.Get_Password());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei Methode: shutdown." + ex.ToString());
            }

            End = null;
        }

        private void Btn_SaveReg_Click(object sender, EventArgs e)
        {
            //Daten aus Textboxen auslesen
            // und in Reg ablegen
            string local_servername = tbx_ServerName.Text.ToString();
            string local_username = tbx_UserName.Text.ToString();
            string local_password = tbx_ServerPW.Text.ToString();
            string local_hex = tbx_Hexdata.Text.ToString();

            
            CReg SaveSettings = new CReg();

            //Prüfen ob Speichern erfolgreich ist
            if (SaveSettings.Set_Registry(local_servername, local_username, local_password, local_hex) == true)
                toolStripStatusLabel1.Text = "Speichern erfolgreich";
            else
                toolStripStatusLabel1.Text = "Beim Speichern ist ein Fehler aufgetreten";

            SaveSettings = null;
        }

        //wird nicht gestartet daher kann diese methode vernachlässigt werden
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_laden_Click(object sender, EventArgs e)
        {
            //Daten aus Reg laden 
            //Eingestellter Server
            txb_EingestelltServer.Text = CReg.Get_Servername();
            tbx_ServerName.Text = CReg.Get_Servername();

            //username einlesen
            tbx_UserName.Text = CReg.Get_Username();

            //Password einlesen
            tbx_ServerPW.Text = CReg.Get_Password();

            //Hex einlesen
            tbx_Hexdata.Text = CReg.Get_Hex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNetworkScan StartScan = new CNetworkScan("192.168.0", 195, 199);
            StartScan.SearchNetwork(this.TxtBox_Output);
            StartScan = null;
        }
    }
}
