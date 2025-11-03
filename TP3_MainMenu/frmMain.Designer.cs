namespace TP3_MainMenu
{
    partial class frmMain
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
            this.btnScore = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnScore
            //
            this.btnScore.Location = new System.Drawing.Point(50, 50);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(200, 50);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "Calcul de Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            //
            // btnDevis
            //
            this.btnDevis.Location = new System.Drawing.Point(50, 120);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(200, 50);
            this.btnDevis.TabIndex = 1;
            this.btnDevis.Text = "Devis PC";
            this.btnDevis.UseVisualStyleBackColor = true;
            this.btnDevis.Click += new System.EventHandler(this.btnDevis_Click);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.btnScore);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnDevis;
    }
}
