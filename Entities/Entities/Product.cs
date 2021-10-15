using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Product : Base
    {        
        [Column("Price", TypeName = "decimal")]
        public decimal Price { get; set; }
        public string Theme { get; set; }
        public DateTime DateEdit { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateRent { get; set; }
        public bool Rented { get; set; }                
    }
}
