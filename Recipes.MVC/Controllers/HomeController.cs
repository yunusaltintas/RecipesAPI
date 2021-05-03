using Microsoft.AspNetCore.Mvc;
using Recipes.Data.DTOs;
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
            
            return View(categories);
        }

        [HttpGet]
        public IActionResult GetAllRecipes()
        {
            var recipe = _recipeApiService.GetAllRecipes();

            return View(recipe);
        }

        [HttpGet]
        public IActionResult UpdateRecipe(int id)
        {
           var recipe= _recipeApiService.GetRecipeById(id);

            return View(recipe);
        }

        [HttpPost]
        public IActionResult UpdateRecipe(RecipeDto recipeDto)
        {
            _recipeApiService.UpdateRecipe(recipeDto);

            return View();
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRecipe(RecipeDto recipeDto)
        {
            _recipeApiService.AddRecipe(recipeDto);
            return View();
        }




    }
}