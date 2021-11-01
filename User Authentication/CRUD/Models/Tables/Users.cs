using CRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Models.Tables
{
    public class Users
    {
        SqlConnection conn;
        public Users(SqlConnection conn)
        {
            this.conn = conn;
        }
        public User Authenticate(string username, string password)
        {
            
            conn.Open();
            string query = String.Format("Select * from users where Username='{0}' and Password='{1}'",username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password"))
                };
            }
            conn.Close();
            return user;
        }
        public int GetUserType(string username)
        {
            int type = 0;
            conn.Open();
            string query = String.Format("Select Type from users where Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                type = reader.GetInt32(reader.GetOrdinal("Type"));
            }
            conn.Close();
            return type;
        }
    }
}