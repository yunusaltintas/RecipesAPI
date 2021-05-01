using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.Entities
{
    public class Direction:BaseEntity
    {
        public string Step { get; set; }
        public virtual Recipe Recipe { get; set; }

    }
}
