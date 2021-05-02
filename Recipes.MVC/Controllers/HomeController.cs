using Microsoft.AspNetCore.Mvc;
using Recipes.MVC.ApiServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly RecipeApiService _recipeApiService;

        public HomeController(RecipeApiService recipeApiService)
        {
            _recipeApiService = recipeApiService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllCategoriesAsync()
        {
            var categories = _recipeApiService.GetAllCategories();
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecipes()
        {
            var recipe = await _recipeApiService.GetAllRecipes();

            return View();
        }


    }
}