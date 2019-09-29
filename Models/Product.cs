using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Product
    {
        [Key]
        public int ProdCode { get; set; }
        public string ProdCategory { get; set; }
        public string ProdShort { get; set; }
        public string ProdLong { get; set; }
        public decimal ProdRetail { get; set; }
        public decimal ProdCost { get; set; }
        public decimal ProdDiscount { get; set; }
        public int ProdStock { get; set; }
        public string ProdSupplier { get; set; }
    }
}
