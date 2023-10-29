using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomerAddress : BaseEntity
    {
        [Required]
        public int IdCustomer { get; set; }
        public Customer Customers { get; set; }
        [Required]
        public int IdCity { get; set; }
        public City Cities { get; set; }
        public string RoadType { get; set; }
        public int PrimaryNum { get; set; }
        public string Letter { get; set; }
        public string Bis { get; set; }
        public string LetterSec { get; set; }
        public string Cardinal { get; set; }
        public int SecondaryNum { get; set; }
        public string LetterThird { get; set; }
        public int ThirdNum { get; set; }
        public string CardinalSec { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
    }
}