
namespace GUI
{
    partial class kompetenzBearbeiten
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.speichernButton = new FontAwesome.Sharp.IconButton();
            this.txtBezeichnung = new System.Windows.Forms.RichTextBox();
            this.txtAlternativeBezeichnung = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKompetenzName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.labelKompetenzName);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Controls.Add(this.txtBezeichnung);
            this.panel1.Controls.Add(this.txtAlternativeBezeichnung);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBeschreibung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 563);
            this.panel1.TabIndex = 2;
            // 
            // speichernButton
            // 
            this.speichernButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speichernButton.BackColor = System.Drawing.Color.Green;
            this.speichernButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speichernButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speichernButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.speichernButton.IconColor = System.Drawing.Color.Black;
            this.speichernButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.speichernButton.IconSize = 20;
            this.speichernButton.Location = new System.Drawing.Point(771, 507);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(99, 29);
            this.speichernButton.TabIndex = 29;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.speichernButton.UseVisualStyleBackColor = false;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Location = new System.Drawing.Point(239, 127);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(318, 29);
            this.txtBezeichnung.TabIndex = 28;
            this.txtBezeichnung.Text = "";
            // 
            // txtAlternativeBezeichnung
            // 
            this.txtAlternativeBezeichnung.Location = new System.Drawing.Point(49, 242);
            this.txtAlternativeBezeichnung.Name = "txtAlternativeBezeichnung";
            this.txtAlternativeBezeichnung.Size = new System.Drawing.Size(843, 71);
            this.txtAlternativeBezeichnung.TabIndex = 26;
            this.txtAlternativeBezeichnung.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Alternative Bezeichnung :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Beschreibung :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kompetenz Name :";
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(49, 398);
            this.txtBeschreibung.Multiline = true;
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(843, 71);
            this.txtBeschreibung.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bezeichnung :";
            // 
            // labelKompetenzName
            // 
            this.labelKompetenzName.AutoSize = true;
            this.labelKompetenzName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKompetenzName.Location = new System.Drawing.Point(273, 50);
            this.labelKompetenzName.Name = "labelKompetenzName";
            this.labelKompetenzName.Size = new System.Drawing.Size(206, 29);
            this.labelKompetenzName.TabIndex = 30;
            this.labelKompetenzName.Text = "Kompetenz Name";
            // 
            // kompetenzBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Name = "kompetenzBearbeiten";
            this.Text = "kompetenzBearbeiten";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton speichernButton;
        public System.Windows.Forms.RichTextBox txtBezeichnung;
        public System.Windows.Forms.RichTextBox txtAlternativeBezeichnung;
        public System.Windows.Forms.TextBox txtBeschreibung;
        public System.Windows.Forms.Label labelKompetenzName;
    }
}