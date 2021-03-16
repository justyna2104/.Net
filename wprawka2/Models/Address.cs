using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wprawka2.Models
{
    public class Address
    {

        [Display(Name = "Your street")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiazkowe")]
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int Number { get; set; }

    }
}
