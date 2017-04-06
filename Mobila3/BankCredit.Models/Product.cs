using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankCredit.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public double size { get; set; }
        public double price { get; set; }
        public int stock { get; set; }


        public bool isOk()
        {
            if (name == "")
                return false;
            if (price <= 0.0)
                return false;
            if (stock <= 0)
                return false;
            return true;
        }
    }


}
