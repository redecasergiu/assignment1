using BankCredit.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace BankCredit.BL
{
    public class AccountOperations
    {
        public void Withdraw(Account account, double sum)
        {
            double fee = Convert.ToInt32(ConfigurationManager.AppSettings["TransactionFee"]);
            account.Withdraw(sum, fee);
        }
    }
}
