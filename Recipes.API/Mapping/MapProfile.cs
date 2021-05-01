using AutoMapper;
using Recipes.Data.DTOs;
using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryWithResultCountDto>();
            CreateMap<CategoryWithResultCountDto, Category>();

            CreateMap<Recipe, RecipeWithCategoryIngredientDto>();
            CreateMap<RecipeWithCategoryIngredientDto, Recipe>();

            CreateMap<Recipe, RecipeDto>();
            CreateMap<RecipeDto, Recipe>();

            CreateMap<Amount, AmountDto>();
            CreateMap<AmountDto, Amount>();

            CreateMap<Direction, DirectionDto>();
            CreateMap<DirectionDto, Direction>();

            CreateMap<Ingredient, IngredientDto>();
            CreateMap<IngredientDto, Ingredient>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
