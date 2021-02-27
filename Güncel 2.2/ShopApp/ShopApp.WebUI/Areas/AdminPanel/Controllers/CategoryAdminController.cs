using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.WebUI.Areas.AdminPanel.Models;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryAdminController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryAdminController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult CategoryList()
        {
            return View(new CategoryAdminListModel()
            {
                Categories = _categoryService.GetAll()
            });
        }



    }
}
