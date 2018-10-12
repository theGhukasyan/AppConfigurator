using System;
using AppConfigurator.Helpers;
using System.Windows.Forms;

namespace AppConfigurator
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ViewHelper.SwitchView(this, new NewAppForm());
        }
    }
}
