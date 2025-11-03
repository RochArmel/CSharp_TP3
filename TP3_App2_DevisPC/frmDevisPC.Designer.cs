namespace TP3_App2_DevisPC
{
    partial class frmDevisPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblHeure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTVA = new System.Windows.Forms.TextBox();
            this.TxtPrixHT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdEcran19 = new System.Windows.Forms.RadioButton();
            this.RdEcran17 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChkWebcam = new System.Windows.Forms.CheckBox();
            this.ChkScanner = new System.Windows.Forms.CheckBox();
            this.ChkImprimante = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRemise = new System.Windows.Forms.TextBox();
            this.BtnGenerer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMontantTTC = new System.Windows.Forms.TextBox();
            this.BtnInit = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LstMontant = new System.Windows.Forms.ListBox();
            this.LstPrenom = new System.Windows.Forms.ListBox();
            this.LstNom = new System.Windows.Forms.ListBox();
            this.LstCode = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            //
            // LblDate
            //
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(12, 9);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 13);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date";
            //
            // LblHeure
            //
            this.LblHeure.AutoSize = true;
            this.LblHeure.Location = new System.Drawing.Point(200, 9);
            this.LblHeure.Name = "LblHeure";
            this.LblHeure.Size = new System.Drawing.Size(36, 13);
            this.LblHeure.TabIndex = 1;
            this.LblHeure.Text = "Heure";
            //
            // timer1
            //
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.TxtPrenom);
            this.groupBox1.Controls.Add(this.TxtNom);
            this.groupBox1.Controls.Add(this.TxtTel);
            this.groupBox1.Controls.Add(this.TxtCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            //
            // TxtPrenom
            //
            this.TxtPrenom.Location = new System.Drawing.Point(90, 115);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(160, 20);
            this.TxtPrenom.TabIndex = 7;
            //
            // TxtNom
            //
            this.TxtNom.Location = new System.Drawing.Point(90, 85);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(160, 20);
            this.TxtNom.TabIndex = 6;
            //
            // TxtTel
            //
            this.TxtTel.Location = new System.Drawing.Point(90, 55);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(160, 20);
            this.TxtTel.TabIndex = 5;
            //
            // TxtCode
            //
            this.TxtCode.Location = new System.Drawing.Point(90, 25);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(160, 20);
            this.TxtCode.TabIndex = 4;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prénom";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tél";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.TxtTVA);
            this.groupBox2.Controls.Add(this.TxtPrixHT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(310, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prix";
            //
            // TxtTVA
            //
            this.TxtTVA.Location = new System.Drawing.Point(100, 55);
            this.TxtTVA.Name = "TxtTVA";
            this.TxtTVA.Size = new System.Drawing.Size(100, 20);
            this.TxtTVA.TabIndex = 3;
            this.TxtTVA.Text = "0";
            this.TxtTVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TxtTVA.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTVA_Validating);
            //
            // TxtPrixHT
            //
            this.TxtPrixHT.Location = new System.Drawing.Point(100, 25);
            this.TxtPrixHT.Name = "TxtPrixHT";
            this.TxtPrixHT.Size = new System.Drawing.Size(100, 20);
            this.TxtPrixHT.TabIndex = 2;
            this.TxtPrixHT.Text = "0";
            this.TxtPrixHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TxtPrixHT.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrixHT_Validating);
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "TVA";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prix HT";
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.RdEcran19);
            this.groupBox3.Controls.Add(this.RdEcran17);
            this.groupBox3.Location = new System.Drawing.Point(310, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ecran";
            //
            // RdEcran19
            //
            this.RdEcran19.AutoSize = true;
            this.RdEcran19.Location = new System.Drawing.Point(18, 45);
            this.RdEcran19.Name = "RdEcran19";
            this.RdEcran19.Size = new System.Drawing.Size(73, 17);
            this.RdEcran19.TabIndex = 1;
            this.RdEcran19.Text = "19 pouces";
            this.RdEcran19.UseVisualStyleBackColor = true;
            //
            // RdEcran17
            //
            this.RdEcran17.AutoSize = true;
            this.RdEcran17.Checked = true;
            this.RdEcran17.Location = new System.Drawing.Point(18, 20);
            this.RdEcran17.Name = "RdEcran17";
            this.RdEcran17.Size = new System.Drawing.Size(73, 17);
            this.RdEcran17.TabIndex = 0;
            this.RdEcran17.TabStop = true;
            this.RdEcran17.Text = "17 pouces";
            this.RdEcran17.UseVisualStyleBackColor = true;
            //
            // groupBox4
            //
            this.groupBox4.Controls.Add(this.ChkWebcam);
            this.groupBox4.Controls.Add(this.ChkScanner);
            this.groupBox4.Controls.Add(this.ChkImprimante);
            this.groupBox4.Location = new System.Drawing.Point(420, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            //
            // ChkWebcam
            //
            this.ChkWebcam.AutoSize = true;
            this.ChkWebcam.Location = new System.Drawing.Point(15, 70);
            this.ChkWebcam.Name = "ChkWebcam";
            this.ChkWebcam.Size = new System.Drawing.Size(69, 17);
            this.ChkWebcam.TabIndex = 2;
            this.ChkWebcam.Text = "Webcam";
            this.ChkWebcam.UseVisualStyleBackColor = true;
            //
            // ChkScanner
            //
            this.ChkScanner.AutoSize = true;
            this.ChkScanner.Location = new System.Drawing.Point(15, 45);
            this.ChkScanner.Name = "ChkScanner";
            this.ChkScanner.Size = new System.Drawing.Size(67, 17);
            this.ChkScanner.TabIndex = 1;
            this.ChkScanner.Text = "Scanner";
            this.ChkScanner.UseVisualStyleBackColor = true;
            //
            // ChkImprimante
            //
            this.ChkImprimante.AutoSize = true;
            this.ChkImprimante.Location = new System.Drawing.Point(15, 20);
            this.ChkImprimante.Name = "ChkImprimante";
            this.ChkImprimante.Size = new System.Drawing.Size(77, 17);
            this.ChkImprimante.TabIndex = 0;
            this.ChkImprimante.Text = "Imprimante";
            this.ChkImprimante.UseVisualStyleBackColor = true;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payement";
            //
            // CmbMode
            //
            this.CmbMode.FormattingEnabled = true;
            this.CmbMode.Items.AddRange(new object[] {
            "Comptant",
            "Sur 6 mois",
            "Sur 12 mois",
            "Sur 18 mois"});
            this.CmbMode.Location = new System.Drawing.Point(75, 207);
            this.CmbMode.Name = "CmbMode";
            this.CmbMode.Size = new System.Drawing.Size(121, 21);
            this.CmbMode.TabIndex = 7;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Remise";
            //
            // TxtRemise
            //
            this.TxtRemise.Location = new System.Drawing.Point(65, 237);
            this.TxtRemise.Name = "TxtRemise";
            this.TxtRemise.ReadOnly = true;
            this.TxtRemise.Size = new System.Drawing.Size(50, 20);
            this.TxtRemise.TabIndex = 9;
            this.TxtRemise.Text = "0";
            //
            // BtnGenerer
            //
            this.BtnGenerer.Location = new System.Drawing.Point(125, 235);
            this.BtnGenerer.Name = "BtnGenerer";
            this.BtnGenerer.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerer.TabIndex = 10;
            this.BtnGenerer.Text = "Générer";
            this.BtnGenerer.UseVisualStyleBackColor = true;
            this.BtnGenerer.Click += new System.EventHandler(this.BtnGenerer_Click);
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Montant TTC";
            //
            // TxtMontantTTC
            //
            this.TxtMontantTTC.Location = new System.Drawing.Point(310, 237);
            this.TxtMontantTTC.Name = "TxtMontantTTC";
            this.TxtMontantTTC.ReadOnly = true;
            this.TxtMontantTTC.Size = new System.Drawing.Size(100, 20);
            this.TxtMontantTTC.TabIndex = 12;
            this.TxtMontantTTC.Text = "0";
            //
            // BtnInit
            //
            this.BtnInit.Location = new System.Drawing.Point(560, 50);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(75, 23);
            this.BtnInit.TabIndex = 13;
            this.BtnInit.Text = "Initialiser";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            //
            // BtnCalc
            //
            this.BtnCalc.Location = new System.Drawing.Point(560, 90);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 14;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            //
            // BtnAjout
            //
            this.BtnAjout.Enabled = false;
            this.BtnAjout.Location = new System.Drawing.Point(560, 130);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(75, 23);
            this.BtnAjout.TabIndex = 15;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            //
            // BtnQuit
            //
            this.BtnQuit.Location = new System.Drawing.Point(560, 170);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 23);
            this.BtnQuit.TabIndex = 16;
            this.BtnQuit.Text = "Quitter";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            //
            // groupBox5
            //
            this.groupBox5.Controls.Add(this.LstMontant);
            this.groupBox5.Controls.Add(this.LstPrenom);
            this.groupBox5.Controls.Add(this.LstNom);
            this.groupBox5.Controls.Add(this.LstCode);
            this.groupBox5.Location = new System.Drawing.Point(15, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 150);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste des devis";
            //
            // LstMontant
            //
            this.LstMontant.FormattingEnabled = true;
            this.LstMontant.Location = new System.Drawing.Point(460, 20);
            this.LstMontant.Name = "LstMontant";
            this.LstMontant.Size = new System.Drawing.Size(140, 121);
            this.LstMontant.TabIndex = 3;
            //
            // LstPrenom
            //
            this.LstPrenom.FormattingEnabled = true;
            this.LstPrenom.Location = new System.Drawing.Point(310, 20);
            this.LstPrenom.Name = "LstPrenom";
            this.LstPrenom.Size = new System.Drawing.Size(140, 121);
            this.LstPrenom.TabIndex = 2;
            //
            // LstNom
            //
            this.LstNom.FormattingEnabled = true;
            this.LstNom.Location = new System.Drawing.Point(160, 20);
            this.LstNom.Name = "LstNom";
            this.LstNom.Size = new System.Drawing.Size(140, 121);
            this.LstNom.TabIndex = 1;
            //
            // LstCode
            //
            this.LstCode.FormattingEnabled = true;
            this.LstCode.Location = new System.Drawing.Point(10, 20);
            this.LstCode.Name = "LstCode";
            this.LstCode.Size = new System.Drawing.Size(140, 121);
            this.LstCode.TabIndex = 0;
            //
            // frmDevisPC
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnInit);
            this.Controls.Add(this.TxtMontantTTC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnGenerer);
            this.Controls.Add(this.TxtRemise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbMode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblHeure);
            this.Controls.Add(this.LblDate);
            this.Name = "frmDevisPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devis PC";
            this.Load += new System.EventHandler(this.frmDevisPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHeure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTVA;
        private System.Windows.Forms.TextBox TxtPrixHT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdEcran19;
        private System.Windows.Forms.RadioButton RdEcran17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ChkWebcam;
        private System.Windows.Forms.CheckBox ChkScanner;
        private System.Windows.Forms.CheckBox ChkImprimante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRemise;
        private System.Windows.Forms.Button BtnGenerer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMontantTTC;
        private System.Windows.Forms.Button BtnInit;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox LstMontant;
        private System.Windows.Forms.ListBox LstPrenom;
        private System.Windows.Forms.ListBox LstNom;
        private System.Windows.Forms.ListBox LstCode;
    }
}
