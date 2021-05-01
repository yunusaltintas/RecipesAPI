using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Data.DTOs
{
    public class CategoryWithResultCountDto
    {
        public CategoryWithResultCountDto()
        {
            Categories = new List<string>();
        }
        public int ResultsCount { get; set; }
        public List<string> Categories { get; set; }


       

    }
}
