using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfigurator.Helpers
{
    public class ViewHelper
    {
        public static void CloseView (Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.Closed += (s, args) => currentForm.Close();
            newForm.Show();
        }
    }
}
