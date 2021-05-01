using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.Entities
{
    public class Amount:BaseEntity
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}