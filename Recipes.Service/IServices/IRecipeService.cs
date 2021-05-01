using Recipes.Data.DTOs;
using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Service.IServices
{
    public interface IRecipeService : IBaseService<Recipe>
    {
        RecipesDto GetAllRepice();
        Task<Recipe> AddRecipe(RecipesDto recipeDto);
    }
}
