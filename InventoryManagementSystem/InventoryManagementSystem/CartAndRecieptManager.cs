using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class CartAndRecieptManager
    {
        private static List<string> listOfBuyerNamesWhoOpenACart = new List<string>();
        private static List<CartForm> listOfCartForms = new List<CartForm>();
        public string getIdForCart()
        {
            string cartID = Constants.NULL_STRING;
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select CartID=max(CartID) from Cart");
            if (result.Count > 0)
                result.ElementAt(0).TryGetValue(Constants.CartID, out cartID);
            int tempCartNumber, cartNumber;
            tempCartNumber = cartNumber = 0;
            if (cartID != Constants.NULL_STRING)
                tempCartNumber = Convert.ToInt32(cartID);
            cartNumber += 1 + tempCartNumber;
            return cartNumber.ToString();
        }

        public bool setDataOnRecieptTable(List<Dictionary<string, string>> data,string soldDate)
        {
            string recieptID, buyerID, merchandiserName;
            recieptID = buyerID = merchandiserName = Constants.NULL_STRING;
            data.ElementAt(0).TryGetValue(Constants.CartID, out recieptID);
            data.ElementAt(0).TryGetValue(Constants.BUYER_NAME, out buyerID);
            data.ElementAt(0).TryGetValue(Constants.MERCHANDISER_ID, out merchandiserName);
            int row=DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert Into Reciept values('"+recieptID+"','"+buyerID+"','"+merchandiserName+"','"+soldDate+"')");
            return row == 1 ? true : false;
        }

        public bool setDataOnRecieptItemsTable(List<Dictionary<string, string>> recieptItemsTableData, List<Dictionary<string, string>> recieptTableData)
        {
            int row = 0;
            string recieptID, itemID, quantity, amount,unitPrice;
            recieptTableData.ElementAt(0).TryGetValue(Constants.CartID,out recieptID);
            itemID = quantity = amount = unitPrice = Constants.NULL_STRING;
            foreach (Dictionary<string, string> dic in recieptItemsTableData)
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
                        row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert Into RecieptItems values('" + recieptID + "','" + itemID + "','" + quantity + "','" + amount + "','" + unitPrice + "')");
                    }
                }
            }
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> FillRecieptObject(string recieptid)
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select * from RecieptItems where RecieptID = '" + recieptid+"'");
            return result;
        }

        public bool saveAUserCartInToCartTable(List<Dictionary<String, String>> result)
        {
            string buyerID, merchandiserID, invoiceNumber,total;
            buyerID = merchandiserID = invoiceNumber=total = Constants.NULL_STRING;
            result.ElementAt(0).TryGetValue(Constants.CartID, out invoiceNumber);
            result.ElementAt(0).TryGetValue(Constants.MERCHANDISER_ID, out merchandiserID);
            result.ElementAt(0).TryGetValue(Constants.BUYER_ID, out buyerID);
            result.ElementAt(0).TryGetValue(Constants.TOTAL_AMOUNT, out total);
            int row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert Into Cart values('" + invoiceNumber + "','" + buyerID + "','" + merchandiserID + "','" + "TRUE" + "','"+total+"')");
            return row == 1 ? true : false;
        }

        public bool addToCartItems(List<Dictionary<String, String>> cartItemsTableData, List<Dictionary<String, String>> cartTableData)
        {
            string cartID, itemID, quantity, unitPrice, amount;
            cartTableData.ElementAt(0).TryGetValue(Constants.CartID,out cartID);
            int row = 0;
            itemID = quantity = unitPrice = amount = Constants.NULL_STRING;
            foreach (Dictionary<string, string> dic in cartItemsTableData)
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
                        row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert Into CartItems values('" + cartID + "','" + itemID + "','" + quantity + "','" + unitPrice + "','" + amount + "')");
                    }
                }
            } 
            return row == 1 ? true : false;
        }

        public string checkBuyerSaveACartOrNot(string buyerID)
        {
            string cardID = Constants.NULL_STRING;
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select CartID from Cart where BuyerID='"+buyerID+"' and CartStatus='TRUE'");
            if(result.Count>0)
                result.ElementAt(0).TryGetValue(Constants.CartID, out cardID);
            return cardID;
        }

        public List<Dictionary<String, String>> getCartData(string cartID)
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select * from CartItems where CartID='"+cartID+"'");
            return result;
        }

        public string getTotalAmountFromCart(string cartID)
        {
            string total = Constants.NULL_STRING;
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select TotalAmount from Cart where CartID='"+cartID+ "' and CartStatus='TRUE'");
            if (result.Count > 0)
                result.ElementAt(0).TryGetValue(Constants.TOTAL_AMOUNT, out total);
            return total;
        }

        public void setCartStatusToFalse(List<Dictionary<String, String>> data)
        {
            string cartId = Constants.NULL_STRING;
            data.ElementAt(0).TryGetValue(Constants.CartID, out cartId);
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select * from Cart Where  CartID='" + cartId + "' ");
            if (result.Count > 0)
            {
                result.ElementAt(0).TryGetValue(Constants.CartID, out cartId);
                DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Cart set CartStatus='False' where CartID='" + cartId + "'");
            }
        }

        public List<Dictionary<String, String>> getReieptItemsData(string recieptID)
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select * from Reciept where RecieptID='" + recieptID + "'");
            return result;
        }

        public string getBuyerID(Dictionary<string,string> data)
        {
            string buyerID;
            data.TryGetValue(Constants.BUYER_ID, out buyerID);
            return buyerID;
        }

        public static string checkBuyerIDExist(string buyerID)
        {
            var match = listOfBuyerNamesWhoOpenACart
           .FirstOrDefault(stringToCheck => stringToCheck.Contains(buyerID));
            return match;
        }

        public static void removeBuyerNameFromBuyerList(string buyerName)
        {
            listOfBuyerNamesWhoOpenACart.Remove(buyerName);
        }

        public static void insertIntoBuyerNamesList(string buyerName)
        {
            listOfBuyerNamesWhoOpenACart.Add(buyerName);
        }

        public static void insertIntoListOfCartForms(CartForm form)
        {
            listOfCartForms.Add(form);
        }

        public static void hideCartForms()
        {
            for (int i = 0; i < listOfCartForms.Count; i++)
                listOfCartForms[i].Hide();
        }

        public string getBuyerIdentity(List<Dictionary<String, String>> data)
        {
            string buyerID=Constants.NULL_STRING,recieptID = Constants.NULL_STRING;
            data.ElementAt(0).TryGetValue(Constants.CartID, out recieptID);
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select BuyerID from Reciept where RecieptID='"+recieptID+"'");
            if(result.Count>0)
                result.ElementAt(0).TryGetValue(Constants.BUYER_ID, out buyerID);
            return buyerID;
        }

        public void fillCartReciept(List<Dictionary<String, String>> data)
        {
            string recieptID = Constants.NULL_STRING;
            data.ElementAt(0).TryGetValue(Constants.CartID, out recieptID);
            List<Dictionary<String, String>> recieptData = FillRecieptObject(recieptID);
            int Total = 0;
            int i = 0;
            string itemid, quantity, unitPrice, amount;
            List<CartReciept> listOFCartReciept = new List<CartReciept>();
            foreach (Dictionary<String, String> valueMap in recieptData)
            {
                valueMap.TryGetValue(Constants.ITEM_ID, out itemid);
                valueMap.TryGetValue(Constants.QUANTITY, out quantity);
                valueMap.TryGetValue(Constants.AMOUNT, out amount);
                valueMap.TryGetValue(Constants.UNIT_PRICE, out unitPrice);
                CartReciept cartReciept = new CartReciept();
                cartReciept.ItemID = (itemid);
                cartReciept.Quantity = (quantity);
                cartReciept.UnitPrice = (unitPrice);
                cartReciept.Amount = (amount);
                Total += Convert.ToInt32(amount);
                listOFCartReciept.Add(cartReciept);
                i++;
            }

            Reciept reciept=setRecieptItemDataOnCrystalFileAndReturnReciept(listOFCartReciept,recieptID,Total);
            exportCrystalFileInTOPdf(reciept,recieptID);
        }

        private Reciept setRecieptItemDataOnCrystalFileAndReturnReciept(List<CartReciept> listOFCartReciept,string recieptID,int Total)
        {
            string recieptId, merchandiserName, buyerID, soldDate;
            List<Dictionary<String, String>> recieptItemsData = getReieptItemsData(recieptID);
            recieptItemsData.ElementAt(0).TryGetValue(Constants.RECIEPT_ID, out recieptId);
            recieptItemsData.ElementAt(0).TryGetValue(Constants.BUYER_ID, out buyerID);
            recieptItemsData.ElementAt(0).TryGetValue(Constants.MERCHANDISER_NAME, out merchandiserName);
            recieptItemsData.ElementAt(0).TryGetValue(Constants.SOLD_DATE, out soldDate);
            Reciept reciept = new InventoryManagementSystem.Reciept();
            reciept.SetDataSource(listOFCartReciept);
            reciept.SetParameterValue(Constants.PCUSTOMERID, buyerID);
            reciept.SetParameterValue(Constants.PMERCHANDISERNAME, merchandiserName);
            reciept.SetParameterValue(Constants.PRECIEPTID, recieptID);
            reciept.SetParameterValue(Constants.PDATE, soldDate);
            reciept.SetParameterValue(Constants.PTOTAL, Total.ToString());
            return reciept;
        }

        private void exportCrystalFileInTOPdf(Reciept reciept,string recieptID)
        {
            string strExportFile = Constants.FILEPATH + recieptID + Constants.PDFEXTENSION;
            reciept.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            reciept.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            DiskFileDestinationOptions objOptions = new DiskFileDestinationOptions();
            objOptions.DiskFileName = strExportFile;
            reciept.ExportOptions.DestinationOptions = objOptions;
            reciept.Export();
            objOptions = null;
            reciept = null;
            MessageBox.Show(Constants.RECIEPTGENERATIONMESSAGE);
        }
    }
}
