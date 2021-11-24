
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorHauptseite));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.EinstellungenButton = new FontAwesome.Sharp.IconButton();
            this.KompetenzListeButton = new FontAwesome.Sharp.IconButton();
            this.ProjekteListeButton = new FontAwesome.Sharp.IconButton();
            this.MitarbeiterListeButton = new FontAwesome.Sharp.IconButton();
            this.NeueMitarbeiterButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.currentChildFormText = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelSideMenu.Controls.Add(this.EinstellungenButton);
            this.panelSideMenu.Controls.Add(this.KompetenzListeButton);
            this.panelSideMenu.Controls.Add(this.ProjekteListeButton);
            this.panelSideMenu.Controls.Add(this.MitarbeiterListeButton);
            this.panelSideMenu.Controls.Add(this.NeueMitarbeiterButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 584);
            this.panelSideMenu.TabIndex = 0;
            // 
            // EinstellungenButton
            // 
            this.EinstellungenButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EinstellungenButton.FlatAppearance.BorderSize = 0;
            this.EinstellungenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EinstellungenButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EinstellungenButton.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.EinstellungenButton.IconColor = System.Drawing.Color.Black;
            this.EinstellungenButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EinstellungenButton.IconSize = 34;
            this.EinstellungenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EinstellungenButton.Location = new System.Drawing.Point(0, 380);
            this.EinstellungenButton.Name = "EinstellungenButton";
            this.EinstellungenButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EinstellungenButton.Size = new System.Drawing.Size(220, 60);
            this.EinstellungenButton.TabIndex = 5;
            this.EinstellungenButton.Text = "Einstellungen";
            this.EinstellungenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EinstellungenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EinstellungenButton.UseVisualStyleBackColor = true;
            this.EinstellungenButton.Click += new System.EventHandler(this.EinstellungenButton_Click);
            // 
            // KompetenzListeButton
            // 
            this.KompetenzListeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.KompetenzListeButton.FlatAppearance.BorderSize = 0;
            this.KompetenzListeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KompetenzListeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KompetenzListeButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.KompetenzListeButton.IconColor = System.Drawing.Color.Black;
            this.KompetenzListeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KompetenzListeButton.IconSize = 34;
            this.KompetenzListeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KompetenzListeButton.Location = new System.Drawing.Point(0, 320);
            this.KompetenzListeButton.Name = "KompetenzListeButton";
            this.KompetenzListeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.KompetenzListeButton.Size = new System.Drawing.Size(220, 60);
            this.KompetenzListeButton.TabIndex = 4;
            this.KompetenzListeButton.Text = "Kompetenz Liste";
            this.KompetenzListeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KompetenzListeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KompetenzListeButton.UseVisualStyleBackColor = true;
            this.KompetenzListeButton.Click += new System.EventHandler(this.KompetenzListeButton_Click);
            // 
            // ProjekteListeButton
            // 
            this.ProjekteListeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjekteListeButton.FlatAppearance.BorderSize = 0;
            this.ProjekteListeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjekteListeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProjekteListeButton.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ProjekteListeButton.IconColor = System.Drawing.Color.Black;
            this.ProjekteListeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProjekteListeButton.IconSize = 34;
            this.ProjekteListeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProjekteListeButton.Location = new System.Drawing.Point(0, 260);
            this.ProjekteListeButton.Name = "ProjekteListeButton";
            this.ProjekteListeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProjekteListeButton.Size = new System.Drawing.Size(220, 60);
            this.ProjekteListeButton.TabIndex = 3;
            this.ProjekteListeButton.Text = "Projekt Liste";
            this.ProjekteListeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProjekteListeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjekteListeButton.UseVisualStyleBackColor = true;
            this.ProjekteListeButton.Click += new System.EventHandler(this.ProjekteListeButton_Click);
            // 
            // MitarbeiterListeButton
            // 
            this.MitarbeiterListeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MitarbeiterListeButton.FlatAppearance.BorderSize = 0;
            this.MitarbeiterListeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MitarbeiterListeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MitarbeiterListeButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.MitarbeiterListeButton.IconColor = System.Drawing.Color.Black;
            this.MitarbeiterListeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MitarbeiterListeButton.IconSize = 34;
            this.MitarbeiterListeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MitarbeiterListeButton.Location = new System.Drawing.Point(0, 200);
            this.MitarbeiterListeButton.Name = "MitarbeiterListeButton";
            this.MitarbeiterListeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MitarbeiterListeButton.Size = new System.Drawing.Size(220, 60);
            this.MitarbeiterListeButton.TabIndex = 2;
            this.MitarbeiterListeButton.Text = "Mitarbeiter Liste";
            this.MitarbeiterListeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MitarbeiterListeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MitarbeiterListeButton.UseVisualStyleBackColor = true;
            this.MitarbeiterListeButton.Click += new System.EventHandler(this.MitarbeiterListeButton_Click);
            // 
            // NeueMitarbeiterButton
            // 
            this.NeueMitarbeiterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NeueMitarbeiterButton.FlatAppearance.BorderSize = 0;
            this.NeueMitarbeiterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NeueMitarbeiterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NeueMitarbeiterButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.NeueMitarbeiterButton.IconColor = System.Drawing.Color.Black;
            this.NeueMitarbeiterButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NeueMitarbeiterButton.IconSize = 34;
            this.NeueMitarbeiterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NeueMitarbeiterButton.Location = new System.Drawing.Point(0, 140);
            this.NeueMitarbeiterButton.Name = "NeueMitarbeiterButton";
            this.NeueMitarbeiterButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NeueMitarbeiterButton.Size = new System.Drawing.Size(220, 60);
            this.NeueMitarbeiterButton.TabIndex = 1;
            this.NeueMitarbeiterButton.Text = "Neu Mitarbeiter anlegen";
            this.NeueMitarbeiterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NeueMitarbeiterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NeueMitarbeiterButton.UseVisualStyleBackColor = true;
            this.NeueMitarbeiterButton.Click += new System.EventHandler(this.NeueMitarbeiterButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.HomeLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // HomeLogo
            // 
            this.HomeLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeLogo.Image = ((System.Drawing.Image)(resources.GetObject("HomeLogo.Image")));
            this.HomeLogo.Location = new System.Drawing.Point(0, 0);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(220, 140);
            this.HomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeLogo.TabIndex = 0;
            this.HomeLogo.TabStop = false;
            this.HomeLogo.Click += new System.EventHandler(this.HomeLogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.currentChildFormText);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 20);
            this.panel2.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(220, 80);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(866, 504);
            this.panelChildForm.TabIndex = 3;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // currentChildFormText
            // 
            this.currentChildFormText.AutoSize = true;
            this.currentChildFormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentChildFormText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentChildFormText.Location = new System.Drawing.Point(58, 12);
            this.currentChildFormText.Name = "currentChildFormText";
            this.currentChildFormText.Size = new System.Drawing.Size(78, 29);
            this.currentChildFormText.TabIndex = 1;
            this.currentChildFormText.Text = "Home";
            // 
            // AdministratorHauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1086, 584);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "AdministratorHauptseite";
            this.Text = "Kompetenzdatenbank";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton EinstellungenButton;
        private FontAwesome.Sharp.IconButton KompetenzListeButton;
        private FontAwesome.Sharp.IconButton ProjekteListeButton;
        private FontAwesome.Sharp.IconButton MitarbeiterListeButton;
        private FontAwesome.Sharp.IconButton NeueMitarbeiterButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox HomeLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label currentChildFormText;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}