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

            if (ResourceHelper.ResourceFileExists("Applications"))
            {
                foreach (var item in ResourceHelper.GetFileNames())
                {
                    var listItem = new ListViewItem(item.Substring(0, item.LastIndexOf(".")));
                    AppList.Items.Add(listItem);
                }
            }

            bool resourceFileexists = System.IO.Directory.Exists(@".\Resources");
            bool applicationResxExists = System.IO.File.Exists(@".\Resources\Applications.resx");

            if (!resourceFileexists)
                System.IO.Directory.CreateDirectory(@".\Resources");

            if (!applicationResxExists)
                System.IO.File.Create(@".\Resources\Applications.resx");

            var resx =
                new System.Resources.ResXResourceReader(@".\Resources\Applications.resx");

           
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ViewHelper.SwitchView(this, new NewAppForm());
        }

      
    }
}
