using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13371_Egzamin.Models
{
    public class FurnitureBoard
    {
        [Range(0,2100)]
        public int Height { get; set; }
        [Range(0,2850)]
        public int Width { get; set; }
        [Range(0, 10000.00)]
        public decimal Price { get; set; }
        [Required]
        [Range(0,10000)]
        public int Amount { get; set; }
    }
}
