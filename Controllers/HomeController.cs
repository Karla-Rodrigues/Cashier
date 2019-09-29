using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cashier.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cashier.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepository repository;
        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Products);   /* it sends the IQueryble */

        public ViewResult Account() => View(repository.Products);   /* it sends the IQueryble */
    }
}