
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
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.speichernButton = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAbteilung = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAufgabenbereich = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.txtBenutzername);
            this.panel1.Controls.Add(this.speichernButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 543);
            this.panel1.TabIndex = 1;
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Location = new System.Drawing.Point(190, 74);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(156, 23);
            this.txtBenutzername.TabIndex = 39;
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(46, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Projekte :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kompetenzen :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 257);
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
            this.label6.Location = new System.Drawing.Point(41, 114);
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
            this.label5.Location = new System.Drawing.Point(41, 164);
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
            this.label4.Location = new System.Drawing.Point(41, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Abteilung :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Benutzername :";
            // 
            // txtAbteilung
            // 
            this.txtAbteilung.Location = new System.Drawing.Point(145, 211);
            this.txtAbteilung.Name = "txtAbteilung";
            this.txtAbteilung.Size = new System.Drawing.Size(186, 23);
            this.txtAbteilung.TabIndex = 40;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(145, 165);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(168, 23);
            this.txtVorname.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 23);
            this.txtName.TabIndex = 42;
            // 
            // txtAufgabenbereich
            // 
            this.txtAufgabenbereich.Location = new System.Drawing.Point(213, 258);
            this.txtAufgabenbereich.Name = "txtAufgabenbereich";
            this.txtAufgabenbereich.Size = new System.Drawing.Size(177, 23);
            this.txtAufgabenbereich.TabIndex = 43;
            // 
            // profileBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBenutzername;
        private FontAwesome.Sharp.IconButton speichernButton;
        public System.Windows.Forms.TextBox txtAufgabenbereich;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtVorname;
        public System.Windows.Forms.TextBox txtAbteilung;
    }
}