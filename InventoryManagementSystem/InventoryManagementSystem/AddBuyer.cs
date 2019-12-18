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
    public partial class AddBuyer : Form
    {
        public AddBuyer()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.ADD_BUYER_FORM, this);
        }

        private void AddBuyer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAddBuyerForm();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.BUYER_ID, BuyerID.Text);
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
            ApplicationManager.addBuyer(data);     
        }

        public void clearAllFields()
        {
            BuyerID.Text = null;
            BuyerName.Text = null;
            Retailer.Checked = false;
            WholeSaller.Checked = false;
            BuyerEmail.Text = null;
        }
    }
}
