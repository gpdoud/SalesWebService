using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebService.Models {
    
    public class Customer {

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(2)]
        [Required]
        public string StateCode { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal TotalSales { get; set; }
        public bool IsNationalAccount { get; set; } = false;

        public Customer() { }
    }
}
