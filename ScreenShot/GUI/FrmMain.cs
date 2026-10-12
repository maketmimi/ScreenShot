using ScreenShot.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.Win32;
using ScreenShot.GUI;

namespace ScreenShot
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private FrmAboutScreen _FrmAbout;
        private readonly string _DefaultScreenShotsSaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

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
            System.Diagnostics.Process.Start("https://github.com/maketmimi");
            LibMalekGithub.LinkVisited = true;
        }

        private void MouseLeftButtonClickedOnIconTray()
        {
            if (FrmScreenSelector.NumberOfCurrentDisplays > 1)
                TakeSingleScreenShot();
            else
                TakeFullScreenShot();
        }

        private void NifTrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MouseLeftButtonClickedOnIconTray();
                    break;
                case MouseButtons.Middle:
                    PasteScreenShot();
                    break;
            }
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

        private void changeSaveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FbdChangeSaveLocation.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.ScreenShotsSaveLocation = FbdChangeSaveLocation.SelectedPath;
                Settings.Default.Save();

                NifNotifications.Visible = true;
                NifNotifications.ShowBalloonTip(10000, "Path Changed", "Screenshots folder path updated successfully.", ToolTipIcon.Info);
            }
        }

        private bool SaveScreenShot(Image ScreenShot)
        {
            if (ScreenShot == null) return false;

            string ScreenShotName =
                    "Screenshot_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";

            string SaveFolderPath = Directory.Exists(Settings.Default.ScreenShotsSaveLocation) ?
                Settings.Default.ScreenShotsSaveLocation :
                _DefaultScreenShotsSaveLocation;

            ScreenShot.Save(Path.Combine(SaveFolderPath, ScreenShotName), ImageFormat.Png);
            return true;
        }

        private void PasteScreenShot()
        {
            NifNotifications.Visible = true;

            if (Clipboard.ContainsImage())
            {
                if (SaveScreenShot(Clipboard.GetImage()))
                    NifNotifications.ShowBalloonTip(10000, "Done", "Screenshot saved successfully.", ToolTipIcon.Info);
            }
            else
            {
                NifNotifications.ShowBalloonTip(10000, "Failed To Paste Screenshot!", "Unable to find screenshot in the clipboard!", ToolTipIcon.Error);
            }
        }

        private void PasteScreenShot_Click(object sender, EventArgs e)
        {
            PasteScreenShot();
        }

        private void NifNotifications_BalloonTipClosed(object sender, EventArgs e)
        {
            NifNotifications.Visible = false;
        }

        private void TakeFullScreenShot()
        {
            TakeScreenShot(SystemInformation.VirtualScreen);
        }

        private void TakeScreenShot(Rectangle ScreenBounds)
        {
            bool ShowForm = this.Visible;
            this.Hide();

            Bitmap Screenshot = new Bitmap(ScreenBounds.Width, ScreenBounds.Height, PixelFormat.Format32bppArgb);
            Graphics gScreenshot = Graphics.FromImage(Screenshot);

            gScreenshot.CopyFromScreen(ScreenBounds.Location, new Point(0, 0), ScreenBounds.Size, CopyPixelOperation.SourceCopy);

            NifNotifications.Visible = true;

            if (SaveScreenShot(Screenshot))
                NifNotifications.ShowBalloonTip(10000, "Done", "The Screenshot has been Taken and saved successfully.", ToolTipIcon.Info);
            else
                NifNotifications.ShowBalloonTip(10000, "Failed To take Screenshot!", "Unable to take screen shot.", ToolTipIcon.Error);

            this.Visible = ShowForm;
        }

        private void TakeScreenshot_Click(object sender, EventArgs e)
        {
            TakeFullScreenShot();
        }

        private void TakeSingleScreenShot()
        {
            Screen ScreenToTakeScreenShotFor = FrmScreenSelector.SelectScreen();

            if (ScreenToTakeScreenShotFor != null)
                TakeScreenShot(ScreenToTakeScreenShotFor.Bounds);
        }

        private void takeSingleScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeSingleScreenShot();
        }
    }
}
