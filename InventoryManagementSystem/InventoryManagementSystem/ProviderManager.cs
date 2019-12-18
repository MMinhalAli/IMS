using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    class ProviderManager
    {
        private static int count;

        private static int getCount()
        {
            return count;
        }

        private static void setCount(int val)
        {
            count = val;
        }

        public bool addCompany(Dictionary<string, string> data,string merchandiserID,string companyRegistrationTime)
        {
            int row=0;
            string companyID = Constants.NULL_STRING, companyName = Constants.NULL_STRING;
            data.TryGetValue(Constants.COMPANY_ID, out companyID);
            data.TryGetValue(Constants.COMPANY_NAME, out companyName);
            if (!checkCompanyIDExist(companyID))
            {
                if (companyID != Constants.NULL_STRING && companyName != Constants.NULL_STRING)
                    row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Insert into Provider values('" + companyID + "','" + companyName + "','" + merchandiserID + "','" + "True" + "','" + companyRegistrationTime + "')");
            }
            else
                MessageBox.Show(Constants.ID_EXIST);
            return row == 1 ? true : false;
        }

        public List<Dictionary<String, String>> getCompanyID()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select CompanyID from Provider where ProviderStatus='"+"True"+"'");
            return result;
        }

        public List<Dictionary<String, String>> getProviders()
        {
            List<Dictionary<String, String>> result = DataBaseManager.runSelectQuery("Select CompanyID,CompanyName from Provider where ProviderStatus='" + "True" + "'");
            return result;
        }

        public bool checkCompanyIDExist(string companyID)
        {
            string companyId=Constants.NULL_STRING;
            List<Dictionary<String, String>> result;
            result = DataBaseManager.runSelectQuery("Select CompanyID From Provider Where CompanyID='" + companyID + "'");
            if(result.Count>0)
                result.ElementAt(0).TryGetValue(Constants.COMPANY_ID, out companyId);
            return companyId == companyID ? true : false;
        }

        public bool updateCompany(Dictionary<string, string> data,string merchandiserID,string companyRegistrationTime)
        {
            int row=0;
            string companyID = Constants.NULL_STRING, companyName = Constants.NULL_STRING;
            data.TryGetValue(Constants.COMPANY_ID, out companyID);
            data.TryGetValue(Constants.COMPANY_NAME, out companyName);
            if (companyID !=Constants.NULL_STRING  && companyName != Constants.NULL_STRING )
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Provider Set CompanyName='"+companyName+"',MerchandiserID='"+merchandiserID+"',ProviderRegistrationTime='"+ companyRegistrationTime + "' where CompanyID='"+companyID+"'");
            return row == 1 ? true : false;
        }

        public bool removeCompany(Dictionary<string, string> data,string merchandiserID,string companyRegistrationTime)
        {
            int row=0;
            string companyID = Constants.NULL_STRING;
            data.TryGetValue(Constants.COMPANY_ID, out companyID);
            if (companyID != Constants.NULL_STRING)
                row = DataBaseManager.runInsertAndUpdateAndDeleteQuery("Update Provider Set ProviderStatus='"+"False"+ "',MerchandiserID='" + merchandiserID + "',ProviderRegistrationTime='" + companyRegistrationTime + "' where CompanyID='" + companyID+"'");
            return row == 1 ? true : false;
        }

        public int incrementAndGetCompanyCount()
        {
            int count = getCount();
            count += 1;
            setCount(count);
            return count;
        }

        public int decrementAndGetCompanyCount()
        {
            int count = getCount();
            if (count > 0)
            {
                count -= 1;
                setCount(count);
            }
            return count;
        }

        public bool enableOrDisableShowProviderBtn()
        {
            List<Dictionary<String, String>> data = getCompanyID();
            int totalProviders = 0;
            foreach (Dictionary<String, String> entry in data)
            {
                totalProviders += entry.Count;
            }
            setCount(totalProviders);
            return totalProviders >= 1 ? true : false;
        }
    }
}
