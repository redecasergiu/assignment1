using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankCredit.BL;
using BankCredit.Models;

namespace BankCredit
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = txtUserName.Text;
            user.epass = txtPassword.Text;
            user.salt = RandomString(32);
            user.isadmin = chkAdmin.Checked;

            UserOperations bl = new UserOperations();
            bl.AddUser(user);

            MessageBox.Show("Operation succesful");
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
