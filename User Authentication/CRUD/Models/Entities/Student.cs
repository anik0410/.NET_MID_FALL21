using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models.Entities
{
    public class Student
    {
        /*Data related Operations are done by Models
         Validations are done with Annotations
         Database er coloumn specification will be on entities like Id, Name, Dob, Gender, Cgpa
         */
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public Double Cgpa { get; set; }
    }
}