using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer cust = new Customer
            {
                Name = "Levent",
                Surname = "Durdalı"
            };

            return View(cust);
        }
    }
}
