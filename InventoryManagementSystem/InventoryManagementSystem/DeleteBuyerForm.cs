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
    public partial class DeleteBuyerForm : Form
    {
        public DeleteBuyerForm()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.DELETE_BUYER_FORM,this);
        }

        private void DeleteBuyerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideDeleteBuyerForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.BUYER_ID, comboBox1.SelectedItem.ToString());
            ApplicationManager.deleteBuyer(data);
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
