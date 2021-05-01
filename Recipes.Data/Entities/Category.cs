using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
