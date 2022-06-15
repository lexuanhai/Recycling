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
    public class TelecomOffersController : Controller
    {
        private readonly IProductService _productService;
        public IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        public TelecomOffersController(IProductService productService,
            IUserService userService,
        IHttpContextAccessor httpContextAccessor)
        {
            _productService = productService;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        //public IActionResult Index()
        //{
        //    var userString = _httpContextAccessor.HttpContext.Session.GetString("UserInfor");
        //    var _user = new UserModelView();
        //    if (userString != null)
        //    {
        //        _user = JsonConvert.DeserializeObject<UserModelView>(userString);
        //    }
        //    var model = _productService.GetProductByUserId(_user.Id);
        //    if (model != null && model.Count > 0)
        //    {
        //        foreach (var item in model)
        //        {
        //            if (item.CategoryId.HasValue && item.CategoryId.Value > 0)
        //            {
        //                var _category = _categoryService.GetById(item.CategoryId.Value);
        //                item.CategoryName = _category.Name;
        //            }
        //            item.IntoPrice = item.Price - item.TotalPoint;
        //        }
        //    }
        //    return View(model);
        //}
        public IActionResult TelecomOffersDetail(string name)
        {
            return View();
        }
        public JsonResult AddUserTelecom(int userId, TelecomModelView telecomModelView)
        {
            // Cập nhật trong bảng UserProduct
            var result = _productService.AddUserTelecom(userId, telecomModelView);

            if (result)
            {
                var userString = _httpContextAccessor.HttpContext.Session.GetString("UserInfor");
                var _user = new UserModelView();
                if (userString != null)
                {
                    _user = JsonConvert.DeserializeObject<UserModelView>(userString);
                    if (_user.TotalPoint.HasValue && _user.TotalPoint.Value > 0)
                    {
                        int point = _user.TotalPoint.Value - telecomModelView.Point.Value;
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



    }
}
