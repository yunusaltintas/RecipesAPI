using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs
{
    public class RecipesDto
    {
        public RecipesDto()
        {

        }
        public int Result { get; set; }
        public int Total { get; set; }
        public virtual Recipe Recipe { get; set; }


    }
}
