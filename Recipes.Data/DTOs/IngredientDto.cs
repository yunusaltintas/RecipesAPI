using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
    public class IngredientDto
    {
        public IngredientDto()
        {
            Amount = new List<string>();
        }
        public string IngredientName { get; set; }

        public virtual List<string> Amount { get; set; }
    }
}
