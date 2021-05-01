using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
    public class RecipeDto
    {
        public string Title { get; set; }
        public virtual ICollection<CategoryDto> Category { get; set; }
        public virtual ICollection<IngredientDto> Ingredients { get; set; }
        public virtual DirectionDto Direction { get; set; }
    }
}
