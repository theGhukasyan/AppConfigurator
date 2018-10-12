using System.Windows.Forms;

namespace AppConfigurator.Helpers
{
    public class ViewHelper
    {
        public static void SwitchView (Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.Closed += (s, args) => currentForm.Close();
            newForm.Show();
        }

        public static void AddItemToListView(ref ListView listView, string[] item)
        {
            var listViewItem = new ListViewItem(item);
            listView.Items.Add(listViewItem);
        }

        public static bool InvalidPair (string name, string path)
        {
            if (name == "" && path != "")
            {
                MessageBox.Show("Please provide the name", "ERROR",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
