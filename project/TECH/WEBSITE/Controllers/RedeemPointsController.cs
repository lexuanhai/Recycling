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
    public class RedeemPointsController : Controller
    {

        public RedeemPointsController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PointAddress()
        {
            return View();
        }


    }
}
