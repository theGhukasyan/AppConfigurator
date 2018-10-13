using System;
using System.Collections.Generic;
using AppConfigurator.Helpers;
using System.Windows.Forms;

namespace AppConfigurator
{
    public partial class NewAppForm : Form
    {
        private Dictionary<string, string> _APIs;
        private Dictionary<string, string> _windowsServices;

        private string _appName;
        private string _appPath;

        public NewAppForm()
        {
            InitializeComponent();

            _APIs = new Dictionary<string, string>();
            _windowsServices = new Dictionary<string, string>();
        }

        private void winServiceAddBtn_Click(object sender, EventArgs e)
        {
            var name = winServiceNameField.Text;
            var path = winServicePathField.Text;

            if (ViewHelper.InvalidPair(name, path))
                return;

            ViewHelper.AddItemToListView(ref winServiceListView, new string[] { name, path });

            _windowsServices.Add(name, path);
        }

        private void apiAddBtn_Click(object sender, EventArgs e)
        {
            var name = apiNameField.Text;
            var path = apiPathField.Text;

            if (ViewHelper.InvalidPair(name, path))
                return;

            ViewHelper.AddItemToListView(ref apiListView, new string[] { name, path });

            _APIs.Add(name, path);
        }

        private void appAddBtn_Click(object sender, EventArgs e)
        {
            var name = appNameField.Text;
            var path = appPathField.Text;

            if (ViewHelper.InvalidPair(name, path))
                return;

            _appName = name;
            _appPath = path;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to save and add this application?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                //Adding Application in Applications List
                ResourceHelper.AddResource("Applications", _appName, _appPath);

                //Adding Windows Services 
                foreach (var winService in _windowsServices)
                {
                    ResourceHelper.AddResource(_appName, winService.Key + "WS", winService.Value);
                }

                //Adding APIs
                foreach (var api in _APIs)
                {
                    ResourceHelper.AddResource(_appName, api.Key, api.Value);
                }

                ViewHelper.SwitchView(this, new MainForm(_appName));
            }
        }
    }
}
