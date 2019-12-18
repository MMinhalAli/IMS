using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace InventoryManagementSystem
{
    class UserManager
    {
        private static string MerchandiserID;
        public bool performSignIn(Dictionary<String, String> data)
        {
            string userName = Constants.NULL_STRING;
            string password = Constants.NULL_STRING;
            data.TryGetValue(Constants.USER_NAME, out userName);
            data.TryGetValue(Constants.PASSWORD, out password);
            MerchandiserID = userName;
            string pass = Constants.NULL_PASSWORD;
            if (userName != Constants.NULL_STRING && password != Constants.NULL_STRING)
            {
                List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select Password from MerchandInfo where Name='" + userName + "'");
                if (result.Count > 0)
                    result.ElementAt(0).TryGetValue(Constants.PASSWORD, out pass);
            }
            else
                MessageBox.Show(Constants.FILL_ALL_FIELDS);
            return password == pass ? true : false;

        }

        private bool checkUserIsAlreadyExist(Dictionary<String, String> data)
        {
            string userName = Constants.NULL_STRING;
            string name = Constants.NULL_STRING;
            string pass = Constants.NULL_STRING;
            string password = Constants.NULL_STRING;
            data.TryGetValue(Constants.USER_NAME, out userName);
            data.TryGetValue(Constants.PASSWORD, out password);
            if (userName != Constants.NULL_STRING && password != Constants.NULL_STRING)
            {
                List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select Name,Password from MerchandInfo where Name='" + userName + "'");
                if (result.Count > 0)
                {
                    result.ElementAt(0).TryGetValue(Constants.PASSWORD, out pass);
                    result.ElementAt(0).TryGetValue(Constants.NAME, out name);
                }
            }
            else
                MessageBox.Show(Constants.FILL_ALL_FIELDS);
            return password == pass || name==userName ? true : false;
        }

        public bool performSignUp(Dictionary<String, String> data)
        {
            int row = 0;
            int merchandiserID = 0;
            string name = Constants.NULL_STRING;
            string password = Constants.NULL_STRING;
            string email = Constants.NULL_STRING;
            data.TryGetValue(Constants.USER_NAME, out name);
            data.TryGetValue(Constants.PASSWORD, out password);
            data.TryGetValue(Constants.EMAIL, out email);
            if (getHighestMerchandiserID() == Constants.NULL_STRING)
                merchandiserID += 1;
            else
                merchandiserID = Convert.ToInt32(getHighestMerchandiserID()) + 1;
            if (!checkUserIsAlreadyExist(data))
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into MerchandInfo values('" + merchandiserID + "','" + name + "','" + password + "','" + email + "')");
            else
                MessageBox.Show(Constants.ID_EXIST);
            return row == 1 ? true : false;
        }

        private string getHighestMerchandiserID()
        {
            string merchandiserID=Constants.NULL_STRING;
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select MerchandiserID=max(MerchandiserID) from MerchandInfo");
            if(result.Count>0)
                result.ElementAt(0).TryGetValue(Constants.MERCHANDISER_ID, out merchandiserID);
            return merchandiserID;
        }

        public static string getMerchandID()
        { return MerchandiserID; }
    }
}
