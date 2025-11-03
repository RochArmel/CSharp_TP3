namespace TP3_App1_Score
{
    partial class frmScore
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
            this.TxtCin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTech = new System.Windows.Forms.TextBox();
            this.TxtLang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdFem = new System.Windows.Forms.RadioButton();
            this.RdMas = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChkDip = new System.Windows.Forms.CheckBox();
            this.ChkMotiv = new System.Windows.Forms.CheckBox();
            this.ChkExper = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbAge = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtChance = new System.Windows.Forms.TextBox();
            this.BtnChance = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.BtnInit = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Lst4 = new System.Windows.Forms.ListBox();
            this.Lst3 = new System.Windows.Forms.ListBox();
            this.Lst2 = new System.Windows.Forms.ListBox();
            this.Lst1 = new System.Windows.Forms.ListBox();
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
            this.groupBox1.Controls.Add(this.TxtCin);
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
            // TxtCin
            //
            this.TxtCin.Location = new System.Drawing.Point(90, 25);
            this.TxtCin.MaxLength = 8;
            this.TxtCin.Name = "TxtCin";
            this.TxtCin.Size = new System.Drawing.Size(160, 20);
            this.TxtCin.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN";
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.TxtTech);
            this.groupBox2.Controls.Add(this.TxtLang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(310, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes";
            //
            // TxtTech
            //
            this.TxtTech.Location = new System.Drawing.Point(100, 55);
            this.TxtTech.Name = "TxtTech";
            this.TxtTech.Size = new System.Drawing.Size(100, 20);
            this.TxtTech.TabIndex = 3;
            this.TxtTech.Text = "0";
            this.TxtTech.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TxtTech.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTech_Validating);
            //
            // TxtLang
            //
            this.TxtLang.Location = new System.Drawing.Point(100, 25);
            this.TxtLang.Name = "TxtLang";
            this.TxtLang.Size = new System.Drawing.Size(100, 20);
            this.TxtLang.TabIndex = 2;
            this.TxtLang.Text = "0";
            this.TxtLang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TxtLang.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLang_Validating);
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Note Technique";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Note Langues";
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.RdFem);
            this.groupBox3.Controls.Add(this.RdMas);
            this.groupBox3.Location = new System.Drawing.Point(310, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexe";
            //
            // RdFem
            //
            this.RdFem.AutoSize = true;
            this.RdFem.Location = new System.Drawing.Point(18, 45);
            this.RdFem.Name = "RdFem";
            this.RdFem.Size = new System.Drawing.Size(61, 17);
            this.RdFem.TabIndex = 1;
            this.RdFem.Text = "Féminin";
            this.RdFem.UseVisualStyleBackColor = true;
            //
            // RdMas
            //
            this.RdMas.AutoSize = true;
            this.RdMas.Checked = true;
            this.RdMas.Location = new System.Drawing.Point(18, 20);
            this.RdMas.Name = "RdMas";
            this.RdMas.Size = new System.Drawing.Size(67, 17);
            this.RdMas.TabIndex = 0;
            this.RdMas.TabStop = true;
            this.RdMas.Text = "Masculin";
            this.RdMas.UseVisualStyleBackColor = true;
            //
            // groupBox4
            //
            this.groupBox4.Controls.Add(this.ChkDip);
            this.groupBox4.Controls.Add(this.ChkMotiv);
            this.groupBox4.Controls.Add(this.ChkExper);
            this.groupBox4.Location = new System.Drawing.Point(420, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bonus";
            //
            // ChkDip
            //
            this.ChkDip.AutoSize = true;
            this.ChkDip.Location = new System.Drawing.Point(15, 70);
            this.ChkDip.Name = "ChkDip";
            this.ChkDip.Size = new System.Drawing.Size(67, 17);
            this.ChkDip.TabIndex = 2;
            this.ChkDip.Text = "Diplomes";
            this.ChkDip.UseVisualStyleBackColor = true;
            //
            // ChkMotiv
            //
            this.ChkMotiv.AutoSize = true;
            this.ChkMotiv.Location = new System.Drawing.Point(15, 45);
            this.ChkMotiv.Name = "ChkMotiv";
            this.ChkMotiv.Size = new System.Drawing.Size(80, 17);
            this.ChkMotiv.TabIndex = 1;
            this.ChkMotiv.Text = "Motivations";
            this.ChkMotiv.UseVisualStyleBackColor = true;
            //
            // ChkExper
            //
            this.ChkExper.AutoSize = true;
            this.ChkExper.Location = new System.Drawing.Point(15, 20);
            this.ChkExper.Name = "ChkExper";
            this.ChkExper.Size = new System.Drawing.Size(154, 17);
            this.ChkExper.TabIndex = 0;
            this.ChkExper.Text = "Experience Professionnelle";
            this.ChkExper.UseVisualStyleBackColor = true;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Age";
            //
            // CmbAge
            //
            this.CmbAge.FormattingEnabled = true;
            this.CmbAge.Items.AddRange(new object[] {
            "20-30",
            "30-40",
            "40 et plus"});
            this.CmbAge.Location = new System.Drawing.Point(50, 207);
            this.CmbAge.Name = "CmbAge";
            this.CmbAge.Size = new System.Drawing.Size(121, 21);
            this.CmbAge.TabIndex = 7;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Chance";
            //
            // TxtChance
            //
            this.TxtChance.Location = new System.Drawing.Point(65, 237);
            this.TxtChance.Name = "TxtChance";
            this.TxtChance.ReadOnly = true;
            this.TxtChance.Size = new System.Drawing.Size(50, 20);
            this.TxtChance.TabIndex = 9;
            this.TxtChance.Text = "0";
            //
            // BtnChance
            //
            this.BtnChance.Location = new System.Drawing.Point(125, 235);
            this.BtnChance.Name = "BtnChance";
            this.BtnChance.Size = new System.Drawing.Size(75, 23);
            this.BtnChance.TabIndex = 10;
            this.BtnChance.Text = "Générer";
            this.BtnChance.UseVisualStyleBackColor = true;
            this.BtnChance.Click += new System.EventHandler(this.BtnChance_Click);
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Score";
            //
            // TxtScore
            //
            this.TxtScore.Location = new System.Drawing.Point(275, 237);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.ReadOnly = true;
            this.TxtScore.Size = new System.Drawing.Size(50, 20);
            this.TxtScore.TabIndex = 12;
            this.TxtScore.Text = "0";
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
            this.groupBox5.Controls.Add(this.Lst4);
            this.groupBox5.Controls.Add(this.Lst3);
            this.groupBox5.Controls.Add(this.Lst2);
            this.groupBox5.Controls.Add(this.Lst1);
            this.groupBox5.Location = new System.Drawing.Point(15, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 150);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste de personnes";
            //
            // Lst4
            //
            this.Lst4.FormattingEnabled = true;
            this.Lst4.Location = new System.Drawing.Point(460, 20);
            this.Lst4.Name = "Lst4";
            this.Lst4.Size = new System.Drawing.Size(140, 121);
            this.Lst4.TabIndex = 3;
            //
            // Lst3
            //
            this.Lst3.FormattingEnabled = true;
            this.Lst3.Location = new System.Drawing.Point(310, 20);
            this.Lst3.Name = "Lst3";
            this.Lst3.Size = new System.Drawing.Size(140, 121);
            this.Lst3.TabIndex = 2;
            //
            // Lst2
            //
            this.Lst2.FormattingEnabled = true;
            this.Lst2.Location = new System.Drawing.Point(160, 20);
            this.Lst2.Name = "Lst2";
            this.Lst2.Size = new System.Drawing.Size(140, 121);
            this.Lst2.TabIndex = 1;
            //
            // Lst1
            //
            this.Lst1.FormattingEnabled = true;
            this.Lst1.Location = new System.Drawing.Point(10, 20);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(140, 121);
            this.Lst1.TabIndex = 0;
            //
            // frmScore
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnInit);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnChance);
            this.Controls.Add(this.TxtChance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblHeure);
            this.Controls.Add(this.LblDate);
            this.Name = "frmScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul de score";
            this.Load += new System.EventHandler(this.frmScore_Load);
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
        private System.Windows.Forms.TextBox TxtCin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTech;
        private System.Windows.Forms.TextBox TxtLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdFem;
        private System.Windows.Forms.RadioButton RdMas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ChkDip;
        private System.Windows.Forms.CheckBox ChkMotiv;
        private System.Windows.Forms.CheckBox ChkExper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtChance;
        private System.Windows.Forms.Button BtnChance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Button BtnInit;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Lst4;
        private System.Windows.Forms.ListBox Lst3;
        private System.Windows.Forms.ListBox Lst2;
        private System.Windows.Forms.ListBox Lst1;
    }
}
