using System.Drawing;
using System.Windows.Forms;

namespace AppConfigurator.Helpers
{
    public class ViewHelper
    {
        public static void SwitchView(Form currentForm, Form newForm)
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

        public static bool InvalidPair(string name, string path)
        {
            if (name == "" && path != "")
            {
                MessageBox.Show("Please provide the name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public static Label GetLabel(string fieldName, int yPosition)
        {
            return new Label
            {
                Text = fieldName,
                Size = new Size(70, 25),
                Location = new Point(6, yPosition)
            };
        }

        public static TextBox GetTextBox(string fieldName, string fieldValue, int yPosition)
        {
            return new TextBox
            {
                Text = fieldValue,
                Name = fieldName,
                Location = new Point(440, yPosition),
                Size = new Size(320, 20)
            };
        }
    }
}
