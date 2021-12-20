using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TierCore.Repository.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
        [Required]
        [Column("Delivery_Person")]
        [StringLength(30)]
        public string DeliveryPerson { get; set; }
        [Required]
        [Column("Delivery_Date")]
        [StringLength(30)]
        public string DeliveryDate { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }
        [InverseProperty(nameof(OrderDetail.Order))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
