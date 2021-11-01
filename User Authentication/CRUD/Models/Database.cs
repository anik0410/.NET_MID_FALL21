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
        public Courses Courses { get; set; }
        public Departments Departments { get; set; }
        public Students Students { get; set; }
        public Users Users { get; set; }
        public Database()
        {
            string connString = @"Server=PREETI\SQLEXPRESS;Database=UMS_1;User Id=sa;Password=12345";
            conn = new SqlConnection(connString);
            //As constructor initializes with a null value thus a new object instance is being created
            Courses = new Courses(conn);
            Departments = new Departments();
            Students = new Students(conn);
            Users = new Users(conn);
        }
    }
}