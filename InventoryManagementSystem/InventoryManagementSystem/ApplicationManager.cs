using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CrystalDecisions.Shared;
using System.Net.Mail;

namespace InventoryManagementSystem
{
    class ApplicationManager
    {
        
            private static Dictionary<String, Form> listOfRegisteredForms = new Dictionary<string, Form>();
            private static UserManager userManager = new UserManager();
            private static ItemManager itemManager = new ItemManager();
            private static ProviderManager companyManager = new ProviderManager();
            private static StockManager stockManager = new StockManager();
            private static InventoryStore inventoryStore;
            private static AddItems addItemForm;
            private static UpdateItem updateItemForm;
            private static DeleteItem deleteItemForm;
            private static AddCompany addCompanyForm;
            private static UpdateCompany updateCompanyForm;
            private static DeleteCompanyForm deleteCompanyForm;
            private static AddBuyer addBuyerForm;
            private static UpdateBuyer updateBuyerForm;
            private static DeleteBuyerForm deleteBuyerForm;
            private static BuyerManager buyerManager = new BuyerManager();
            private static CartAndRecieptManager cartAndRecieptManager = new CartAndRecieptManager();
            private static int recieptNumber = 0;
            private static Form1 signInForm;
            private static SignUpForm signUpForm;
            private static SelectBuyerForm selectBuyerForm;
            private static CartForm cartForm ;
            private static string name = Constants.NULL_STRING;

        public static void registerForm(string formName,Form f)
        {
            listOfRegisteredForms.Add(formName, f);
        }

        public static Form startApplication()
        {
             addItemForm= new AddItems();
             updateItemForm = new UpdateItem();
             addCompanyForm = new AddCompany();
             inventoryStore = new InventoryStore();
             deleteItemForm = new DeleteItem();
             updateCompanyForm = new UpdateCompany();
             deleteCompanyForm = new DeleteCompanyForm();
             addBuyerForm = new AddBuyer();
             updateBuyerForm = new UpdateBuyer();
             deleteBuyerForm = new DeleteBuyerForm();
             signUpForm = new SignUpForm();
             selectBuyerForm = new SelectBuyerForm();
             signInForm = new Form1();
             return signInForm;
        }

        public static void performSignIn(Dictionary<String, String> data)
        {
            if (!userManager.performSignIn(data))
            { MessageBox.Show(Constants.WRONG_EMAIL_PASSWORD);  }
            else
            {
               getForm(Constants.SIGNIN_INFO).Hide();
               getForm(Constants.INVENTORYSTORE_FORM).Show();
               signInForm.clearAllTheFields();
               enableOrDisableAvailableStockAndShowBuyeAndrProviderBtn();
            }
        }

        private static void closeAllForms()
        {
            foreach (KeyValuePair<string,Form> valueMap in listOfRegisteredForms)
            {
                if(valueMap.Key!=Constants.SIGNIN_INFO)
                    valueMap.Value.Hide();
            }
            CartAndRecieptManager.hideCartForms();
        }

        public static void performSignUp(Dictionary<String, String> data)
        {
            if (!userManager.performSignUp(data))
                 MessageBox.Show(Constants.SIGNUP_REQUEST_FAILED);
            else
            {
                MessageBox.Show(Constants.SIGNUP_REQUEST_SUCCESS);
                getForm(Constants.SIGNUP_INFO).Hide();
                getForm(Constants.SIGNIN_INFO).Show();
                signUpForm.clearAllTheFields();
            }
        }

        public static void showAddItemFormAndSetValuesToAddItemComboBox()
        {
            getForm(Constants.ADD_ITEM_FORM).Show();
            addItemForm.setCompanyIDComboBoxValues(getCompanyID());
        }

        public static void showUpdateCompanyFormAndSetValuesToUpdateCompanyComboBox()
        {
            getForm(Constants.UPDATE_COMPANY_FORM).Show();
            updateCompanyForm.setCompanyIDComboBoxValues(getCompanyID());
        }

        public static void hideUpdateCompanyForm()
        {
            getForm(Constants.UPDATE_COMPANY_FORM).Hide();
        }

        public static void showSelectBuyerFormAndSetValuesToCartForm(Dictionary<string, string> data =null)
        {
            string buyerID=Constants.NULL_STRING;
            if (data != null)
                buyerID=cartAndRecieptManager.getBuyerID(data);
            else
            {
                getForm(Constants.SELECT_BUYER_FORM).Show(); 
                selectBuyerForm.setBuyerIDComboBoxValues(getBuyerID());
            }
            string buyerId =CartAndRecieptManager.checkBuyerIDExist(buyerID);
            if (buyerID !=Constants.NULL_STRING && buyerID!=buyerId)
            {
                string cartID = cartAndRecieptManager.checkBuyerSaveACartOrNot(buyerID);
                createACartAndSetValuesOnItAndHideSelectBuyerForm(buyerID, cartID);
                if (cartID != Constants.NULL_STRING)
                    getCartDataAndDisplayOnIt(cartID);
                cartForm.Show();
            }
        }

        private static void createACartAndSetValuesOnItAndHideSelectBuyerForm(string buyerID,string cartID)
        {
            cartForm = new CartForm();
            CartAndRecieptManager.insertIntoListOfCartForms(cartForm);
            CartAndRecieptManager.insertIntoBuyerNamesList(buyerID);
            name = buyerID;
            cartForm.setItemIDComboBoxValues(getItemID());
            cartForm.setBuyerID(buyerID);
            cartForm.setMerchandiserID(UserManager.getMerchandID());
            if(cartID!=Constants.NULL_STRING)
                cartForm.setInvoiceNumber(cartID);
            else
                cartForm.setInvoiceNumber(getInvoiceNumber());
            getForm(Constants.SELECT_BUYER_FORM).Hide();
        }

        private static void getCartDataAndDisplayOnIt(string cartID)
        {
            List<Dictionary<String, String>> data1 = cartAndRecieptManager.getCartData(cartID);
            cartForm.displayItemsInDataGridView(data1);
            string totalAmount = cartAndRecieptManager.getTotalAmountFromCart(cartID);
            cartForm.setTotalAmountInCartForm(totalAmount);
        }

        public static void hideSelectBuyerForm()
        {
            getForm(Constants.SELECT_BUYER_FORM).Hide();
        }

        public static string getInvoiceNumber()
        {
            string cartID=cartAndRecieptManager.getIdForCart();
            return cartID;
        }

        public static void showDeleteCompanyFormAndSetValuesToDeleteCompanyComboBox()
        { 
            getForm(Constants.DELETE_COMPANY_FORM).Show();
            deleteCompanyForm.setCompanyIDComboBoxValues(getCompanyID());
        }

        public static void hideDeleteCompanyForm()
        {
            getForm(Constants.DELETE_COMPANY_FORM).Hide();
        }

        public static void hideAddItemForm()
        {
            getForm(Constants.ADD_ITEM_FORM).Hide();
        }

        public static void showDeleteItemFormAndSetValuesToDeleteItemComboBox()
        {
            getForm(Constants.DELETE_ITEM_FORM).Show();
            deleteItemForm.setItemIDComboBoxValues(getItemID());
        }

        public static void hideDeleteItemForm()
        {
            getForm(Constants.DELETE_ITEM_FORM).Hide();
        }

        public static void showAddCompanyForm()
        {
            getForm(Constants.ADD_COMPANY_FORM).Show();
        }

        public static void showAddBuyerForm()
        {
            getForm(Constants.ADD_BUYER_FORM).Show();
        }

        public static void hideAddBuyerForm()
        {
            getForm(Constants.ADD_BUYER_FORM).Hide();
        }

        public static void showUpdateBuyerFormAndSetValuesToUpdateBuyerComboBox()
        {
            getForm(Constants.UPDATE_BUYER_FORM).Show();
            updateBuyerForm.setBuyerIDComboBoxValues(getBuyerID());
        }

        public static void hideUpdateBuyerForm()
        {
            getForm(Constants.UPDATE_BUYER_FORM).Hide();
        }

        public static void showDeleteBuyerFormAndSetValuesToDeleteBuyerComboBox()
        {
            getForm(Constants.DELETE_BUYER_FORM).Show();
            deleteBuyerForm.setBuyerIDComboBoxValues(getBuyerID());
        }

        public static void hideDeleteBuyerForm()
        {
            getForm(Constants.DELETE_BUYER_FORM).Hide();
        }

        public static void showSignInForm()
        {
            getForm(Constants.SIGNIN_INFO).Show();
        }

        public static void hideAllFormAndShowSignInForm()
        {
            closeAllForms();
            getForm(Constants.SIGNIN_INFO).Show();
        }

        public static void hideSignInFormAndShowSignUpForm()
        {
            getForm(Constants.SIGNIN_INFO).Hide();
            getForm(Constants.SIGNUP_INFO).Show();
        }

        public static void hideSignUpFormAndShowSignInForm()
        {
            getForm(Constants.SIGNUP_INFO).Hide();
            getForm(Constants.SIGNIN_INFO).Show();
        }

        public static void  addItem(Dictionary<string, string> data)
        {
            if (itemManager.addItem(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
                {
                    stockManager.addItemIntoStock(data);
                    itemManager.setItemPriceManagement(data);
                    MessageBox.Show(Constants.ADD_ITEM_REQUEST_SUCCESS);
                    if (itemManager.getAndIncrementInItemCount()>=1)
                        inventoryStore.enableOrDisableShowStockBtn(true);
                    showStock();
                    addItemForm.clearAllTheFields();
                }
                else
                    MessageBox.Show(Constants.ADD_ITEM_REQUEST_FAIL);
        }

        public static void enableOrDisableAvailableStockAndShowBuyeAndrProviderBtn()
        {
            if (!itemManager.enableOrDIsableShowStockBtn())
                inventoryStore.enableOrDisableShowStockBtn(false);
            else
                inventoryStore.enableOrDisableShowStockBtn(true);
            if (!companyManager.enableOrDisableShowProviderBtn())
                inventoryStore.enableOrDisableBtnShowProviderBtn(false);
            else
                inventoryStore.enableOrDisableBtnShowProviderBtn(true);
            if (!buyerManager.enableOrDIsableShowBuyerBtn())
                inventoryStore.enableOrDisableBtnShowBuyerBtn(false);
            else
                inventoryStore.enableOrDisableBtnShowBuyerBtn(true);
        }

        public static void showStock()
        {
            List<Dictionary<String, String>> data = stockManager.availableStock();
            inventoryStore.displayStockInDataGridViewOne(data);
        }

        public static void showProviders()
        {
            List<Dictionary<String, String>> data = companyManager.getProviders();
            inventoryStore.displayStockInDataGridViewTwo(data);
        }

        public static void showBuyers()
        {
            List<Dictionary<String, String>> data = buyerManager.getBuyer();
            inventoryStore.displayStockInDataGridViewThree(data);
        }

        public static void updateItem(Dictionary<string, string> data)
        {
            if (itemManager.updateItem(data, UserManager.getMerchandID(), DateTime.Now.ToString()))
            {
                itemManager.updateItemPriceManagement(data);
                stockManager.updateStock(data);
                MessageBox.Show(Constants.UPDATE_ITEM_REQUEST_SUCCESS);
                updateItemForm.clearAllFields();
                showStock();
            }
            else
                MessageBox.Show(Constants.UPDATE_ITEM_REQUEST_FAIL);
        }

        public static void updateBuyer(Dictionary<string, string> data)
        {
            if (!buyerManager.updateBuyer(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
                MessageBox.Show(Constants.UPDATE_BUYER_REQUEST_FAIL);
            else
            {
                MessageBox.Show(Constants.UPDATE_BUYER_REQUEST_SUCCESS);
                showBuyers();
                updateBuyerForm.clearAllFields();
            }
        }

        public static void deleteItem(Dictionary<string, string> data)
        {
            if (itemManager.deleteItem(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
            {
                stockManager.deleteItemFromStock(data);
                itemManager.deleteItemFromItemPriceManagement(data);
                deleteItemForm.setItemIDComboBoxValues(getItemID());
                MessageBox.Show(Constants.DELETE_ITEM_REQUEST_SUCCESS);
                showStock();
                if (itemManager.getAndDecrementInItemCount() ==0)
                    inventoryStore.enableOrDisableShowStockBtn(false);
            }
            else
                MessageBox.Show(Constants.DELETE_ITEM_REQUEST_FAIL);
        }

        public static void deleteBuyer(Dictionary<string, string> data)
        {
            if (!buyerManager.deleteBuyer(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
                MessageBox.Show(Constants.DELETE_BUYER_REQUEST_FAIL);
            else
            {
                MessageBox.Show(Constants.DELETE_BUYER_REQUEST_SUCCESS);
                deleteBuyerForm.setBuyerIDComboBoxValues(getBuyerID());
                showBuyers();
                if (buyerManager.decrementAndGetBuyerCount() == 0)
                    inventoryStore.enableOrDisableBtnShowBuyerBtn(false);
            }
        }

        private static Form getForm(string formName)
        {
            Form form;
            listOfRegisteredForms.TryGetValue(formName, out form);
            return form;
        }

        private static List<Dictionary<String, String>> getItemID()
        {
            List<Dictionary<String, String>> result = itemManager.getItemIDs();
            return result;
        }

        public static void hideAddCompanyForm()
        {
            getForm(Constants.ADD_COMPANY_FORM).Hide();
        }

        public static void showUpdateItemFormAndSetValuesToUpdateItemComboBox()
        {
            getForm(Constants.UPDATE_ITEM_FORM).Show();
            updateItemForm.setItemIDComboBoxValues( getItemID());
        }

        public static void hideUpdateItemForm()
        {
            getForm(Constants.UPDATE_ITEM_FORM).Hide();
        }


        private static List<Dictionary<String, String>> getCompanyID()
        {
            List < Dictionary<String, String> > data= companyManager.getCompanyID();
            return data;
        }

        private static List<Dictionary<String, String>> getBuyerID()
        {
            List<Dictionary<String, String>> data = buyerManager.getBuyerID();
            return data;
        }

        public static void addCompany(Dictionary<string, string> data)
        {
            if (!companyManager.addCompany(data, UserManager.getMerchandID(), DateTime.Now.ToString()))
                MessageBox.Show(Constants.ADD_COMPANY_REQUEST_FAIL);
            else
            {
                showProviders();
                if (companyManager.incrementAndGetCompanyCount() >= 1)
                    inventoryStore.enableOrDisableBtnShowProviderBtn(true);
                MessageBox.Show(Constants.ADD_COMPANY_REQUEST_SUCCESS);
                addCompanyForm.clearAllFields();
            }
        }

        public static void updateCompany(Dictionary<string, string> data)
        {
            if (!companyManager.updateCompany(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
                MessageBox.Show(Constants.UPDATE_COMPANY_REQUEST_FAIL);
            else
            {
                MessageBox.Show(Constants.UPDATE_COMPANY_REQUEST_SUCCESS);
                showProviders();
                updateCompanyForm.clearAllFields();
            }
        }

        public static void removeCompany(Dictionary<string, string> data)
        {
            if (!companyManager.removeCompany(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
                MessageBox.Show(Constants.DELETE_COMPANY_REQUEST_FAIL);
            else
            {
                showProviders();
                if (companyManager.decrementAndGetCompanyCount()==0)
                    inventoryStore.enableOrDisableBtnShowProviderBtn(false);
                MessageBox.Show(Constants.DELETE_COMPANY_REQUEST_SUCCESS);
                deleteCompanyForm.setCompanyIDComboBoxValues(getCompanyID());
            }
        }

        public static void addBuyer(Dictionary<string, string> data)
        {
            if (!buyerManager.addBuyer(data,UserManager.getMerchandID(),DateTime.Now.ToString()))
                MessageBox.Show(Constants.ADD_BUYER_REQUEST_FAIL);
            else
            {
                MessageBox.Show(Constants.ADD_BUYER_REQUEST_SUCCESS);
                addBuyerForm.clearAllFields();
                showBuyers();
                if (buyerManager.incrementAndGetBuyerCount() >= 1)
                    inventoryStore.enableOrDisableBtnShowBuyerBtn(true);
            }
        }

        public static void addToCart(Dictionary<string, string> data)
        {   
            string buyerType=buyerManager.getBuyerTypeOfSpecificBuyerID(data);
            string profitPriceOfBuyer = itemManager.getProfitPriceOfSpecificBuyerType(data, buyerType);
            string cost=itemManager.getCostOfParticularItem(data);
            int itemOriginalQuantity = stockManager.getQuantityOfSpecificItemID(data);
            data.Add(Constants.PROFIT_PRICE_OF_BUYER, profitPriceOfBuyer);
            data.Add(Constants.ITEM_ORIGINAL_QUANTITY, itemOriginalQuantity.ToString());
            data.Add(Constants.COST, cost);
            Dictionary<string,string> result=cartForm.extractDataAndSetOnCartAndReturnARemainingQuantityOfItem(data);
            stockManager.updateStock(result);
            showStock();
        }

        public static void cancelACart(List<Dictionary<String, String>> data)
        {
            List<Dictionary<String, String>> listOfCancelData = cartForm.getCancelDataFromCart();
            string  itemID;
            int iterartor=0,tempQuantity;
            foreach (Dictionary<string, string> dic in listOfCancelData)
            {
                itemID = Constants.NULL_STRING;
                foreach (KeyValuePair<string, string> kvp in dic)
                { 
                    if (kvp.Key != Constants.QUANTITY)
                        itemID = kvp.Value;
                   else
                    {
                        tempQuantity=stockManager.getQuantityOfSpecificItemID(listOfCancelData[iterartor++]);
                        stockManager.updateQunatityInStock(Convert.ToInt32(kvp.Value), tempQuantity,itemID);
                    }
                }
            }
            showStock();
            CartAndRecieptManager.removeBuyerNameFromBuyerList(name);
            cartAndRecieptManager.setCartStatusToFalse(data);
            cartForm.Hide();
        }

        public static void saveUserCartInToDataBase(List<Dictionary<String, String>> cartTableData, List<Dictionary<String, String>> cartItemsTableData)
        {
            cartAndRecieptManager.saveAUserCartInToCartTable(cartTableData);
            cartAndRecieptManager.addToCartItems(cartItemsTableData, cartTableData);
            CartAndRecieptManager.removeBuyerNameFromBuyerList(name);
            cartForm.Hide();
        }

        public static void checkOut(List<Dictionary<String, String>> recieptTableData, List<Dictionary<String, String>> recieptItemsTableData)
        {
            cartAndRecieptManager.setDataOnRecieptTable(recieptTableData,DateTime.Now.ToString());
            cartAndRecieptManager.setDataOnRecieptItemsTable(recieptItemsTableData, recieptTableData);
            cartAndRecieptManager.setCartStatusToFalse(recieptTableData);
            cartForm.Hide();
            cartAndRecieptManager.fillCartReciept(recieptTableData);
            string buyerID = cartAndRecieptManager.getBuyerIdentity(recieptTableData);
            string buyerEmail = buyerManager.getBuyerEmailAddress(buyerID);
            EmailManager.sendEmailToBuyer(recieptTableData,buyerEmail);
        }

        public static void hideCartForm()
        {
            cartForm.Hide();
        }
    }
}


