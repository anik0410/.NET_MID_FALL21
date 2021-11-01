using CRUD.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Database
    {
        SqlConnection conn;
        public Products Products { get; set; }
        public Database()
        {
            string connString = @"Server=PREETI\SQLEXPRESS; Database=UMS; User Id=sa; Password=12345";
            conn = new SqlConnection(connString);
            Products = new Products(conn);
        }

    }
}