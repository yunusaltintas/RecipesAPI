using Recipes.Data.Entities;
using Recipes.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Recipes.Repository.IRepositories;

namespace Recipes.Repository.Repositories
{
    public class IngredientRepository : BaseRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(RepiceDbContext context) : base(context)
        {
        }
    }
}
