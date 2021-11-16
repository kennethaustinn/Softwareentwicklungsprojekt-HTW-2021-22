
namespace GUI
{
    partial class AdministratorHauptseite
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
            this.NeuMitarbeiter = new System.Windows.Forms.Button();
            this.ProjektListe = new System.Windows.Forms.Button();
            this.MitarbeiterListe = new System.Windows.Forms.Button();
            this.KompetenzListe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NeuMitarbeiter
            // 
            this.NeuMitarbeiter.BackColor = System.Drawing.Color.OliveDrab;
            this.NeuMitarbeiter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NeuMitarbeiter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NeuMitarbeiter.Location = new System.Drawing.Point(86, 127);
            this.NeuMitarbeiter.Name = "NeuMitarbeiter";
            this.NeuMitarbeiter.Size = new System.Drawing.Size(274, 40);
            this.NeuMitarbeiter.TabIndex = 0;
            this.NeuMitarbeiter.Text = "Neue Mitarbeiter anlegen";
            this.NeuMitarbeiter.UseVisualStyleBackColor = false;
            // 
            // ProjektListe
            // 
            this.ProjektListe.BackColor = System.Drawing.Color.OliveDrab;
            this.ProjektListe.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjektListe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProjektListe.Location = new System.Drawing.Point(86, 260);
            this.ProjektListe.Name = "ProjektListe";
            this.ProjektListe.Size = new System.Drawing.Size(274, 40);
            this.ProjektListe.TabIndex = 1;
            this.ProjektListe.Text = "Projekt Liste";
            this.ProjektListe.UseVisualStyleBackColor = false;
            // 
            // MitarbeiterListe
            // 
            this.MitarbeiterListe.BackColor = System.Drawing.Color.OliveDrab;
            this.MitarbeiterListe.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MitarbeiterListe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MitarbeiterListe.Location = new System.Drawing.Point(86, 194);
            this.MitarbeiterListe.Name = "MitarbeiterListe";
            this.MitarbeiterListe.Size = new System.Drawing.Size(274, 40);
            this.MitarbeiterListe.TabIndex = 2;
            this.MitarbeiterListe.Text = "Mitarbeiter Liste";
            this.MitarbeiterListe.UseVisualStyleBackColor = false;
            // 
            // KompetenzListe
            // 
            this.KompetenzListe.BackColor = System.Drawing.Color.OliveDrab;
            this.KompetenzListe.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KompetenzListe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KompetenzListe.Location = new System.Drawing.Point(86, 329);
            this.KompetenzListe.Name = "KompetenzListe";
            this.KompetenzListe.Size = new System.Drawing.Size(274, 40);
            this.KompetenzListe.TabIndex = 3;
            this.KompetenzListe.Text = "Kompetenz Liste";
            this.KompetenzListe.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Herzlich Wilkommen <Name>";
            // 
            // Hauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KompetenzListe);
            this.Controls.Add(this.MitarbeiterListe);
            this.Controls.Add(this.ProjektListe);
            this.Controls.Add(this.NeuMitarbeiter);
            this.Name = "Hauptseite";
            this.Text = "Kompetenzdatenbank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NeuMitarbeiter;
        private System.Windows.Forms.Button ProjektListe;
        private System.Windows.Forms.Button MitarbeiterListe;
        private System.Windows.Forms.Button KompetenzListe;
        private System.Windows.Forms.Label label1;
    }
}