using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankCredit.Models;

namespace BankCredit.UnitTests.Models
{
    [TestClass]
    public class AccountTests
    {
        // unit test code  
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange  
            double balance = 110;
            double debitAmount = 35;
            double fee = 0.50;
            double expected = 74.50;
            Account account = new Account(1, "RO2854BTRL", balance);

            // act  
            account.Withdraw(debitAmount, fee);

            // assert  
            double actual = account.Value;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        //unit test method  
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange  
            double balance = 11.99;
            double debitAmount = -100.00;
            double fee = 0.50;
            Account account = new Account(1, "RO2854BTRL", balance);

            // act  
            account.Withdraw(debitAmount, fee);

            // assert is handled by ExpectedException  
        }

    }
}
