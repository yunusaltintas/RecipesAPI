using Recipes.Data;
using Recipes.Data.Entities;
using Recipes.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Repository.Repositories
{
    public class DirectionRepository : BaseRepository<Direction>, IDirectionRepository
    {
        public DirectionRepository(RepiceDbContext context) : base(context)
        {
        }
    }
}
