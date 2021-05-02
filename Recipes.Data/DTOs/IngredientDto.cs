using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
    public class IngredientDto
    {

        public string IngredientName { get; set; }

        public AmountDto Amount { get; set; }
    }
}
