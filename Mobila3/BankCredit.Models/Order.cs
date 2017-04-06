using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankCredit.Models
{
    public class Order
    {
        public int id { get; set; }
        public int idcustomer { get; set; }
        public string address { get; set; }
        public string deliverydate { get; set; }
        public string status { get; set; }
    }
}
