using Recipes.Data.Entities;
using Recipes.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Recipes.Repository.IRepositories;

namespace Recipes.Repository.Repositories
{
    public class CategoryRepository:BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RepiceDbContext context) : base(context)
        {
        }
    }
}
