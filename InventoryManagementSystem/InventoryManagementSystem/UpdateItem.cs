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
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.UPDATE_ITEM_FORM,this);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.ITEM_NAME, ItemName.Text);
            data.Add(Constants.COST, Cost.Text);
            data.Add(Constants.ITEM_ID, comboBox1.SelectedItem.ToString());
            data.Add(Constants.QUANTITY, Quantity.Text);
            data.Add(Constants.RETAILER_PROFIT_PRICE, retailer.Text);
            data.Add(Constants.WHOLE_SALLER_PROFIT_PRICE, wholeSaller.Text);
            ApplicationManager.updateItem(data);
        }

        private void UpdateItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideUpdateItemForm();
        }

        public void clearAllFields()
        {
            ItemName.Text = null;
            comboBox1.Text = null;
            Cost.Text = null;
            Quantity.Text =null;
            retailer.Text = null;
            wholeSaller.Text = null;
        }

        public void setItemIDComboBoxValues(List<Dictionary<String, String>> data)
        {
            comboBox1.Items.Clear();
            string itemID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.ITEM_ID, out itemID);
                comboBox1.Items.Add(itemID);
            }
        }

    }
}
