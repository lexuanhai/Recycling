using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Areas.Admin.Models;
using WEBSITE.Service;

namespace WEBSITE.Controllers
{
    public class AcountUserController : Controller
    {
        private readonly IUserService _userService;
        public IHttpContextAccessor _httpContextAccessor;
        public AcountUserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public JsonResult Login(UserModelView userView)
        {
            var data = _userService.GetUserByUserName(userView.UserName, userView.PassWord);
            if (data != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("UserInfor", JsonConvert.SerializeObject(data));
            }
            return Json(new { data = data });
        }
    }
}
