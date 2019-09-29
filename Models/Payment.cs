using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Payment
    {
        [Key]
        public int PayOrder { get; set; }
        public int PayCustomer { get; set; }
        public string PayMethod { get; set; }
        public int PayQtdItems { get; set; }
        public string PayPayDate { get; set; }
    }
}
