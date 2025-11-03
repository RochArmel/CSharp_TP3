using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_App2_DevisPC
{
    public partial class frmDevisPC : Form
    {
        public frmDevisPC()
        {
            InitializeComponent();
        }

        private void frmDevisPC_Load(object sender, EventArgs e)
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void TxtPrixHT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPrixHT.Text))
            {
                MessageBox.Show("Le prix HT ne peut pas être vide.");
                e.Cancel = true;
                return;
            }

            double prix;
            if (!double.TryParse(TxtPrixHT.Text, out prix) || prix < 500)
            {
                MessageBox.Show("Le prix HT doit être un nombre supérieur ou égal à 500.");
                e.Cancel = true;
            }
        }

        private void TxtTVA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTVA.Text))
            {
                MessageBox.Show("La TVA ne peut pas être vide.");
                e.Cancel = true;
                return;
            }
            double tva;
            if (!double.TryParse(TxtTVA.Text, out tva) || tva < 0 || tva > 22)
            {
                MessageBox.Show("La TVA doit être un nombre entre 0 et 22.");
                e.Cancel = true;
            }
        }

        private void BtnGenerer_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            int x = alea.Next(0, 31); // Génère 0-30
            TxtRemise.Text = x.ToString();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            TxtCode.Text = "";
            TxtTel.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtPrixHT.Text = "0";
            TxtTVA.Text = "0";

            RdEcran17.Checked = true;

            ChkImprimante.Checked = false;
            ChkScanner.Checked = false;
            ChkWebcam.Checked = false;

            CmbMode.SelectedIndex = -1;

            TxtRemise.Text = "0";
            TxtMontantTTC.Text = "0";

            BtnAjout.Enabled = false;

            TxtCode.Focus();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCode.Text) || string.IsNullOrEmpty(TxtNom.Text) || string.IsNullOrEmpty(TxtPrenom.Text))
            {
                MessageBox.Show("Il faut saisir toutes les informations");
                return;
            }

            if (CmbMode.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un mode de payement");
                return;
            }

            double prixHT = double.Parse(TxtPrixHT.Text);
            double tva = double.Parse(TxtTVA.Text);
            double remise = double.Parse(TxtRemise.Text);

            double total = prixHT;
            total += RdEcran17.Checked ? 200 : 310;

            if (ChkImprimante.Checked) total += 120;
            if (ChkScanner.Checked) total += 60;
            if (ChkWebcam.Checked) total += 40;

            double montantTTC = total * (1 + (tva / 100));
            montantTTC -= remise;

            switch (CmbMode.SelectedIndex)
            {
                case 0: // Comptant
                    montantTTC *= 0.95;
                    break;
                case 1: // 6 mois
                    montantTTC *= 1.05;
                    break;
                case 2: // 12 mois
                    montantTTC *= 1.20;
                    break;
                case 3: // 18 mois
                    montantTTC *= 1.40;
                    break;
            }

            TxtMontantTTC.Text = montantTTC.ToString("F2");
            BtnAjout.Enabled = true;
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            LstCode.Items.Add(TxtCode.Text);
            LstNom.Items.Add(TxtNom.Text);
            LstPrenom.Items.Add(TxtPrenom.Text);
            LstMontant.Items.Add(TxtMontantTTC.Text);

            BtnAjout.Enabled = false;
            BtnInit_Click(null, null);
        }
    }
}
