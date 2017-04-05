using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankCredit.BL;

namespace BankCredit
{
    public partial class OrdinaryUser : Form
    {
        public OrdinaryUser()
        {
            InitializeComponent();
        }

        private void OrdinaryUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void create2_Click(object sender, EventArgs e)
        {
            try
            {
                String n = name2b.Text;
                String d = description2b.Text;
                String c = color2b.Text;
                int s = int.Parse(size2b.Text);
                double pp = double.Parse(price2b.Text);
                int ss = int.Parse(stock2b.Text);

                ProductOperations bl = new ProductOperations();
                bl.addProduct(n, d, c, s, pp, ss);
            }catch(Exception q)
            {
                MessageBox.Show("Eroare", "Eroareeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
