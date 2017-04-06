using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankCredit.Models
{
    public class ProductOrder
    {
        public int id { get; set; }
        public int idproduct { get; set; }
        public int idcommand { get; set; }
        public int cantitate { get; set; }
    }
}
