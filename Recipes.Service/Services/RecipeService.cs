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

        public List<RecipeDto> GetAllRepice()
        {
            RecipesDto recipeDto = new RecipesDto();

            var result = _unitOfWork.RecipeRepository.Query().Include(x => x.Category).Include(x => x.Direction).Include(x => x.Ingredients).ThenInclude(x => x.Amount).ToList();


            recipeDto.Result = result.Count();
            recipeDto.Total = result.Count();


            var query = (from recipe in result
                         select new RecipeDto()
                         {
                             Title = recipe.Title,
                             Categories = (from category in recipe.Category
                                           select new CategoryDto()
                                           {
                                               CategoryName = category.CategoryName
                                           }).ToList(),
                             Direction = new DirectionDto()
                             {
                                 Step = recipe.Direction.Step
                             },
                             Ingredients = (from integredient in recipe.Ingredients
                                            select new IngredientDto()
                                            {
                                                IngredientName = integredient.IngredientName,
                                                Amount = new AmountDto()
                                                {
                                                    Quantity = integredient.Amount.Quantity,
                                                    Unit = integredient.Amount.Unit,
                                                }
                                            }).ToList()
                         }).ToList();

            return query;   
        }

        public RecipeDto GetRecipeById(int id)
        {
            var result = _unitOfWork.RecipeRepository.Query().Include(x => x.Category).Include(x => x.Direction).Include(x => x.Ingredients).ThenInclude(x => x.Amount).FirstOrDefault(x => x.Id == id);
            RecipeDto recipeDto = new RecipeDto();

            recipeDto.Title = result.Title;
            recipeDto.RecipeId = result.Id;

            recipeDto.Categories = (from category in result.Category
                                    select new CategoryDto()
                                    {
                                        CategoryId=category.Id,
                                        CategoryName = category.CategoryName
                                    }).ToList();

            recipeDto.Direction = new DirectionDto()
            {
                DirectionId=result.DirectionId,
                Step = result.Direction.Step
            };

            recipeDto.Ingredients=(from ingredient in result.Ingredients
                                   select new IngredientDto() 
                                   {
                                       IngredientId=ingredient.Id,
                                        IngredientName=ingredient.IngredientName,
                                        Amount=new AmountDto()
                                        {
                                            AmountId=ingredient.Amount.Id,
                                            Quantity=ingredient.Amount.Quantity,
                                            Unit=ingredient.Amount.Unit
                                        }
                                   }).ToList();

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

        public async Task<Recipe> UpdateRecipeAsync(int id,RecipeDto recipeDto)
        {

            var NewRecipe = await _unitOfWork.RecipeRepository.SingleOrDefaultAsync(x=>x.Id==id);
  
            NewRecipe.Title = recipeDto.Title;

            NewRecipe.Category = (from category in recipeDto.Categories
                                  select new Category()
                                  {
                                      CategoryName = category.CategoryName,
                                  }).ToList();

            NewRecipe.Ingredients = (from Ingredient in recipeDto.Ingredients
                                     select new Ingredient()
                                     {
                                         IngredientName = Ingredient.IngredientName,
                                         Amount=new Amount()
                                         {
                                             Quantity=Ingredient.Amount.Quantity,
                                             Unit=Ingredient.Amount.Unit
                                         }

                                     }).ToList();

            NewRecipe.Direction = new Direction()
            {
                Step = recipeDto.Direction.Step
            };



            var result = _unitOfWork.RecipeRepository.Update(NewRecipe);

            _unitOfWork.Commit();

            return result;
        }
    }
}
