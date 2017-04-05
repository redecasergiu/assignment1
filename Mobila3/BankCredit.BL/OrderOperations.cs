using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankCredit.DAL;
using BankCredit.Models;

namespace BankCredit.BL
{
    public class OrderOperations
    {
        public bool addOrder(int ci, String a, String d, String s)
        {
            Order o = new Order();
            o.idcustomer = ci;
            o.address = a;
            o.deliverydate = d;
            o.status = s;

            DataAccess dal = new DataAccess();
            dal.addOrder(o);
            return false;

        }
    }
}
