using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Models.Tables
{
    public class Courses
    {
        SqlConnection conn;//Taken as a Student class attribute
        public Courses(SqlConnection conn)
        {
            this.conn = conn;
        }

    }
}