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
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        public IHttpContextAccessor _httpContextAccessor;
        private readonly ICategoryService _categoryService;
        public CartController(IProductService productService,
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
            var userString = _httpContextAccessor.HttpContext.Session.GetString("UserInfor");
            var _user = new UserModelView();
            if (userString != null)
            {
                _user = JsonConvert.DeserializeObject<UserModelView>(userString);
            }
            var modelView = new CartModelView();
            var model = _productService.GetProductByUserId(_user.Id);
            if (model != null && model.Count > 0)
            {
                foreach (var item in model)
                {
                    if (item.CategoryId.HasValue && item.CategoryId.Value > 0)
                    {
                        var _category = _categoryService.GetById(item.CategoryId.Value);
                        item.CategoryName = _category.Name;
                    }
                    item.IntoPrice = item.Price - item.TotalPoint;
                }
                modelView.Products = model;
            }
            var modelTelecom = _productService.GetTelecomByUserId(_user.Id);
            if (modelTelecom != null && modelTelecom.Count > 0)
            {
                modelView.Telecoms = modelTelecom;
            }

            return View(modelView);
        }

       //public IActionResult About()
       //{
       //     return View();
       //}
       // public IActionResult Contact()
       // {
       //     return View();
       // }

       // public IActionResult ProductDetail(int id)
       // {
       //     var model = new ProductModelView();
       //     if (id > 0)
       //     {               
       //         if (id > 0)
       //         {
       //             model = _productService.GetById(id);
       //         }
       //     }
       //     return View(model);
       // }
       // public JsonResult AddUserProductPoint(int productId,int userId,int pointProduct)
       // {
       //     // Cập nhật trong bảng UserProduct
       //     var result = _productService.AddUserPointProduct(productId, userId);

       //     if (result)
       //     {
       //         var userString = _httpContextAccessor.HttpContext.Session.GetString("UserInfor");
       //         var _user = new UserModelView();               
       //         if (userString != null)
       //         {
       //             _user = JsonConvert.DeserializeObject<UserModelView>(userString);
       //             if (_user.TotalPoint.HasValue && _user.TotalPoint.Value > 0)
       //             {
       //                 int point = _user.TotalPoint.Value - pointProduct;
       //                 _userService.UpdatePointUser(userId, point);
       //             }
                  
       //         }
               
       //     }
           

       //     return Json(new
       //     {
       //         data = result
       //     });

       // }
       

    }
}
