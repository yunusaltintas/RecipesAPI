using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
   public class IngredientWithAmountDto
    {
        public IngredientWithAmountDto()
        {
            Amounts = new List<string>();
        }
        public List<string> Amounts { get; set; }
        public string IngredientName { get; set; }

    }
}
