using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankCredit.DAL;
using BankCredit.Models;

namespace BankCredit.BL
{
    public class ProductOrderOperations
    {
        public void addProductToOrder(int ip, int ic, int c)
        {
            ProductOrder po = new ProductOrder();
            po.cantitate = c;
            po.idcommand = ic;
            po.idproduct = ip;

            DataAccess dal = new DataAccess();
            dal.addProductToOrder(po);
            //return false;
        }
    }
}
