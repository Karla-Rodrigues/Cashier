using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Order
    {
        [Key]
        public int OrdCode { get; set; }
        public int OrdCustomer { get; set; }
        public string OrdStatus { get; set; }
        public int OrdQtdItems { get; set; }
        public string OrdDateOrder { get; set; }
        public string OrdDateCancel { get; set; }
    }
}
