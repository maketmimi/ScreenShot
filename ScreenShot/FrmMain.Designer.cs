namespace ScreenShot
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MsrMainMenu = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeFullScreenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteScreenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSaveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTakeScreenShot = new System.Windows.Forms.Button();
            this.BtnPasteScreenShot = new System.Windows.Forms.Button();
            this.BtnHideApp = new System.Windows.Forms.Button();
            this.LibMalekGithub = new System.Windows.Forms.LinkLabel();
            this.ImgMain = new System.Windows.Forms.ImageList(this.components);
            this.NifTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmIconTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CShowAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CTakeScreenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CPasteScreenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CAlwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CChangeSaveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FbdChangeSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.NifNotifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.MsrMainMenu.SuspendLayout();
            this.CmIconTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsrMainMenu
            // 
            this.MsrMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsrMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MsrMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MsrMainMenu.Name = "MsrMainMenu";
            this.MsrMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MsrMainMenu.Size = new System.Drawing.Size(433, 25);
            this.MsrMainMenu.TabIndex = 0;
            this.MsrMainMenu.Text = "Main Menu";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.appToolStripMenuItem.Text = "&App";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hideToolStripMenuItem.Image")));
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.hideToolStripMenuItem.Text = "&Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.HideApp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeFullScreenShotToolStripMenuItem,
            this.pasteScreenShotToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.actionsToolStripMenuItem.Text = "Ac&tions";
            // 
            // takeFullScreenShotToolStripMenuItem
            // 
            this.takeFullScreenShotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeFullScreenShotToolStripMenuItem.Image")));
            this.takeFullScreenShotToolStripMenuItem.Name = "takeFullScreenShotToolStripMenuItem";
            this.takeFullScreenShotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.takeFullScreenShotToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.takeFullScreenShotToolStripMenuItem.Text = "Take &ScreenShot";
            this.takeFullScreenShotToolStripMenuItem.Click += new System.EventHandler(this.TakeScreenshot_Click);
            // 
            // pasteScreenShotToolStripMenuItem
            // 
            this.pasteScreenShotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteScreenShotToolStripMenuItem.Image")));
            this.pasteScreenShotToolStripMenuItem.Name = "pasteScreenShotToolStripMenuItem";
            this.pasteScreenShotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteScreenShotToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.pasteScreenShotToolStripMenuItem.Text = "&Paste ScreenShot";
            this.pasteScreenShotToolStripMenuItem.Click += new System.EventHandler(this.PasteScreenShot_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSaveLocationToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.settingsToolStripMenuItem_DropDownOpening);
            // 
            // changeSaveLocationToolStripMenuItem
            // 
            this.changeSaveLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeSaveLocationToolStripMenuItem.Image")));
            this.changeSaveLocationToolStripMenuItem.Name = "changeSaveLocationToolStripMenuItem";
            this.changeSaveLocationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.changeSaveLocationToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.changeSaveLocationToolStripMenuItem.Text = "Change Save &Location";
            this.changeSaveLocationToolStripMenuItem.Click += new System.EventHandler(this.changeSaveLocationToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On &Top";
            this.alwaysOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutAppToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Enabled = false;
            this.howToUseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("howToUseToolStripMenuItem.Image")));
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.howToUseToolStripMenuItem.Text = "How To &Use";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutAppToolStripMenuItem
            // 
            this.aboutAppToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutAppToolStripMenuItem.Image")));
            this.aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
            this.aboutAppToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutAppToolStripMenuItem.Text = "&About App";
            this.aboutAppToolStripMenuItem.Click += new System.EventHandler(this.aboutAppToolStripMenuItem_Click);
            // 
            // BtnTakeScreenShot
            // 
            this.BtnTakeScreenShot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTakeScreenShot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTakeScreenShot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnTakeScreenShot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnTakeScreenShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTakeScreenShot.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.BtnTakeScreenShot.Location = new System.Drawing.Point(80, 74);
            this.BtnTakeScreenShot.Name = "BtnTakeScreenShot";
            this.BtnTakeScreenShot.Size = new System.Drawing.Size(133, 60);
            this.BtnTakeScreenShot.TabIndex = 1;
            this.BtnTakeScreenShot.Text = "Screen Shot";
            this.BtnTakeScreenShot.UseVisualStyleBackColor = true;
            this.BtnTakeScreenShot.Click += new System.EventHandler(this.TakeScreenshot_Click);
            // 
            // BtnPasteScreenShot
            // 
            this.BtnPasteScreenShot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPasteScreenShot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPasteScreenShot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnPasteScreenShot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPasteScreenShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPasteScreenShot.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.BtnPasteScreenShot.Location = new System.Drawing.Point(219, 74);
            this.BtnPasteScreenShot.Name = "BtnPasteScreenShot";
            this.BtnPasteScreenShot.Size = new System.Drawing.Size(133, 60);
            this.BtnPasteScreenShot.TabIndex = 2;
            this.BtnPasteScreenShot.Text = "Paste Screen";
            this.BtnPasteScreenShot.UseVisualStyleBackColor = true;
            this.BtnPasteScreenShot.Click += new System.EventHandler(this.PasteScreenShot_Click);
            // 
            // BtnHideApp
            // 
            this.BtnHideApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHideApp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHideApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnHideApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHideApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHideApp.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHideApp.Location = new System.Drawing.Point(370, 177);
            this.BtnHideApp.Name = "BtnHideApp";
            this.BtnHideApp.Size = new System.Drawing.Size(57, 26);
            this.BtnHideApp.TabIndex = 3;
            this.BtnHideApp.Text = "Hide";
            this.BtnHideApp.UseVisualStyleBackColor = true;
            this.BtnHideApp.Click += new System.EventHandler(this.HideApp_Click);
            // 
            // LibMalekGithub
            // 
            this.LibMalekGithub.ActiveLinkColor = System.Drawing.Color.Black;
            this.LibMalekGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LibMalekGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibMalekGithub.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMalekGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LibMalekGithub.ImageKey = "MalekAltamimi_Logo.png";
            this.LibMalekGithub.ImageList = this.ImgMain;
            this.LibMalekGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LibMalekGithub.LinkColor = System.Drawing.Color.Black;
            this.LibMalekGithub.Location = new System.Drawing.Point(1, 178);
            this.LibMalekGithub.Name = "LibMalekGithub";
            this.LibMalekGithub.Size = new System.Drawing.Size(252, 27);
            this.LibMalekGithub.TabIndex = 4;
            this.LibMalekGithub.TabStop = true;
            this.LibMalekGithub.Text = "Developed by Malek Altamimi";
            this.LibMalekGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LibMalekGithub.VisitedLinkColor = System.Drawing.Color.Black;
            this.LibMalekGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LibMalekGithub_LinkClicked);
            // 
            // ImgMain
            // 
            this.ImgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgMain.ImageStream")));
            this.ImgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgMain.Images.SetKeyName(0, "MalekAltamimi_Logo.png");
            // 
            // NifTrayIcon
            // 
            this.NifTrayIcon.ContextMenuStrip = this.CmIconTray;
            this.NifTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NifTrayIcon.Icon")));
            this.NifTrayIcon.Text = "ScreenShot";
            this.NifTrayIcon.Visible = true;
            this.NifTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NifTrayIcon_MouseClick);
            // 
            // CmIconTray
            // 
            this.CmIconTray.BackColor = System.Drawing.Color.White;
            this.CmIconTray.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmIconTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CShowAppToolStripMenuItem,
            this.toolStripSeparator3,
            this.CTakeScreenShotToolStripMenuItem,
            this.CPasteScreenShotToolStripMenuItem,
            this.toolStripSeparator4,
            this.CAlwaysOnTopToolStripMenuItem,
            this.CChangeSaveLocationToolStripMenuItem,
            this.toolStripSeparator5,
            this.CExitToolStripMenuItem});
            this.CmIconTray.Name = "CmIconTray";
            this.CmIconTray.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CmIconTray.Size = new System.Drawing.Size(280, 154);
            this.CmIconTray.Opening += new System.ComponentModel.CancelEventHandler(this.CmIconTray_Opening);
            // 
            // CShowAppToolStripMenuItem
            // 
            this.CShowAppToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CShowAppToolStripMenuItem.Image")));
            this.CShowAppToolStripMenuItem.Name = "CShowAppToolStripMenuItem";
            this.CShowAppToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.CShowAppToolStripMenuItem.Text = "Sho&w App";
            this.CShowAppToolStripMenuItem.Click += new System.EventHandler(this.CShowAppToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(276, 6);
            // 
            // CTakeScreenShotToolStripMenuItem
            // 
            this.CTakeScreenShotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CTakeScreenShotToolStripMenuItem.Image")));
            this.CTakeScreenShotToolStripMenuItem.Name = "CTakeScreenShotToolStripMenuItem";
            this.CTakeScreenShotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.CTakeScreenShotToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.CTakeScreenShotToolStripMenuItem.Text = "Take &ScreenShot";
            this.CTakeScreenShotToolStripMenuItem.Click += new System.EventHandler(this.TakeScreenshot_Click);
            // 
            // CPasteScreenShotToolStripMenuItem
            // 
            this.CPasteScreenShotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CPasteScreenShotToolStripMenuItem.Image")));
            this.CPasteScreenShotToolStripMenuItem.Name = "CPasteScreenShotToolStripMenuItem";
            this.CPasteScreenShotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.CPasteScreenShotToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.CPasteScreenShotToolStripMenuItem.Text = "&Paste ScreenShot";
            this.CPasteScreenShotToolStripMenuItem.Click += new System.EventHandler(this.PasteScreenShot_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(276, 6);
            // 
            // CAlwaysOnTopToolStripMenuItem
            // 
            this.CAlwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.CAlwaysOnTopToolStripMenuItem.Name = "CAlwaysOnTopToolStripMenuItem";
            this.CAlwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.CAlwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.CAlwaysOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckedChanged);
            // 
            // CChangeSaveLocationToolStripMenuItem
            // 
            this.CChangeSaveLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CChangeSaveLocationToolStripMenuItem.Image")));
            this.CChangeSaveLocationToolStripMenuItem.Name = "CChangeSaveLocationToolStripMenuItem";
            this.CChangeSaveLocationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.CChangeSaveLocationToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.CChangeSaveLocationToolStripMenuItem.Text = "Change Save &Location";
            this.CChangeSaveLocationToolStripMenuItem.Click += new System.EventHandler(this.changeSaveLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(276, 6);
            // 
            // CExitToolStripMenuItem
            // 
            this.CExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CExitToolStripMenuItem.Image")));
            this.CExitToolStripMenuItem.Name = "CExitToolStripMenuItem";
            this.CExitToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.CExitToolStripMenuItem.Text = "&Exit";
            this.CExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FbdChangeSaveLocation
            // 
            this.FbdChangeSaveLocation.Description = "Choose the folder where the taken screen shots will be saved";
            this.FbdChangeSaveLocation.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // NifNotifications
            // 
            this.NifNotifications.Icon = ((System.Drawing.Icon)(resources.GetObject("NifNotifications.Icon")));
            this.NifNotifications.Text = "ScreenShot";
            this.NifNotifications.BalloonTipClosed += new System.EventHandler(this.NifNotifications_BalloonTipClosed);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 208);
            this.Controls.Add(this.LibMalekGithub);
            this.Controls.Add(this.BtnHideApp);
            this.Controls.Add(this.BtnPasteScreenShot);
            this.Controls.Add(this.BtnTakeScreenShot);
            this.Controls.Add(this.MsrMainMenu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsrMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(346, 172);
            this.Name = "FrmMain";
            this.Text = "ScreenShot";
            this.MsrMainMenu.ResumeLayout(false);
            this.MsrMainMenu.PerformLayout();
            this.CmIconTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsrMainMenu;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeFullScreenShotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteScreenShotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSaveLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutAppToolStripMenuItem;
        private System.Windows.Forms.Button BtnTakeScreenShot;
        private System.Windows.Forms.Button BtnPasteScreenShot;
        private System.Windows.Forms.Button BtnHideApp;
        private System.Windows.Forms.LinkLabel LibMalekGithub;
        private System.Windows.Forms.ImageList ImgMain;
        private System.Windows.Forms.NotifyIcon NifTrayIcon;
        private System.Windows.Forms.ContextMenuStrip CmIconTray;
        private System.Windows.Forms.ToolStripMenuItem CShowAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CTakeScreenShotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CPasteScreenShotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem CChangeSaveLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem CExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CAlwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog FbdChangeSaveLocation;
        private System.Windows.Forms.NotifyIcon NifNotifications;
    }
}

