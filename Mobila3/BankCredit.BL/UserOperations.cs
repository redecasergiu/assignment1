using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankCredit.DAL;
using BankCredit.Models;
using System.Configuration;


namespace BankCredit.BL
{
    public class UserOperations
    {
        public User Login(string userName, string password)
        {
            DataAccess dal = new DataAccess();
            User user = dal.GetUser(userName);
            if (user!=null)
            {
                Security secure = new Security();
                String check = secure.HashSHA1(password+user.salt);
                if (user.epass.Equals(check))
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.epass = secure.HashSHA1(user.epass + user.salt);

            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }

        public IList<Account> GetAccountsForUser(int userId)
        {
            DataAccess dal = new DataAccess();
            return dal.GetAccountsForUser(userId);
        }
    }
}
