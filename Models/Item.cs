using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Item
    {
        [Key]
        public int ItemCode { get; set; }
        public int ItemNumber { get; set; }
        public int ItemProduct { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
