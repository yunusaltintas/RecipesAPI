using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Recipes.API.Filters;
using Recipes.Data.DTOs;
using Recipes.Data.Entities;
using Recipes.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.API.Controllers
{
    [Route("Service/[contoller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRecipeService _recipeService;
        private readonly ICategoryService _categoryService;
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(IMapper mapper, IRecipeService recipeService, ICategoryService categoryService,ILogger<RecipeController> logger)
        {
            _mapper = mapper;
            _recipeService = recipeService;
            _categoryService = categoryService;
            _logger = logger;
        }

        [HttpGet]
        [Route("/Service/Recipe/Filter/Categories")]
        public async Task<IActionResult> FilterCategoriesAsync()
        {
            var CategoriesDtoWithCount = await _categoryService.GetAllAsyncWithResults();

            return Ok(CategoriesDtoWithCount);
        }


        [HttpGet]
        [Route("/Service/Recipe/All")]
        public IActionResult RecipeAllAsync()
        {
            var recipe = _recipeService.GetAllRepice();

            return Ok(recipe);
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet]
        [Route("/Service/Recipe/All/{id}")]
        public IActionResult RecipeByIdAsync(int id)
        {
            var recipe = _recipeService.GetRecipeById(id);
            return Ok(recipe);
        }

        [HttpPost]
        [Route("/Service/Recipe/All")]

        public async Task<IActionResult> SaveAsync([FromBody]RecipesDto recipeDto)
        {
            var result=await _recipeService.AddRecipe(recipeDto);

            return Created("", result);
        }

        [HttpPut]
        [Route("/Service/Recipe/All")]
        public IActionResult Update(RecipeDto recipeDto)
        {
            var result = _recipeService.UpdateRecipe(recipeDto);

            return Ok(result);
        }

    }
}
