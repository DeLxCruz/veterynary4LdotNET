using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        public CustomerAddress CustomersAddress { get; set; }
        public ICollection<CustomerPhone> CustomersPhone { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public User Users { get; set; }
    }
}