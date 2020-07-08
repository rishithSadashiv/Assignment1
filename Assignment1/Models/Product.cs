using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Product
    {
        [Required(ErrorMessage = "ID required")]
        public int Pid { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string Pname { get; set; }

        [Required(ErrorMessage = "Price required")]
        public double Price { get; set; }

        [Required(ErrorMessage ="Stock required")]
        public int Stock { get; set; }

    }
}
