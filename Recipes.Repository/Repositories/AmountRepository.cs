using Recipes.Data.Entities;
using Recipes.Data;
using Recipes.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Repository.Repositories
{
    public class AmountRepository : BaseRepository<Amount>, IAmountRepository
    {
        public AmountRepository(RepiceDbContext context) : base(context)
        {
        }
    }
}
