﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashier.Models
{
    public interface IPaymentRepository
    {
        IQueryable<Payment> Payments { get; }
    }
}
