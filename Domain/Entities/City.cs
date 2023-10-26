using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }

        [Required]
        public int IdState { get; set; }
        public State States { get; set; }
        public CustomerAddress CustomersAddress { get; set; }
    }
}