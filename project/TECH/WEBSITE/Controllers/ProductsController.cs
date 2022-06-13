using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Models;

namespace WEBSITE.Controllers
{
    public class ProductsController : Controller
    {
        public ProductsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
       public IActionResult About()
       {
            return View();
       }
        public IActionResult Contact()
        {
            return View();
        }
        
    }
}
