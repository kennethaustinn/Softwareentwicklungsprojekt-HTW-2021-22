
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitarbeiterHauptseite));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.EinstellungenButton = new FontAwesome.Sharp.IconButton();
            this.KompetenzListeButton = new FontAwesome.Sharp.IconButton();
            this.ProjekteListeButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.DownButton = new FontAwesome.Sharp.IconButton();
            this.Username = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.currentChildFormText = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NextProject = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfileButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelSideMenu.Controls.Add(this.LogoutButton);
            this.panelSideMenu.Controls.Add(this.EinstellungenButton);
            this.panelSideMenu.Controls.Add(this.KompetenzListeButton);
            this.panelSideMenu.Controls.Add(this.ProjekteListeButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.MinimumSize = new System.Drawing.Size(0, 720);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 720);
            this.panelSideMenu.TabIndex = 1;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Snow;
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.ForeColor = System.Drawing.Color.Firebrick;
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LogoutButton.IconColor = System.Drawing.Color.Black;
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.IconSize = 34;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(0, 660);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LogoutButton.Size = new System.Drawing.Size(220, 60);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
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
            this.EinstellungenButton.Location = new System.Drawing.Point(0, 260);
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
            this.KompetenzListeButton.Location = new System.Drawing.Point(0, 200);
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
            this.ProjekteListeButton.Location = new System.Drawing.Point(0, 140);
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelTitleBar.Controls.Add(this.iconButton1);
            this.panelTitleBar.Controls.Add(this.iconButton2);
            this.panelTitleBar.Controls.Add(this.iconButton3);
            this.panelTitleBar.Controls.Add(this.DownButton);
            this.panelTitleBar.Controls.Add(this.Username);
            this.panelTitleBar.Controls.Add(this.iconPictureBox1);
            this.panelTitleBar.Controls.Add(this.BtnExit);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.BtnMinimize);
            this.panelTitleBar.Controls.Add(this.currentChildFormText);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(948, 60);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Beige;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(925, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(23, 24);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Beige;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Location = new System.Drawing.Point(896, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(23, 24);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.Beige;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(867, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(23, 24);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DownButton.FlatAppearance.BorderSize = 0;
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.DownButton.IconColor = System.Drawing.Color.Black;
            this.DownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DownButton.IconSize = 25;
            this.DownButton.Location = new System.Drawing.Point(809, 12);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(33, 23);
            this.DownButton.TabIndex = 8;
            this.DownButton.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(728, 12);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(84, 20);
            this.Username.TabIndex = 7;
            this.Username.Text = "Mitarbeiter";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(688, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Beige;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnExit.IconColor = System.Drawing.Color.Black;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 20;
            this.BtnExit.Location = new System.Drawing.Point(1689, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 24);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Beige;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 18;
            this.btnMaximize.Location = new System.Drawing.Point(1660, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 24);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.Beige;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.Black;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.Location = new System.Drawing.Point(1631, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(23, 24);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            // 
            // currentChildFormText
            // 
            this.currentChildFormText.AutoSize = true;
            this.currentChildFormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentChildFormText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentChildFormText.Location = new System.Drawing.Point(58, 12);
            this.currentChildFormText.Name = "currentChildFormText";
            this.currentChildFormText.Size = new System.Drawing.Size(68, 25);
            this.currentChildFormText.TabIndex = 1;
            this.currentChildFormText.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.NextProject);
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 660);
            this.panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(168, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 124);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // NextProject
            // 
            this.NextProject.AutoSize = true;
            this.NextProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextProject.Location = new System.Drawing.Point(33, 135);
            this.NextProject.Name = "NextProject";
            this.NextProject.Size = new System.Drawing.Size(129, 20);
            this.NextProject.TabIndex = 22;
            this.NextProject.Text = "Nächste Projekt :";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Beige;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 71;
            this.iconPictureBox3.Location = new System.Drawing.Point(33, 541);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(81, 71);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(120, 581);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(94, 31);
            this.DateLabel.TabIndex = 20;
            this.DateLabel.Text = "Datum";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(120, 541);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(60, 31);
            this.TimeLabel.TabIndex = 19;
            this.TimeLabel.Text = "Zeit";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Beige;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 175;
            this.iconPictureBox2.Location = new System.Drawing.Point(646, 484);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(289, 175);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 18;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.Controls.Add(this.ProfileButton);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(646, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 337);
            this.panel2.TabIndex = 17;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ProfileButton.IconColor = System.Drawing.Color.Black;
            this.ProfileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProfileButton.Location = new System.Drawing.Point(34, 277);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(132, 37);
            this.ProfileButton.TabIndex = 10;
            this.ProfileButton.Text = "Profil anzeigen";
            this.ProfileButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox2.Location = new System.Drawing.Point(34, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 110);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(555, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Herzlich Wilkommen bei der Kompetenzdatenbank";
            // 
            // MitarbeiterHauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1168, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 720);
            this.Name = "MitarbeiterHauptseite";
            this.Text = "MitarbeiterHauptseite";
            this.Load += new System.EventHandler(this.MitarbeiterHauptseite_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton EinstellungenButton;
        private FontAwesome.Sharp.IconButton KompetenzListeButton;
        private FontAwesome.Sharp.IconButton ProjekteListeButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox HomeLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton DownButton;
        private System.Windows.Forms.Label Username;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.Label currentChildFormText;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label NextProject;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ProfileButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton LogoutButton;
    }
}