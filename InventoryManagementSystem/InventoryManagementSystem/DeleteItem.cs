using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.DELETE_ITEM_FORM, this);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.ITEM_ID, comboBox1.SelectedItem.ToString());
            ApplicationManager.deleteItem(data);
        }

        private void DeleteItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideDeleteItemForm();
        }

        private void clearALLfield()
        {
            comboBox1.Items.Clear();
        }

        public void setItemIDComboBoxValues(List<Dictionary<String, String>> data)
        {
            clearALLfield();
            string itemID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.ITEM_ID, out itemID);
                comboBox1.Items.Add(itemID);
            }
        }
    }
}
