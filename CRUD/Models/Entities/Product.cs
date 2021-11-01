using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Used for Validation Messages
using System.Linq;
using System.Web;

namespace CRUD.Models.Entities
{
    public class Product
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Quantity Required")]
        public string Qty { get; set; }
        [Required(ErrorMessage = "Price Required")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Description Required")]
        public string Description { get; set; }
    }
}