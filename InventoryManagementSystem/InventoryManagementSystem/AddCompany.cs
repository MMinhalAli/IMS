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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.ADD_COMPANY_FORM,this);
        }

        private void ADDBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.COMPANY_ID, CompanyID.Text);
            data.Add(Constants.COMPANY_NAME, CompanyName.Text);
            ApplicationManager.addCompany(data);
        }

        private void AddCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideAddCompanyForm();
        }

        public void clearAllFields()
        {
            CompanyID.Text = null;
            CompanyName.Text = null;
        }
    }
}
