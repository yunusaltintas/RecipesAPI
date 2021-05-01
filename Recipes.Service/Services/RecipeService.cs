using Microsoft.EntityFrameworkCore;
using Recipes.Data.DTOs;
using Recipes.Data.Entities;
using Recipes.Repository.IRepositories;
using Recipes.Service.IServices;
using Recipes.Service.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Service.Services
{
    public class RecipeService : BaseService<Recipe>, IRecipeService
    {
        public RecipeService(IUnitOfWork unitOfWork, IBaseRepository<Recipe> repository) : base(unitOfWork, repository)
        {
        }

        public RecipesDto GetAllRepice()
        {
            RecipesDto recipeDto = new RecipesDto();

            var result = _unitOfWork.RecipeRepository.Query().Include(x => x.Category).Include(x => x.Direction).Include(x => x.Ingredients).ThenInclude(x => x.Amount).ToList();


            recipeDto.Result = result.Count();
            recipeDto.Total = result.Count();

            recipeDto.Recipe = result.Where(x => x.Id == 1).FirstOrDefault();

            //var query = (from Recipe in result
            //             select new RecipeDto()
            //             {
            //                 Title = Recipe.Title,
            //                 Category = from x in Recipe.Category
            //                            select new CategoryDto(
            //                            {
            //                                CategoryName = x.CategoryName
            //                            }).ToList();


            //             }).ToList();


            return recipeDto;
        }

        public async Task<Recipe> AddRecipe(RecipesDto recipeDto)
        {
            Recipe NewRecipe = new Recipe();

            NewRecipe = recipeDto.Recipe;
            var result=await _unitOfWork.RecipeRepository.AddAsync(NewRecipe);

            await _unitOfWork.CommitAsync();

            return result;
        }
    }
}
