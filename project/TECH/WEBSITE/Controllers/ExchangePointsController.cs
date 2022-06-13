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
    public class ExchangePointsController : Controller {

        public ExchangePointsController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }      
    }
}
