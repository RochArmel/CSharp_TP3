using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_App1_Score;
using TP3_App2_DevisPC;

namespace TP3_MainMenu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            frmScore scoreForm = new frmScore();
            scoreForm.Show();
        }

        private void btnDevis_Click(object sender, EventArgs e)
        {
            frmDevisPC devisForm = new frmDevisPC();
            devisForm.Show();
        }
    }
}
