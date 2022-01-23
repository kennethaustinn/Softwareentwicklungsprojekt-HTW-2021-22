
namespace GUI
{
    partial class profileBearbeiten
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
            this.txtAufgabenbereich = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtAbteilung = new System.Windows.Forms.TextBox();
            this.speichernButton = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.txtAufgabenbereich);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtVorname);
            this.panel1.Controls.Add(this.txtAbteilung);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 543);
            this.panel1.TabIndex = 1;
            // 
            // txtAufgabenbereich
            // 
            this.txtAufgabenbereich.Location = new System.Drawing.Point(213, 264);
            this.txtAufgabenbereich.Name = "txtAufgabenbereich";
            this.txtAufgabenbereich.Size = new System.Drawing.Size(177, 23);
            this.txtAufgabenbereich.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(213, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 23);
            this.txtName.TabIndex = 42;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(213, 135);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(177, 23);
            this.txtVorname.TabIndex = 41;
            // 
            // txtAbteilung
            // 
            this.txtAbteilung.Location = new System.Drawing.Point(213, 198);
            this.txtAbteilung.Name = "txtAbteilung";
            this.txtAbteilung.Size = new System.Drawing.Size(177, 23);
            this.txtAbteilung.TabIndex = 40;
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
            this.speichernButton.Location = new System.Drawing.Point(653, 484);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(100, 29);
            this.speichernButton.TabIndex = 38;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.speichernButton.UseVisualStyleBackColor = false;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Aufgabenbereich :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vorname :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Abteilung :";
            // 
            // profileBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(850, 601);
            this.Controls.Add(this.panel1);
            this.Name = "profileBearbeiten";
            this.Text = "profileBearbeiten";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton speichernButton;
        public System.Windows.Forms.TextBox txtAufgabenbereich;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtVorname;
        public System.Windows.Forms.TextBox txtAbteilung;
    }
}