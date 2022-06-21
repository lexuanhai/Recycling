using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        //private readonly IProductService _productService;
        //private readonly IUserService _userService;
        //public IHttpContextAccessor _httpContextAccessor;
        //public ProductsController(IProductService productService,
        //    IUserService userService,
        //    IHttpContextAccessor httpContextAccessor)
        //{
        //    _productService = productService;
        //    _httpContextAccessor = httpContextAccessor;
        //    _userService = userService;
        //}

        private readonly IProductService _productService;
        private readonly IUserService _userService;
        public IHttpContextAccessor _httpContextAccessor;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService,
            IUserService userService,
            ICategoryService categoryService,
        IHttpContextAccessor httpContextAccessor)
        {
            _productService = productService;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _categoryService = categoryService;
        }



        public IActionResult Index()
        {
            //_userService.UpdatePointUser(1, 100);
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
        [HttpPost]
        public JsonResult AddUserProductPoint(int productId,int userId,int pointProduct)
        {
            //_userService.UpdatePointUser(userId, 100);
            // Cập nhật trong bảng UserProduct
            var result = _productService.AddUserPointProduct(productId, userId);

            if (result)
            {
                var userString = _httpContextAccessor.HttpContext.Session.GetString("UserInfor");
                var _user = new UserModelView();               
                if (userString != null)
                {
                    _user = JsonConvert.DeserializeObject<UserModelView>(userString);
                    if (_user.TotalPoint.HasValue && _user.TotalPoint.Value > 0)
                    {
                        int point = _user.TotalPoint.Value - pointProduct;
                        if (point <=0)
                        {
                            point = 0;
                        }
                        _userService.UpdatePointUser(userId, point);
                        _user.TotalPoint = point;

                        _httpContextAccessor.HttpContext.Session.SetString("UserInfor", JsonConvert.SerializeObject(_user));
                    }
                  
                }
               
            }
           

            return Json(new
            {
                data = result
            });

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
