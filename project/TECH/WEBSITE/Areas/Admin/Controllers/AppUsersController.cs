using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBSITE.Areas.Admin.Models;
using WEBSITE.Areas.Admin.Models.Search;
using WEBSITE.Service;

namespace WEBSITE.Areas.Admin.Controllers
{
    public class AppUsersController: BaseController
    {
        private readonly IUserService _userService;
        public IHttpContextAccessor _httpContextAccessor;
        public AppUsersController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
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

        [HttpGet]
        public IActionResult ViewLogin()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            var data = _userService.GetAll();
            return Json(new { data = data });
        }
        [HttpPost]
        public JsonResult UserLogin(UserModelView userView)
        {
            var data = _userService.GetUserByUserName(userView.UserName, userView.PassWord);
            if (data != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("UserInfor", JsonConvert.SerializeObject(data));
            }
            return Json(new { data = data });
        }
    }
    //public class AppUsersController : BaseController
    //{
    //    private readonly IUserService _userService;
    //    public AppUsersController(IUserService userService)
    //    {
    //        _userService = userService;
    //    }
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //    [HttpGet]
    //    public JsonResult GetAll()
    //    {
    //        var model = _userService.GetAllUser();
    //        bool isData = false;
    //        if (model != null && model.Count > 0)
    //             isData = true;
    //        return Json(new
    //        {
    //            IsData = isData,
    //            Data = model
    //        });
    //    }
    //    [HttpGet]
    //    public async Task<JsonResult> GetById(string id)
    //    {
    //        var model = new UserModelView();
    //        if (!string.IsNullOrEmpty(id))
    //        {
    //           model = await _userService.GetUserById(id);
    //        }            
    //        return Json(new
    //        {
    //            Data = model
    //        });
    //    }
    //    [HttpPost]
    //    public async Task<JsonResult> AddUser(UserModelView userModelView)
    //    {
    //        var result = await _userService.AddUser(userModelView);            
    //        return Json(new
    //        {
    //            success = result
    //        });
    //    }
    //    [HttpPost]
    //    public async Task<JsonResult> UpdateUser(UserModelView userModelView)
    //    {
    //        var result = await _userService.UpdateUser(userModelView);
    //        return Json(new
    //        {
    //            success = result
    //        });
    //    }
    //    [HttpPost]
    //    public async Task<JsonResult> DeleteUser(string userId)
    //    {
    //        var result = await _userService.DeletedUser(userId);
    //        return Json(new
    //        {
    //            success = result
    //        });
    //    }
    //}
}
