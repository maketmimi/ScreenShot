using System.Drawing;
using System.Windows.Forms;

namespace ScreenShot.GUI
{
    public partial class FrmScreenSelector : Form
    {
        public static Screen SelectScreen()
        {
            FrmScreenSelector screenSelector = new FrmScreenSelector();

            screenSelector.ShowDialog();

            return screenSelector._SelectedScreen;
        }  

        private FrmScreenSelector()
        {
            InitializeComponent();
            _FormScreen = Screen.PrimaryScreen;
            CreateSubScreensFormsIfAny();
        }

        private FrmScreenSelector(FrmScreenSelector ParentSelectorForm, Screen ScreenToShowFormOn)
        {
            InitializeComponent();
            _FormScreen = ScreenToShowFormOn;
            _ParentSelectorForm = ParentSelectorForm;
            _IsSubScreen = true;

            _ParentSelectorForm.FormClosed += _ParentSelectorForm_FormClosed;
        }

        private void _ParentSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void CreateSubScreensFormsIfAny()
        {
            Screen[] AllScreens = Screen.AllScreens;

            if (AllScreens.Length > 1)
            {
                _SubScreensForms = new FrmScreenSelector[AllScreens.Length - 1];

                int SubScreenFormIndex = 0;
                for (int i = 0; i < AllScreens.Length; i++)
                {
                    if (AllScreens[i].Primary) continue;

                    _SubScreensForms[SubScreenFormIndex] = new FrmScreenSelector(this, AllScreens[i]);

                    SubScreenFormIndex++;
                }
            }
            else
            {
                _SubScreensForms = null;
            }
        }

        // Do not use this at all , use the properaty instead
        private Screen _ScreenToShowFormOn = null;
        private Screen _FormScreen
        {
            set
            {
                if (value != null)
                {
                    _ScreenToShowFormOn = value;
                    this.Location = value.Bounds.Location;
                }
            }

            get
            {
                return _ScreenToShowFormOn;
            }
        }

        private Screen _SelectedScreen = null;
        private bool _IsSubScreen = false;
        private FrmScreenSelector[] _SubScreensForms = null;
        private FrmScreenSelector _ParentSelectorForm = null;

        private void FrmScreenSelector_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                if (_IsSubScreen)
                    _ParentSelectorForm.Close();
                else
                    this.Close();

                return;
            }

            if (_IsSubScreen)
            {
                _ParentSelectorForm._SelectedScreen = this._FormScreen;
                _ParentSelectorForm.Close();
            }
            else
            {
                _SelectedScreen = this._FormScreen;
                this.Close();
            }
        }

        private void DisplayAllSubScreens()
        {
            foreach (var subScreen in _SubScreensForms)
            {
                subScreen.Show();
            }
        }

        private void FrmScreenSelector_Load(object sender, System.EventArgs e)
        {
            if (!_IsSubScreen)
                DisplayAllSubScreens();
        }

        private void FrmScreenSelector_MouseEnter(object sender, System.EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void FrmScreenSelector_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
}
