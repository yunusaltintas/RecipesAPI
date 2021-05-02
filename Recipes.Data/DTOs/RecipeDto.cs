using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
    public class RecipeDto
    {
        public string Title { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
        public DirectionDto Direction { get; set; }
    }
}
