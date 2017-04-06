using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankCredit.DAL;
using BankCredit.Models;

namespace BankCredit.BL
{
    public class ProductOperations
    {
        public bool addProduct(String n, String d, String c, int s, double pp, int ss)
        {
            Product p = new Product();
            p.name = n;
            p.description = d;
            p.color = c;
            p.size = s;
            p.price = pp;
            p.stock = ss;
            DataAccess dal = new DataAccess();
            if (p.isOk())
            {
                dal.addProduct(p);
                return false;
            }
            return true;
        }

        public bool updateProduct(String n, String d, String c, int s, double pp, int ss)
        {
            Product p = new Product();
            p.name = n;
            p.description = d;
            p.color = c;
            p.size = s;
            p.price = pp;
            p.stock = ss;
            DataAccess dal = new DataAccess();
            if (p.isOk())
            {
                dal.updateProduct(p);
                return false;
            }
            return true;
        }

        public void deleteProduct(String n)
        {
            Product p = new Product();
            p.name = n;
            DataAccess dal = new DataAccess();
            dal.deleteProduct(p);
        }

        public IList<Product> getProducts()
        {
            DataAccess dal = new DataAccess();
            return dal.getProducts();
        }

    }
}
