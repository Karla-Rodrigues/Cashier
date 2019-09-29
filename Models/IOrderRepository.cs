using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
    }
}
