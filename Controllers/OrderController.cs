﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cashier.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Order()
        {
            return View("Order");
        }
    }
}