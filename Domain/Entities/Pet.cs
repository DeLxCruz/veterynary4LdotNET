using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pet : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string species { get; set; }
        [Required]
        public int IdBreed { get; set; }
        public Breed Breeds { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public int IdCustomer { get; set; }
        public Customer Customers { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}