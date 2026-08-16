using System.Windows.Forms;

namespace ScreenShot
{
    public partial class FrmAboutScreen : Form
    {
        public FrmAboutScreen()
        {
            InitializeComponent();
        }

        private void PbLogo_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/maketmimi/ScreenShot");
        }
    }
}
