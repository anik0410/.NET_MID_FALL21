using CRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Models.Tables
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Create(Product p)//for inserting data
        {
            conn.Open();
            string query = String.Format("insert into Products values ('{0}','{1}','{2}','{3}')",p.Name,p.Price,p.Qty,p.Description);
            SqlCommand cmd = new SqlCommand(query,conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Product> Get()//to read all the data's
        {
            conn.Open();
            string query = "Select * from Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Qty = reader.GetString(reader.GetOrdinal("Qty")),
                    Price = reader.GetString(reader.GetOrdinal("Price")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                };
                products.Add(p);
            }
            conn.Close();
            return products;
        }

    }
}