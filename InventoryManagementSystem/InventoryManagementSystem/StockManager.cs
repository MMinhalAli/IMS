using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class StockManager
    {
       
        public bool addItemIntoStock(Dictionary<string, string> data)
        {
            int row=0;
            string quantity = Constants.NULL_STRING, itemID = Constants.NULL_STRING;
            data.TryGetValue(Constants.QUANTITY, out quantity);
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            if (quantity != Constants.NULL_STRING && itemID != Constants.NULL_STRING)
                row = row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Stock values('" + itemID + "','" + quantity + "','" + "True" + "')");
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>>  availableStock()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select Item.ItemID,Item.ItemName,Item.Cost,Item.CompanyID,Stock.Quantity from Item Inner Join Stock ON  Item.ItemID=Stock.ItemID and Item.ItemStatus='" + "True" + "'");
            return result;
        }

        public int getQuantityOfSpecificItemID(Dictionary<string,string> data)
        {
            string itemID,quantity;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select ItemID,Quantity From Stock Where itemID='"+itemID+"' and ItemStatus='" + "True" + "'");
            result.ElementAt(0).TryGetValue(Constants.QUANTITY, out quantity);
            return Convert.ToInt32(quantity);
        }

        public bool deleteItemFromStock(Dictionary<string, string> data)
        {
            int row=0;
            string itemID = Constants.NULL_STRING;
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            if (itemID!=Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Stock set ItemStatus='"+"False"+"' where ItemID='"+itemID+"'");
            return row == 1 ? true : false;
        }

        public bool updateStock(Dictionary<string, string> data)
        {
            int row = 0;
            string quantity = Constants.NULL_STRING, itemID = Constants.NULL_STRING;
            data.TryGetValue(Constants.QUANTITY, out quantity);
            data.TryGetValue(Constants.ITEM_ID, out itemID);
            if (quantity != Constants.NULL_STRING && itemID != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Stock set Quantity='" + quantity + "' where ItemID='" + itemID + "'");
            return row == 1 ? true : false;
        }

        public bool updateQunatityInStock(int cancelQuantityFromCart,int remainingQuantity,string itemID)
        {
            int row = 0;
            int totalQuantity = cancelQuantityFromCart + remainingQuantity;
            row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Stock set Quantity='" + totalQuantity.ToString() + "' where ItemID='" + itemID + "'");
            return row == 1 ? true : false;
        }
    }
}
