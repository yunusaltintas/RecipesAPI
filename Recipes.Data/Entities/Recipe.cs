using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.Entities
{
    public class Recipe:BaseEntity
    {
        public string Title { get; set; }
        public virtual ICollection<Category> Category{ get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public int DirectionId { get; set; }
        public virtual Direction Direction { get; set; }



    }
}
