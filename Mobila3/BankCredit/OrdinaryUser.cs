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
                MessageBox.Show("Eroare", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {
                String a = addressb.Text;
                String d = dateb.Value.ToString("yyyy-MM-dd"); ;
                int c = int.Parse(customeridb.Text);
                String s = statusb.Text;

                OrderOperations bl = new OrderOperations();
                bl.addOrder(c, a, d, s);
            }
            catch (Exception q)
            {
                MessageBox.Show("Eroare", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void id2b_TextChanged(object sender, EventArgs e)
        {

        }

        private void apld_Click(object sender, EventArgs e)
        {
            try
            {
                int idp = int.Parse(id2b.Text);
                int idc = int.Parse(idb.Text);
                int ca = int.Parse(cantitateb.Text);

                ProductOrderOperations bl = new ProductOrderOperations();
                bl.addProductToOrder(idp,idc,ca);
            }
            catch (Exception q)
            {
                MessageBox.Show("Eroare", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            try
            {
                String n = name2b.Text;
                ProductOperations bl = new ProductOperations();
                bl.deleteProduct(n);
            }
            catch (Exception q)
            {
                MessageBox.Show("Eroare", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void update2_Click(object sender, EventArgs e)
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
                bl.updateProduct(n, d, c, s, pp, ss);
            }
            catch (Exception q)
            {
                MessageBox.Show("Eroare", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
