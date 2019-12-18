using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class BuyerManager
    {
        private static int count;

        public static int getCount()
        {
            return count;
        }

        public static void setCount(int val)
        {
            count = val;
        }

        private string getBuyerType(string buyerID)
        {
            string buyerType = Constants.NULL_STRING;
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select BuyerType From Buyer where BuyerID='" + buyerID + "'");
            if (result.Count > 0)
                result.ElementAt(0).TryGetValue(Constants.BUYER_TYPE, out buyerType);
            return buyerType;
        }

        public bool addBuyer(Dictionary<string, string> data,string merchandiserID,string buyerRegistrationTime)
        {
            string buyerID = Constants.NULL_STRING, buyerName = Constants.NULL_STRING, retailer = Constants.NULL_STRING, wholeSaller = Constants.NULL_STRING, buyerEmail = Constants.NULL_STRING;
            int row = 0;
            data.TryGetValue(Constants.BUYER_ID, out buyerID);
            data.TryGetValue(Constants.BUYER_NAME, out buyerName);
            data.TryGetValue(Constants.RETAILER, out retailer);
            data.TryGetValue(Constants.WHOLESALLER, out wholeSaller);
            data.TryGetValue(Constants.BUYER_EMAIL, out buyerEmail);
            if (!checkBuyerIDExist(buyerID))
            {
                
                if (retailer != Constants.NULL_STRING)
                    row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Buyer values('" + buyerID + "','" + buyerName + "','" + retailer + "','" + merchandiserID + "','" + "True" + "','" + buyerRegistrationTime + "','" + buyerEmail + "')");
                else if (wholeSaller != Constants.NULL_STRING)
                    row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Buyer values('" + buyerID + "','" + buyerName + "','" + wholeSaller + "','" + merchandiserID + "','" + "True" + "','" + buyerRegistrationTime + "','" + buyerEmail + "')");
            }
            else
                MessageBox.Show(Constants.ID_EXIST);
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> getBuyerID()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select BuyerID from Buyer where BuyerStatus='" + "True" + "'");
            return result;
        }

        public List<Dictionary<String, String>> getBuyer()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select BuyerID,BuyerName,BuyerType from Buyer where BuyerStatus='" + "True" + "'");
            return result;
        }

        public bool checkBuyerIDExist(string buyerID)
        {
            string buyerId = Constants.NULL_STRING;
            List<Dictionary<String, String>> result;
            result = DataBaseManager.runSelectQuery("Select BuyerID From Buyer Where BuyerID='" + buyerID + "'");
            if (result.Count > 0)
                result.ElementAt(0).TryGetValue(Constants.BUYER_ID, out buyerId);
            return buyerId == buyerID ? true : false;
        }

        public bool updateBuyer(Dictionary<string, string> data,string merchandiserID,string buyerRegistrationTime)
        {
            string buyerID = Constants.NULL_STRING, buyerName = Constants.NULL_STRING, retailer = Constants.NULL_STRING, wholeSaller = Constants.NULL_STRING, buyerEmail = Constants.NULL_STRING;
            int row = 0;
            data.TryGetValue(Constants.BUYER_ID, out buyerID);
            data.TryGetValue(Constants.BUYER_NAME, out buyerName);
            data.TryGetValue(Constants.RETAILER, out retailer);
            data.TryGetValue(Constants.WHOLESALLER, out wholeSaller);
            data.TryGetValue(Constants.BUYER_EMAIL, out buyerEmail);
            if (buyerName != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Buyer Set BuyerName='" + buyerName + "',MerchandiserID='" + merchandiserID + "',BuyerRegistrationTime='" + buyerRegistrationTime + "' where BuyerID='" + buyerID + "'");
            if (retailer != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Buyer Set BuyerType='" + retailer + "',MerchandiserID='" + merchandiserID + "',BuyerRegistrationTime='" + buyerRegistrationTime + "' where BuyerID='" + buyerID + "'");
            if (wholeSaller != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Buyer Set BuyerType='" + wholeSaller + "',MerchandiserID='" + merchandiserID + "',BuyerRegistrationTime='" + buyerRegistrationTime + "' where BuyerID='" + buyerID + "'");
            if (buyerEmail != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Buyer SetBuyerEmail='" + buyerEmail + "',MerchandiserID='" + merchandiserID + "',BuyerRegistrationTime='" + buyerRegistrationTime + "' where BuyerID='" + buyerID + "'");
            return row == 1 ? true : false;
        }

        public bool deleteBuyer(Dictionary<string, string> data,string merchandiserID,string buyerRegistrationTime)
        {
            int row =0;
            string buyerID = Constants.NULL_STRING;
            data.TryGetValue(Constants.BUYER_ID, out buyerID);
            if (buyerID != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Buyer Set BuyerStatus='" + "False" + "',MerchandiserID='" + merchandiserID + "',BuyerRegistrationTime='" + buyerRegistrationTime + "' where BuyerID='" + buyerID + "'");
            return row ==1 ? true : false;
        }

        public int incrementAndGetBuyerCount()
        {
            int count = getCount();
            count += 1;
            setCount(count);
            return count;
        }

        public int decrementAndGetBuyerCount()
        {
            int count = getCount();
            count -= 1;
            setCount(count);
            return count;
        }

        public bool enableOrDIsableShowBuyerBtn()
        {
            List<Dictionary<String, String>> data = getBuyerID();
            int totalBuyerCount = 0;
            foreach (Dictionary<String, String> entry in data)
            {
                totalBuyerCount += entry.Count;
            }
            BuyerManager.setCount(totalBuyerCount);
            return totalBuyerCount >=1 ? true : false;
        }

        public string getBuyerTypeOfSpecificBuyerID(Dictionary<string,string> data)
        {
            string buyerID;
            data.TryGetValue(Constants.BUYER_ID, out buyerID);
            string buyerType = getBuyerType(buyerID);
            return buyerType;
        }

        public string getBuyerEmailAddress(string buyerID)
        {
            string buyerEmail=Constants.NULL_STRING;
            List<Dictionary<String, String>> data = DataBaseManager.runSelectQuery("Select BuyerEmail from Buyer where BuyerID='"+buyerID+"'");
            if (data.Count > 0)
                data.ElementAt(0).TryGetValue(Constants.BUYER_EMAIL,out buyerEmail);
            return buyerEmail;
        }
    }
}
