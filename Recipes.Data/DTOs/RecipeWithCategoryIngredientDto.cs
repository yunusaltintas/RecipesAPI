using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
    public class RecipeWithCategoryIngredientDto
    {
        public RecipeWithCategoryIngredientDto()
        {
            //Ingredients = new List<string>();
            //Categories = new List<string>();
            //Directions=new List<string>();
        }

        //public string Title { get; set; }
        //public List<string> Categories { get; set; }
        //public List<string> Ingredients { get; set; }
        //public List<string> Directions { get; set; }


        public string Title { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        //public virtual ICollection<Ingredient> Ingredients { get; set; }
        //public virtual Direction Direction { get; set; }


    }
}
