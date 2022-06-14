using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Areas.Admin.Models;
using Microsoft.AspNetCore.Session;

namespace WEBSITE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        //public bool isLogin = false;
        //public IHttpContextAccessor _httpContextAccessor;
        //public BaseController(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    var UserInfo = _httpContextAccessor.HttpContext.Session.GetString("UserInfo");
        //    if (UserInfo != null)
        //    {
        //        isLogin = true;
        //    }            
        //}
        //public IActionResult IndexBase()
        //{
        //    var UserInfo = _httpContextAccessor.HttpContext.Session.GetString("UserInfo");
        //    string url = "";
        //    if (UserInfo == null)
        //        url = "/home";

        //    return View(url);
        //    // return RedirectToPage("/home");

        //}
    }
}
