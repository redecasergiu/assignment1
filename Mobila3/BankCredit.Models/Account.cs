using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace BankCredit.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public double Value { get; set; }

        public double previousValue;

        public User Customer { get; set; }

        public Account() { }
        public Account(int id, string number, double value)
        {
            ID = id;
            Number = number;
            Value = value;

            this.previousValue = value;
        }

        public void Withdraw(double amount, double fee)
        {
            double totalAmount = amount;
        
            if (totalAmount > Value)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (totalAmount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            previousValue = Value;
            Value-= totalAmount;
        }
    }
}
