using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankCredit.BL;
using BankCredit.Models;

namespace BankCredit.UnitTests.BL
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Login()
        {
            string userName = "zflaviu";
            string password = "password";
            UserOperations bl = new UserOperations();

            User user = bl.Login(userName, password);

            Assert.AreEqual(user.lastName, "Pop");
        }
    }
}
