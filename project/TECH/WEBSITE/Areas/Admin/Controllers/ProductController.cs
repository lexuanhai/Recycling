using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WEBSITE.Areas.Admin.Models;
using WEBSITE.Areas.Admin.Models.Search;
using WEBSITE.Data.DatabaseEntity;
using WEBSITE.Service;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace WEBSITE.Areas.Admin.Controllers
{
    //[Authorize]
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        public IHttpContextAccessor _httpContextAccessor;

        public ProductController(IProductService productService,
            IHttpContextAccessor httpContextAccessor)
        {
            _productService = productService;
            _httpContextAccessor = httpContextAccessor;

        }
        public IActionResult Index()
        {
            var UserInfo =  _httpContextAccessor.HttpContext.Session.GetString("UserInfor");           
            string url = "";
            if (UserInfo == null)
            {
                url = "/Admin/AppUsers/ViewLogin";
                return Redirect(url);
            }
            return View();           
        }
        public IActionResult AddOrUpdate()
        {
            return View();
        }
        [HttpGet]
        public  JsonResult GetById(int id)
        {
            //HttpContext
            var model = new ProductModelView();
            if (id > 0)
            {
                model =  _productService.GetById(id);
            }
            return Json(new
            {
                Data = model
            });
        }
        
        [HttpGet]
        public JsonResult GetAllPaging(ProductViewModelSearch productViewModelSearch)
        {
            var data = _productService.GetAllPaging(productViewModelSearch);
            return Json(new { data = data });
        }
        [HttpGet]
        public JsonResult GetAllProductsPaging(ProductViewModelSearch productViewModelSearch)
        {
            var data = _productService.GetAllPaging(productViewModelSearch);
            return Json(new { data = data });
        }

    }
}
