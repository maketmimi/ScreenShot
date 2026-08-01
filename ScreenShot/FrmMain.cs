using ScreenShot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private FrmAboutScreen _FrmAbout;

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_FrmAbout == null || _FrmAbout.IsDisposed)
                _FrmAbout = new FrmAboutScreen();

            _FrmAbout.Show();
        }

        private void HideApp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LibMalekGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/maketmimi/PowerWatcher");
            LibMalekGithub.LinkVisited = true;
        }

        private void NifTrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Show();
        }

        private void CmIconTray_Opening(object sender, CancelEventArgs e)
        {
            CShowAppToolStripMenuItem.Enabled = !this.Visible;
            CAlwaysOnTopToolStripMenuItem.Checked = Settings.Default.IsAlwaysOnTop;

        }

        private void alwaysOnTopToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.IsAlwaysOnTop = ((ToolStripMenuItem)sender).Checked;
            Settings.Default.Save();
            this.TopMost = Settings.Default.IsAlwaysOnTop;
        }

        private void settingsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = Settings.Default.IsAlwaysOnTop;
        }

        private void CShowAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
