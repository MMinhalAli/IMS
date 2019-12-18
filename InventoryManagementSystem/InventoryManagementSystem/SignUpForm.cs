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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            ApplicationManager.registerForm(Constants.SIGNUP_INFO,this);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ApplicationManager.hideSignUpFormAndShowSignInForm();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Constants.USER_NAME, userName.Text);
            data.Add(Constants.PASSWORD, password.Text);
            data.Add(Constants.EMAIL, email.Text);
            ApplicationManager.performSignUp(data);
        }

        public void showMessages(string message)
        {
            MessageBox.Show(message);
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationManager.hideSignUpFormAndShowSignInForm();  
        }

        public void clearAllTheFields()
        {
            userName.Text = null; password.Text = null; email.Text = null;
        }
    }
}
