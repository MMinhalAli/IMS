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
    public partial class DeleteCompanyForm : Form
    {
        public DeleteCompanyForm()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.DELETE_COMPANY_FORM, this);
        }

        private void DeleteCompanyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideDeleteCompanyForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.COMPANY_ID, comboBox1.SelectedItem.ToString());
            ApplicationManager.removeCompany(data);
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
