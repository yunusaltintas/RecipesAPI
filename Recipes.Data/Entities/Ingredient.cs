using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.Entities
{
    public class Ingredient:BaseEntity
    {
        public string IngredientName { get; set; }
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
        public int AmountId { get; set; }
        public virtual Amount Amount { get; set; }

    }
}
