using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using BankCredit.Models;
using MySql.Data.MySqlClient;

namespace BankCredit.DAL
{
    public class DataAccess
    {
        private string connString;

        public DataAccess()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public User GetUser(string userName)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM users where name=\""+ userName +"\";";
                
                MySqlCommand cmd = new MySqlCommand(statement,conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.id = reader.GetInt32("id");
                        user.name = reader.GetString("name");
                        user.epass = reader.GetString("epass");
                        user.salt = reader.GetString("salt");
                        user.isadmin = reader.GetBoolean("isadmin");

                        return user;
                    }
                }
            }

            return null;
        }

        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO users(name, epass, salt, isadmin) VALUES(@name, @epass, @salt, @isadmin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@epass", user.epass);
                cmd.Parameters.AddWithValue("@salt", user.salt);
                cmd.Parameters.AddWithValue("@isadmin", user.isadmin);

                cmd.ExecuteNonQuery();
            }
        }

        public void addProduct(Product p)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call addProduct(@name, @description, @color, @size, @price, @stock);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@color", p.color);
                cmd.Parameters.AddWithValue("@size", p.size);
                cmd.Parameters.AddWithValue("@price", p.price);
                cmd.Parameters.AddWithValue("@stock", p.stock);

                cmd.ExecuteNonQuery();
            }
        }

        public IList<Account> GetAccountsForUser(int userID)
        {
            IList<Account> creditList = new List<Account>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM Accounts where userid="+ userID + "; ";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Account credit = new Account();
                        credit.ID = reader.GetInt32("Id");
                        credit.Number = reader.GetString("Number");
                        credit.Value = reader.GetDouble("Value");
                        creditList.Add(credit);
                    }
                }
            }

            return creditList;
        }
    }
}
