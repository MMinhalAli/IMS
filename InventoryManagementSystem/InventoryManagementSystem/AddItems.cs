using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace InventoryManagementSystem
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.ADD_ITEM_FORM, this);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.ITEM_ID, ItemID.Text);
            data.Add(Constants.ITEM_NAME, ItemName.Text);
            data.Add(Constants.COST, Cost.Text);
            data.Add(Constants.COMPANY_ID, CompanyID.SelectedItem.ToString());
            data.Add(Constants.QUANTITY, Quantity.Text);
            data.Add(Constants.RETAILER_PROFIT_PRICE, RetailerProfitPrice.Text);
            data.Add(Constants.WHOLE_SALLER_PROFIT_PRICE, WholeSallerProfitPrice.Text);
            ApplicationManager.addItem(data);
        }

        private void AddItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAddItemForm();
        }

        public void clearAllTheFields()
        {
            CompanyID.Text = null;
            ItemID.Text = null;
            ItemName.Text = null;
            Cost.Text = null;
            Quantity.Text = null;
            RetailerProfitPrice.Text = null;
            WholeSallerProfitPrice.Text = null;
        }

        public void setCompanyIDComboBoxValues(List<Dictionary<String, String>> data)
        {
            CompanyID.Items.Clear();
            string companyID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.COMPANY_ID, out companyID);
                CompanyID.Items.Add(companyID);
            }
        }

    }
}
