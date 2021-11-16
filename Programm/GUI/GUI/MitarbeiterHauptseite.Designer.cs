
namespace GUI
{
    partial class MitarbeiterHauptseite
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
            this.ProjektListe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KompetenzListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjektListe
            // 
            this.ProjektListe.BackColor = System.Drawing.Color.OliveDrab;
            this.ProjektListe.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjektListe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProjektListe.Location = new System.Drawing.Point(86, 179);
            this.ProjektListe.Name = "ProjektListe";
            this.ProjektListe.Size = new System.Drawing.Size(274, 40);
            this.ProjektListe.TabIndex = 6;
            this.ProjektListe.Text = "Projekt Liste";
            this.ProjektListe.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Herzlich Wilkommen <Name>";
            // 
            // KompetenzListe
            // 
            this.KompetenzListe.BackColor = System.Drawing.Color.OliveDrab;
            this.KompetenzListe.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KompetenzListe.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KompetenzListe.Location = new System.Drawing.Point(86, 246);
            this.KompetenzListe.Name = "KompetenzListe";
            this.KompetenzListe.Size = new System.Drawing.Size(274, 40);
            this.KompetenzListe.TabIndex = 8;
            this.KompetenzListe.Text = "Kompetenz Liste";
            this.KompetenzListe.UseVisualStyleBackColor = false;
            // 
            // MitarbeiterHauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KompetenzListe);
            this.Controls.Add(this.ProjektListe);
            this.Name = "MitarbeiterHauptseite";
            this.Text = "MitarbeiterHauptseite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProjektListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KompetenzListe;
    }
}