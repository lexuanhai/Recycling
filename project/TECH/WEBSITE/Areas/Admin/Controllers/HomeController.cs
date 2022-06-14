using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Extensions;

namespace WEBSITE.Areas.Admin.Controllers
{
    //[Authorize]
    public class HomeController : BaseController
    {
        public IHttpContextAccessor _httpContextAccessor;
        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            var UserInfo = _httpContextAccessor.HttpContext.Session.GetString("UserInfor");
            string url = "";
            if (UserInfo == null)
            {
                url = "/Admin/AppUsers/ViewLogin";
                return Redirect(url);
            }
            return View();
        }
    }
}
