using CRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Models.Tables
{
    //Tables is responsible in interacting with the database
    public class Students
    {
        SqlConnection conn;//Taken as a Student class attribute
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Create(Student s) //This s is passed from StudentController Create(Student s) function
        {
            conn.Open();
            string query = String.Format("Insert into students values ('{0}','{1}','{2}',0.0)", s.Name, s.Dob, s.Gender);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> Get()
        {
            conn.Open();
            string query = String.Format("Select * from students");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Cgpa = (float)reader.GetDouble(reader.GetOrdinal("Cgpa"))

                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }
        public Student Get(int id)
        {
            conn.Open();
            string query = String.Format("Select * from students where Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student s = null;
            while (reader.Read())
            {
                s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Cgpa = (float)reader.GetDouble(reader.GetOrdinal("Cgpa"))
                };
            }
            conn.Close();
            return s;
        }
    }
}