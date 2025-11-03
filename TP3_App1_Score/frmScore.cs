using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_App1_Score
{
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            LblDate.Text = "Date : " + DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHeure.Text = "Heure : " + DateTime.Now.ToLongTimeString();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtLang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLang.Text))
            {
                MessageBox.Show("La note de langues ne peut pas être vide.");
                e.Cancel = true;
                return;
            }
            int note;
            if (!int.TryParse(TxtLang.Text, out note) || note < 0 || note > 20)
            {
                MessageBox.Show("La note de langues doit être un nombre entre 0 et 20.");
                e.Cancel = true;
            }
        }

        private void TxtTech_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTech.Text))
            {
                MessageBox.Show("La note technique ne peut pas être vide.");
                e.Cancel = true;
                return;
            }
            int note;
            if (!int.TryParse(TxtTech.Text, out note) || note < 0 || note > 20)
            {
                MessageBox.Show("La note technique doit être un nombre entre 0 et 20.");
                e.Cancel = true;
            }
        }

        private void BtnChance_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            int x = alea.Next(0, 16); // Génère 0-15
            TxtChance.Text = x.ToString();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            TxtCin.Text = "";
            TxtTel.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtLang.Text = "0";
            TxtTech.Text = "0";

            RdMas.Checked = true;
            RdFem.Checked = false;

            ChkExper.Checked = false;
            ChkMotiv.Checked = false;
            ChkDip.Checked = false;

            CmbAge.SelectedIndex = -1;

            TxtChance.Text = "0";
            TxtScore.Text = "0";

            BtnAjout.Enabled = false;

            TxtCin.Focus();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCin.Text) || string.IsNullOrEmpty(TxtNom.Text) || string.IsNullOrEmpty(TxtPrenom.Text) || CmbAge.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut saisir toutes les informations");
                return;
            }

            int note = int.Parse(TxtLang.Text) + int.Parse(TxtTech.Text);

            int sexe = RdMas.Checked ? 7 : 5;

            int bonus = 0;
            if (ChkExper.Checked) bonus += 15;
            if (ChkMotiv.Checked) bonus += 10;
            if (ChkDip.Checked) bonus += 5;

            int age = 0;
            switch (CmbAge.SelectedIndex)
            {
                case 0:
                    age = 20;
                    break;
                case 1:
                    age = 10;
                    break;
                case 2:
                    age = 5;
                    break;
            }

            int chance = int.Parse(TxtChance.Text);

            int score = note + sexe + bonus + age + chance;

            TxtScore.Text = score.ToString();
            BtnAjout.Enabled = true;
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            Lst1.Items.Add(TxtCin.Text);
            Lst2.Items.Add(TxtNom.Text);
            Lst3.Items.Add(TxtPrenom.Text);
            Lst4.Items.Add(TxtScore.Text);

            BtnAjout.Enabled = false;
            BtnInit_Click(null, null);
        }
    }
}
