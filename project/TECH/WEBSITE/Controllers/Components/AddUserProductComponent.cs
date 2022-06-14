using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITE.Controllers.Components
{
    public class AddUserProductComponent : ViewComponent
    {

        //private readonly IProductService _productService;
        //public IHttpContextAccessor _httpContextAccessor;
        //public SideBarViewComponent(IProductService productService,
        //    IHttpContextAccessor httpContextAccessor)
        //{
        //    _productService = productService;
        //    _httpContextAccessor = httpContextAccessor;
        //}
        ////private ICategoryService _categoryService;

        ////public SideBarViewComponent(ICategoryService categoryService)
        ////{
        ////    _categoryService = categoryService;
        ////}

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    //var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
        //    //List<FunctionViewModel> functions;
        //    //if (roles.Split(";").Contains(CommonConstants.AdminRole))
        //    //{
        //    //    functions = await _functionService.GetAll();
        //    //}
        //    //else
        //    //{
        //    //    //TODO: Get by permission
        //    //    functions = new List<FunctionViewModel>();
        //    //}
        //    var categoryModel = _categoryService.GetAll();
        //    return View(categoryModel);
        //}
    }
}
