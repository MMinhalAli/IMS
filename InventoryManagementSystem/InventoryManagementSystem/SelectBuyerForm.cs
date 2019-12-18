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
    public partial class SelectBuyerForm : Form
    {
        public SelectBuyerForm()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.SELECT_BUYER_FORM,this);
        }

        private void openCart_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.BUYER_ID, comboBox1.Text);
            ApplicationManager.showSelectBuyerFormAndSetValuesToCartForm(data);
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

        private void SelectBuyerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideSelectBuyerForm();
        }
    }
}
