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
    public partial class InventoryStore : Form
    {
        public InventoryStore()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.INVENTORYSTORE_FORM, this);
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            ApplicationManager.showAddItemFormAndSetValuesToAddItemComboBox();
        }

        private void AvaliableStockBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showStock();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showDeleteItemFormAndSetValuesToDeleteItemComboBox();
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showUpdateItemFormAndSetValuesToUpdateItemComboBox();
        }

        private void AddCompanyBtn_Click(object sender, EventArgs e)
        {
            ApplicationManager.showAddCompanyForm();
        }

        private void UpdateCompany_Click(object sender, EventArgs e)
        {
            ApplicationManager.showUpdateCompanyFormAndSetValuesToUpdateCompanyComboBox();
        }

        private void DeleteCompany_Click(object sender, EventArgs e)
        {
            ApplicationManager.showDeleteCompanyFormAndSetValuesToDeleteCompanyComboBox();
        }

        private void AddBuyer_Click(object sender, EventArgs e)
        {
            ApplicationManager.showAddBuyerForm();
        }

        private void UpdateBuyer_Click(object sender, EventArgs e)
        {
            ApplicationManager.showUpdateBuyerFormAndSetValuesToUpdateBuyerComboBox();
        }

        private void DeleteBuyer_Click(object sender, EventArgs e)
        {
            ApplicationManager.showDeleteBuyerFormAndSetValuesToDeleteBuyerComboBox();
        }

        public void enableOrDisableShowStockBtn(bool enable)
        {
              AvaliableStock.Enabled = enable;
        }

        public void enableOrDisableBtnShowProviderBtn(bool enable)
        {
            showProviderInfo.Enabled = enable;
        }

        public void enableOrDisableBtnShowBuyerBtn(bool enable)
        {
            showBuyerINfo.Enabled = enable;
        }

        private void showProviderInfo_Click(object sender, EventArgs e)
        {
            ApplicationManager.showProviders();
        }

        private void showBuyerINfo_Click(object sender, EventArgs e)
        {
            ApplicationManager.showBuyers();
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells[4].Value) == Convert.ToString(0))
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Red;
                else if (row.Cells[4].Value == null)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                else
                    row.Cells[4].Style.BackColor = System.Drawing.Color.GreenYellow;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            ApplicationManager.hideAllFormAndShowSignInForm();
        }

        private void ShowCart_Click(object sender, EventArgs e)
        {
            ApplicationManager.showSelectBuyerFormAndSetValuesToCartForm();
        }

        private void InventoryStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAllFormAndShowSignInForm();
        }

        public void displayStockInDataGridViewOne(List<Dictionary<String, String>> data)
        {
            dataGridView1.Rows.Clear();
            string tempItemId = Constants.NULL_STRING;
            string tempItemName = Constants.NULL_STRING;
            string tempItemPrice = Constants.NULL_STRING;
            string tempCompanyId = Constants.NULL_STRING;
            string tempQuantity = Constants.NULL_STRING;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.ITEM_ID, out tempItemId);
                valueMap.TryGetValue(Constants.ITEM_NAME, out tempItemName);
                valueMap.TryGetValue(Constants.COST, out tempItemPrice);
                valueMap.TryGetValue(Constants.COMPANY_ID, out tempCompanyId);
                valueMap.TryGetValue(Constants.QUANTITY, out tempQuantity);
                string[] tempRow = { tempItemId, tempItemName, tempItemPrice, tempCompanyId, tempQuantity };
                dataGridView1.Rows.Add(tempRow);
            }
        }

        public void displayStockInDataGridViewTwo(List<Dictionary<String, String>> data)
        {
            dataGridView2.Rows.Clear();
            string tempCompanyId = Constants.NULL_STRING;
            string tempCompanyName = Constants.NULL_STRING;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.COMPANY_ID, out tempCompanyId);
                valueMap.TryGetValue(Constants.COMPANY_NAME, out tempCompanyName);
                string[] tempRow = { tempCompanyId, tempCompanyName };
                dataGridView2.Rows.Add(tempRow);
            }
        }

        public void displayStockInDataGridViewThree(List<Dictionary<String, String>> data)
        {
            dataGridView3.Rows.Clear();
            string tempBuyerId = Constants.NULL_STRING;
            string tempBuyerName = Constants.NULL_STRING;
            string tempBuyerType = Constants.NULL_STRING;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.BUYER_ID, out tempBuyerId);
                valueMap.TryGetValue(Constants.BUYER_NAME, out tempBuyerName);
                valueMap.TryGetValue(Constants.BUYER_TYPE, out tempBuyerType);
                string[] tempRow = { tempBuyerId, tempBuyerName, tempBuyerType };
                dataGridView3.Rows.Add(tempRow);
            }
        }
    }
}
