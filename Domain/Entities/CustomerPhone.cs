using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomerPhone : BaseEntity
    {
        [Required]
        public int IdCsutomer { get; set; }
        public Customer Customers { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}