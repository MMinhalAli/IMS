using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class ItemManager
    {
        private static int totalItemCount = 0;
    
        public bool addItem(Dictionary<string, string> data,string merchandiserID,string itemRegistrationTime)
        {
            int row=0;
            string itemID = Constants.NULL_STRING, itemName = Constants.NULL_STRING, cost = Constants.NULL_STRING, companyID = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            data.TryGetValue(Constants.ITEM_NAME, out itemName);
            data.TryGetValue(Constants.COST, out cost);
            data.TryGetValue(Constants.COMPANY_ID, out companyID);
            if (!checkItemIDExist(itemID))
            {
                if (itemID != Constants.NULL_STRING && itemName != Constants.NULL_STRING && cost != Constants.NULL_STRING && companyID != Constants.NULL_STRING)
                {
                    row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Item values('" + itemID + "','" + itemName + "','" + cost + "','" + companyID + "','" + itemRegistrationTime + "','" + merchandiserID + "','" + "True" + "')");
                }
                else
                    MessageBox.Show(Constants.FILL_ALL_FIELDS);
            }
            else
                MessageBox.Show(Constants.ID_EXIST);
            return row == 1 ? true : false;
        }

        public static int gettotalItemCount()
        {
            return totalItemCount;
        }

        public string getProfitPriceOfSpecificBuyerType(Dictionary<string,string> data, string buyerType)
        {
            string itemID,profitPrice = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            List<Dictionary<String, String>> result;
            if (buyerType == Constants.RETAILER)
            {
                result = DataBaseManager.runSelectQuery("Select RetailerProfitPrice From ItemPriceManagementTable where ItemID='" + itemID + "'");
                if (result.Count > 0)
                    result.ElementAt(0).TryGetValue("RetailerProfitPrice", out profitPrice);
            }
            else
            {
                result = DataBaseManager.runSelectQuery("Select WholeSallerProfitPrice From ItemPriceManagementTable where ItemID='" + itemID + "'");
                if (result.Count > 0)
                    result.ElementAt(0).TryGetValue("WholeSallerProfitPrice", out profitPrice);
            }
            return profitPrice;
        }

        public static void settotalItemCount(int count)
        {
            totalItemCount = count;
        }

        public string getCostOfParticularItem(Dictionary<string,string> data)
        {
            string itemID,Cost = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID,out itemID);
            List<Dictionary<String, String>> result;
            result = DataBaseManager.runSelectQuery("Select Cost From Item where ItemID='"+itemID+"'");
            if (result.Count != 0)
                result.ElementAt(0).TryGetValue(Constants.COST, out Cost);
            return Cost;
        }

        private bool checkItemIDExist(string itemID)
        {
            string itemId=Constants.NULL_PASSWORD;
            List<Dictionary<String, String>> result =null ;
            if(itemID!=Constants.NULL_PASSWORD)
                result = DataBaseManager.runSelectQuery("Select ItemID From Item Where ItemID='"+itemID+"'");
            if (result.Count!=0)
                result.ElementAt(0).TryGetValue(Constants.ITEM_ID, out itemId);
            return itemId == itemID ? true : false;
        } 

        public bool updateItem(Dictionary<string, string> data,string merchandiserID,string itemRegistrationTime)
        {
            int row=0;
            string itemID = Constants.NULL_STRING, itemName = Constants.NULL_STRING, cost = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            data.TryGetValue(Constants.ITEM_NAME, out itemName);
            data.TryGetValue(Constants.COST, out cost);
            if (itemName != Constants.NULL_STRING)
               row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Item Set ItemName='" + itemName + "',ItemRegistrationTime='" + itemRegistrationTime + "',MerchandiserID='" + merchandiserID + "' where ItemID='" + itemID + "'");
            if (cost != Constants.NULL_STRING)
               row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Item Set Cost='" + cost + "',ItemRegistrationTime='" + itemRegistrationTime + "',MerchandiserID='" + merchandiserID + "' where ItemID='" + itemID + "'");
            return row==1 ? true : false;
        }

        public bool updateItemPriceManagement(Dictionary<string, string> data)
        {
            int row = 0;
            string itemID = Constants.NULL_STRING,retailerProfitPrice=Constants.NULL_STRING, wholeSallerProfitPrice=Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            data.TryGetValue(Constants.RETAILER_PROFIT_PRICE, out retailerProfitPrice);
            data.TryGetValue(Constants.WHOLE_SALLER_PROFIT_PRICE, out wholeSallerProfitPrice);
            if (retailerProfitPrice != Constants.NULL_STRING)
               row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update ItemPriceManagementTable Set RetailerProfitPrice='" + retailerProfitPrice + "' where ItemID='" + itemID + "'");
            if (wholeSallerProfitPrice != Constants.NULL_STRING)
               row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update ItemPriceManagementTable  Set WholeSallerProfitPrice='" + wholeSallerProfitPrice + "' where ItemID='" + itemID + "'");
            return row == 1 ? true : false;
        }

        public bool deleteItem(Dictionary<string, string> data,string merchandiserID,string itemRegistrationTime)
        {
            int row=0;
            string itemID = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            if (itemID != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Item Set  ItemStatus='"+"False"+"',ItemRegistrationTime='"+itemRegistrationTime+"',MerchandiserID='"+merchandiserID+"'  where ItemID='" + itemID + "'");
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> getItemIDs()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select ItemID from Item where ItemStatus='"+"True"+"'");
            return result;
        }

        public bool setItemPriceManagement(Dictionary<string, string> data)
        {
            int row=0;
            string itemID = Constants.NULL_STRING, retailerProfitPrice = Constants.NULL_STRING, wholeSallerProfitPrice = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            data.TryGetValue(Constants.RETAILER_PROFIT_PRICE, out retailerProfitPrice);
            data.TryGetValue(Constants.WHOLE_SALLER_PROFIT_PRICE, out wholeSallerProfitPrice);
            if (itemID != Constants.NULL_STRING && retailerProfitPrice != Constants.NULL_STRING && wholeSallerProfitPrice != Constants.NULL_STRING )
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into ItemPriceManagementTable values('" + itemID + "','"+retailerProfitPrice+"','"+wholeSallerProfitPrice+"','"+"True"+"')");
            return row == 1 ? true : false;
        }

        public bool deleteItemFromItemPriceManagement(Dictionary<string, string> data)
        {
            int row=0;
            string itemID = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            if (itemID !=Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update ItemPriceManagementTable Set ItemStatus='"+"False"+"' where ItemID='"+itemID+"'");
            return row == 1 ? true : false;
        }

        public int getAndIncrementInItemCount()
        {
            int count = gettotalItemCount();
            count += 1;
            settotalItemCount(count);
            return count;
        }

        public int getAndDecrementInItemCount()
        {
            int count = gettotalItemCount();
            count -=1;
            settotalItemCount(count);
            return count;
        }

        public bool enableOrDIsableShowStockBtn()
        {
            List<Dictionary<String, String>> data = getItemIDs();
            int totalNoOfItems = 0;
            foreach (Dictionary<String, String> entry in data)
            {
                totalNoOfItems += entry.Count;
            }
            ItemManager.settotalItemCount(totalNoOfItems);
            return totalNoOfItems >= 1 ? true : false;
        }
    }
}
