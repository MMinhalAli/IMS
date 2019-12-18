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
    public partial class UpdateCompany : Form
    {
        public UpdateCompany()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.UPDATE_COMPANY_FORM, this);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.COMPANY_ID, comboBox1.SelectedItem.ToString());
            data.Add(Constants.COMPANY_NAME, CompanyName.Text);
            ApplicationManager.updateCompany(data);
        }

        private void UpdateCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideUpdateCompanyForm();
        }

        public void clearAllFields()
        {
            comboBox1.Text = null;
            CompanyName.Text = null;
        }

        public void setCompanyIDComboBoxValues(List<Dictionary<String, String>> data)
        {
            comboBox1.Items.Clear();
            string companyID;
            foreach (Dictionary<String, String> valueMap in data)
            {
                valueMap.TryGetValue(Constants.COMPANY_ID, out companyID);
                comboBox1.Items.Add(companyID);
            }
        }
    }
}
