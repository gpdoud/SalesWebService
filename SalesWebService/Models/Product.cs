using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebService.Models {
    
    public class Product {
        public int Id { get; set; }
        [StringLength(8)]
        [Required]
        public string Code { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; } = 10.00m;
        public bool InStock { get; set; } = true;

        public Product() { }
    }
}
