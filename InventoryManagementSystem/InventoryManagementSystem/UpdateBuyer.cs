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
    public partial class UpdateBuyer : Form
    {
        public UpdateBuyer()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.UPDATE_BUYER_FORM, this);
        }

        private void UpdateBuyer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideUpdateBuyerForm();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();            
            data.Add(Constants.BUYER_ID, comboBox1.SelectedItem.ToString());
            data.Add(Constants.BUYER_NAME, BuyerName.Text);
            data.Add(Constants.BUYER_EMAIL, BuyerEmail.Text);
            if (Retailer.Checked)
            {
                data.Add(Constants.RETAILER, Retailer.Text);
                data.Add(Constants.WHOLESALLER, Constants.NULL_STRING);
            }
            else
            {
                data.Add(Constants.RETAILER, Constants.NULL_STRING);
                data.Add(Constants.WHOLESALLER, WholeSaller.Text);
            }
            ApplicationManager.updateBuyer(data);
        }

        public void clearAllFields()
        {
            comboBox1.Text = null;
            BuyerName.Text = null;
            Retailer.Checked = false;
            WholeSaller.Checked = false;
            BuyerEmail.Text = null;
        }

        public void setBuyerIDComboBoxValues(List<Dictionary<String, String>> data)
        {
            comboBox1.Items.Clear();
            string buyerID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.BUYER_ID, out buyerID);
                comboBox1.Items.Add(buyerID);
            }
        }
    }
}
