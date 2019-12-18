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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.SIGNIN_INFO, this);
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.USER_NAME, UserName.Text);
            data.Add(Constants.PASSWORD, Password.Text);
            ApplicationManager.performSignIn(data);
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            ApplicationManager.hideSignInFormAndShowSignUpForm();
        }

        public void clearAllTheFields()
        {
            UserName.Text = null; Password.Text = null;
        }
    }
}
