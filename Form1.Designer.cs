namespace TurnOn
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txb_EingestelltServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Starten = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StartTab = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.Status_front = new System.Windows.Forms.ToolStripStatusLabel();
            this.EinstellungTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Hexdata = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_ServerPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.tbx_ServerName = new System.Windows.Forms.TextBox();
            this.Btn_SaveReg = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.StartTab.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.EinstellungTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_EingestelltServer
            // 
            this.txb_EingestelltServer.Location = new System.Drawing.Point(10, 85);
            this.txb_EingestelltServer.Margin = new System.Windows.Forms.Padding(4);
            this.txb_EingestelltServer.Name = "txb_EingestelltServer";
            this.txb_EingestelltServer.ReadOnly = true;
            this.txb_EingestelltServer.Size = new System.Drawing.Size(269, 22);
            this.txb_EingestelltServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eingestellter Server:";
            // 
            // Btn_Starten
            // 
            this.Btn_Starten.AutoSize = true;
            this.Btn_Starten.Location = new System.Drawing.Point(10, 139);
            this.Btn_Starten.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Starten.Name = "Btn_Starten";
            this.Btn_Starten.Size = new System.Drawing.Size(133, 28);
            this.Btn_Starten.TabIndex = 2;
            this.Btn_Starten.Text = "Starten";
            this.Btn_Starten.UseVisualStyleBackColor = true;
            this.Btn_Starten.Click += new System.EventHandler(this.Btn_Starten_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(10, 190);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(133, 28);
            this.btn_shutdown.TabIndex = 3;
            this.btn_shutdown.Text = "Herunterfahren";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.btn_shutdown_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StartTab);
            this.tabControl1.Controls.Add(this.EinstellungTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 321);
            this.tabControl1.TabIndex = 4;
            // 
            // StartTab
            // 
            this.StartTab.Controls.Add(this.statusStrip2);
            this.StartTab.Controls.Add(this.Btn_Starten);
            this.StartTab.Controls.Add(this.label1);
            this.StartTab.Controls.Add(this.btn_shutdown);
            this.StartTab.Controls.Add(this.txb_EingestelltServer);
            this.StartTab.Location = new System.Drawing.Point(4, 25);
            this.StartTab.Name = "StartTab";
            this.StartTab.Padding = new System.Windows.Forms.Padding(3);
            this.StartTab.Size = new System.Drawing.Size(501, 292);
            this.StartTab.TabIndex = 0;
            this.StartTab.Text = "Start";
            this.StartTab.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_front});
            this.statusStrip2.Location = new System.Drawing.Point(3, 267);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(495, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // Status_front
            // 
            this.Status_front.Name = "Status_front";
            this.Status_front.Size = new System.Drawing.Size(480, 17);
            this.Status_front.Spring = true;
            // 
            // EinstellungTab
            // 
            this.EinstellungTab.Controls.Add(this.label5);
            this.EinstellungTab.Controls.Add(this.tbx_Hexdata);
            this.EinstellungTab.Controls.Add(this.statusStrip1);
            this.EinstellungTab.Controls.Add(this.label4);
            this.EinstellungTab.Controls.Add(this.tbx_ServerPW);
            this.EinstellungTab.Controls.Add(this.label3);
            this.EinstellungTab.Controls.Add(this.label2);
            this.EinstellungTab.Controls.Add(this.tbx_UserName);
            this.EinstellungTab.Controls.Add(this.tbx_ServerName);
            this.EinstellungTab.Controls.Add(this.Btn_SaveReg);
            this.EinstellungTab.Location = new System.Drawing.Point(4, 25);
            this.EinstellungTab.Name = "EinstellungTab";
            this.EinstellungTab.Padding = new System.Windows.Forms.Padding(3);
            this.EinstellungTab.Size = new System.Drawing.Size(501, 292);
            this.EinstellungTab.TabIndex = 1;
            this.EinstellungTab.Text = "Einstellung";
            this.EinstellungTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hex Adresse";
            // 
            // tbx_Hexdata
            // 
            this.tbx_Hexdata.Location = new System.Drawing.Point(274, 39);
            this.tbx_Hexdata.Name = "tbx_Hexdata";
            this.tbx_Hexdata.Size = new System.Drawing.Size(190, 22);
            this.tbx_Hexdata.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(495, 22);
            this.statusStrip1.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(480, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server Password";
            // 
            // tbx_ServerPW
            // 
            this.tbx_ServerPW.Location = new System.Drawing.Point(7, 167);
            this.tbx_ServerPW.Name = "tbx_ServerPW";
            this.tbx_ServerPW.Size = new System.Drawing.Size(190, 22);
            this.tbx_ServerPW.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servername";
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Location = new System.Drawing.Point(7, 102);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(190, 22);
            this.tbx_UserName.TabIndex = 4;
            // 
            // tbx_ServerName
            // 
            this.tbx_ServerName.Location = new System.Drawing.Point(7, 39);
            this.tbx_ServerName.Name = "tbx_ServerName";
            this.tbx_ServerName.Size = new System.Drawing.Size(190, 22);
            this.tbx_ServerName.TabIndex = 3;
            // 
            // Btn_SaveReg
            // 
            this.Btn_SaveReg.Location = new System.Drawing.Point(6, 215);
            this.Btn_SaveReg.Name = "Btn_SaveReg";
            this.Btn_SaveReg.Size = new System.Drawing.Size(109, 28);
            this.Btn_SaveReg.TabIndex = 2;
            this.Btn_SaveReg.Text = "Speichern";
            this.Btn_SaveReg.UseVisualStyleBackColor = true;
            this.Btn_SaveReg.Click += new System.EventHandler(this.Btn_SaveReg_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 351);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TurnOn";
            this.tabControl1.ResumeLayout(false);
            this.StartTab.ResumeLayout(false);
            this.StartTab.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.EinstellungTab.ResumeLayout(false);
            this.EinstellungTab.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_EingestelltServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Starten;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StartTab;
        private System.Windows.Forms.TabPage EinstellungTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_ServerPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.TextBox tbx_ServerName;
        private System.Windows.Forms.Button Btn_SaveReg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Hexdata;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel Status_front;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

