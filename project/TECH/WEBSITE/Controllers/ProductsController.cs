using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Areas.Admin.Models;
using WEBSITE.Models;
using WEBSITE.Service;

namespace WEBSITE.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
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

        public IActionResult ProductDetail(int id)
        {
            var model = new ProductModelView();
            if (id > 0)
            {               
                if (id > 0)
                {
                    model = _productService.GetById(id);
                }
            }
            return View(model);
        }

        //public IActionResult ProductDetail(int id)
        //{
        //    var model = new ProductModelView();
        //    if (id > 0)
        //    {
        //        if (id > 0)
        //        {
        //            model = _productService.GetById(id);
        //        }
        //    }
        //    return View(model);
        //}

    }
}
