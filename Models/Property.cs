using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management_API.Models
{
    public class Property
    {

        public int Id { get; set; }

        [Required]
        public string Customer_Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }


        public string Address { get; set; }

        public decimal CV { get; set; }

    }
}

