using CrystalDecisions.Shared;
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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.ITEM_ID, itemIDsComboBox.SelectedItem.ToString());
            data.Add(Constants.QUANTITY, numericUpDown1.Value.ToString());
            data.Add(Constants.BUYER_ID, BuyerID.Text);
            ApplicationManager.addToCart(data);
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> recieptTableData = new List<Dictionary<string, string>>();
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1.Add(Constants.CartID, invoiceNumber.Text);
            dict1.Add(Constants.BUYER_NAME, BuyerID.Text);
            dict1.Add(Constants.MERCHANDISER_ID, merchandiserId.Text);
            recieptTableData.Add(dict1);
            List<Dictionary<string, string>> recieptItemsTableData=extractDataFromDataGridView();
            ApplicationManager.checkOut(recieptTableData, recieptItemsTableData);
        }

        private void CartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Dictionary<string, string>> data = setInvoiceNumber();
            ApplicationManager.cancelACart(data);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> data = setInvoiceNumber();
            ApplicationManager.cancelACart(data);
        }

        private List<Dictionary<string, string>> setInvoiceNumber()
        {
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(Constants.CartID, invoiceNumber.Text);
            data.Add(dic);
            return data;
        }

        public void setItemIDComboBoxValues(List<Dictionary<String, String>> data)
        {
            itemIDsComboBox.Items.Clear();
            string itemID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.ITEM_ID, out itemID);
                itemIDsComboBox.Items.Add(itemID);
            }
        }

        public void setInvoiceNumber(string invoiceNumer)
        {
            invoiceNumber.Text = invoiceNumer;
        }

        public void setMerchandiserID(string merchandiserID)
        {
            merchandiserId.Text = merchandiserID;
        }

        public void setBuyerID(string buyerID)
        {
            BuyerID.Text = buyerID;
        }

        public Dictionary<string,string> extractDataAndSetOnCartAndReturnARemainingQuantityOfItem(Dictionary<String, String> data)
        {
            int tempUnitPrice, tempAmount;
            string unitPrice, itemID, quantity, amount, profitPriceOfBuyer, itemOriginalQuantity, cost;
            unitPrice = itemID = quantity = amount = Constants.NULL_STRING;
            data.TryGetValue(Constants.QUANTITY, out quantity);
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            data.TryGetValue(Constants.PROFIT_PRICE_OF_BUYER, out profitPriceOfBuyer);
            data.TryGetValue(Constants.ITEM_ORIGINAL_QUANTITY, out itemOriginalQuantity);
            data.TryGetValue(Constants.COST, out cost);
            tempUnitPrice = Convert.ToInt32(profitPriceOfBuyer) + Convert.ToInt32(cost);
            tempAmount = tempUnitPrice * Convert.ToInt32(quantity);
            unitPrice = tempUnitPrice.ToString();
            amount = tempAmount.ToString();
            int tempQuantity= setDataOnCartAndReturnRemainingQuantityOFCart(itemOriginalQuantity,quantity,itemID,unitPrice,amount);
            data.Clear();
            data.Add(Constants.ITEM_ID,itemID);
            data.Add(Constants.QUANTITY, tempQuantity.ToString());
            return data;
        }

        private int setDataOnCartAndReturnRemainingQuantityOFCart(string itemOriginalQuantity,string quantity,string itemID,string unitPrice,string amount)
        {
            bool Flag = false;
            int tempQuantity = 0,total = 0;
            if (Convert.ToInt32(itemOriginalQuantity) >= Convert.ToInt32(quantity))
            {
                tempQuantity = Convert.ToInt32(itemOriginalQuantity) - Convert.ToInt32(quantity);
                foreach (DataGridViewRow row in displayItemsDataGridView.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == Convert.ToString(itemID))
                    {
                        row.Cells[1].Value = quantity;
                        row.Cells[3].Value = amount;
                        Flag = true;
                    }
                }
                if (!Flag)
                    displayItemsDataGridView.Rows.Add(itemID, quantity, unitPrice, amount);
                foreach (DataGridViewRow row in displayItemsDataGridView.Rows)
                {
                    total += Convert.ToInt32(row.Cells[3].Value);
                }
                totalAmountTxtBox.Text = total.ToString();
            }
            else
                MessageBox.Show(itemID + Constants.DOTEDLINE + Constants.HASCONTAINSTATEMENT + Constants.DOTEDLINE + tempQuantity.ToString() + Constants.DOTEDLINE + Constants.PIECESINSTOCK);
            return tempQuantity;
        }

        public void displayItemsInDataGridView(List<Dictionary<String, String>> data)
        {
            string itemID, quantity, unitPrice, amount;
            itemID = quantity = unitPrice = amount = Constants.NULL_STRING;
            foreach (Dictionary<string, string> dic in data)
            {
                foreach (KeyValuePair<string, string> kvp in dic)
                {
                    if (kvp.Key == Constants.ITEM_ID)
                        itemID = kvp.Value;
                    else if (kvp.Key == Constants.QUANTITY)
                        quantity = kvp.Value;
                    else if (kvp.Key == Constants.UNIT_PRICE)
                        unitPrice = kvp.Value;
                    else if (kvp.Key == Constants.AMOUNT)
                    {
                        amount = kvp.Value;
                        displayItemsDataGridView.Rows.Add(itemID, quantity, unitPrice, amount);
                    }
                }
            }
        }

        public List<Dictionary<String, String>> getCancelDataFromCart()
        {
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            foreach (DataGridViewRow row in displayItemsDataGridView.Rows)
            {
                if (Convert.ToString(row.Cells[0].Value) != Constants.NULL_STRING)
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add(Constants.ITEM_ID, Convert.ToString(row.Cells[0].Value));
                    dic.Add(Constants.QUANTITY, Convert.ToString(row.Cells[1].Value));
                    data.Add(dic);
                }
            }
            return data;
        }

        public void setTotalAmountInCartForm(string total)
        {
            totalAmountTxtBox.Text = total;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> cartTableData = new List<Dictionary<string, string>>();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add(Constants.CartID, invoiceNumber.Text);
            d.Add(Constants.MERCHANDISER_ID, merchandiserId.Text);
            d.Add(Constants.BUYER_ID, BuyerID.Text);
            d.Add(Constants.TOTAL_AMOUNT, totalAmountTxtBox.Text);
            cartTableData.Add(d);
            List<Dictionary<string, string>> cartItemsTableData=extractDataFromDataGridView();
            ApplicationManager.saveUserCartInToDataBase(cartTableData, cartItemsTableData);
        }

        private List<Dictionary<string, string>> extractDataFromDataGridView()
        {
            List<Dictionary<string, string>> data=new List<Dictionary<string, string>>();
            foreach (DataGridViewRow row in displayItemsDataGridView.Rows)
            {
                if (Convert.ToString(row.Cells[0].Value) != Constants.NULL_STRING)
                {
                    Dictionary<string, string>  dict = new Dictionary<string, string>();
                    dict.Add(Constants.ITEM_ID, Convert.ToString(row.Cells[0].Value));
                    dict.Add(Constants.QUANTITY, Convert.ToString(row.Cells[1].Value));
                    dict.Add(Constants.UNIT_PRICE, Convert.ToString(row.Cells[2].Value));
                    dict.Add(Constants.AMOUNT, Convert.ToString(row.Cells[3].Value));
                    data.Add(dict);
                }
            }

            return data;
        }
    }
}

