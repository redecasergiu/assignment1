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

        public void updateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call updateuser(@name, @epass, @salt, @isadmin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@epass", user.epass);
                cmd.Parameters.AddWithValue("@salt", user.salt);
                cmd.Parameters.AddWithValue("@isadmin", user.isadmin);

                cmd.ExecuteNonQuery();
            }
        }

        public void deleteUser(String username)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call deluser(@username);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", username);

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

        public void updateProduct(Product p)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call updateProduct(@name, @description, @color, @size, @price, @stock);";
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

        public void deleteProduct(Product p)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call deleteProduct(@name);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", p.name);

                cmd.ExecuteNonQuery();
            }
        }


        public void addOrder(Order o)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call addOrder(@a, @b, @c, @d);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@a", o.idcustomer);
                cmd.Parameters.AddWithValue("@b", o.address);
                cmd.Parameters.AddWithValue("@c", o.deliverydate);
                cmd.Parameters.AddWithValue("@d", o.status);

                cmd.ExecuteNonQuery();
            }
        }

        public void addProductToOrder(ProductOrder po)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "call laordin(@b, @c, @d);";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@b", po.idproduct);
                cmd.Parameters.AddWithValue("@c", po.idcommand);
                cmd.Parameters.AddWithValue("@d", po.cantitate);

                cmd.ExecuteNonQuery();
            }
        }

        //ignore this
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
        

        public IList<Product> getProducts()
        {
            IList<Product> productList = new List<Product>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "select * from products";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product products = new Product();
                        products.id = reader.GetInt32("id");
                        products.name = reader.GetString("name");
                        products.description = reader.GetString("description");
                        products.color = reader.GetString("color");
                        products.size = reader.GetInt32("size");
                        products.price = reader.GetInt32("price");
                        products.stock = reader.GetInt32("stock");
                        productList.Add(products);
                    }
                }
            }
            return productList;
        }


    }
}
