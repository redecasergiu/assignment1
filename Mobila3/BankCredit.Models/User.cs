using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankCredit.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string epass { get; set; }
        public string salt { get; set; }
        public bool isadmin { get; set; }

        
        
        public IList<Account> Accounts { get; set; }

        //non bindable attribute
        public string firstName;
        //non bindable attribute
        public string lastName;

        //bindable property
        public string FullName
        {
            get
            { return firstName + " " + lastName; }
        }

        public int age;

        public DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                    dateOfBirth = value;
                    age = DateTime.Today.Year - dateOfBirth.Year;
            }
        }

    }
}
