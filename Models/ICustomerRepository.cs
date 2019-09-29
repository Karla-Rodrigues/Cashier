using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> Customers { get; }
    }
}
