using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public class Customer
    {
            [Key]
            public int CustId { get; set; }
            public string CustEmail { get; set; }
            public string CustFirstName { get; set; }
            public string CustLastName { get; set; }
            public int CustPhone { get; set; }
    }
}
