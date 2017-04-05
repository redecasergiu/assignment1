using BankCredit.BL;
using BankCredit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace BankCredit
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserOperations bl = new UserOperations();

            User user = bl.Login(txtUser.Text, txtPassword.Text);

            if (user != null)
                if (user.isadmin)
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else
                {
                    //Accounts accountsForm = new Accounts();
                    // accountsForm.user = user;
                    //accountsForm.Show();
                    Form ou = new OrdinaryUser();
                    ou.Show();
                }
            else { }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
