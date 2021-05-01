using Recipes.Data.Entities;
using Recipes.Repository.IRepositories;
using Recipes.Service.IServices;
using Recipes.Service.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Service.Services
{
    public class DirectionService : BaseService<Direction>, IDirectionService
    {
        public DirectionService(IUnitOfWork unitOfWork, IBaseRepository<Direction> repository) : base(unitOfWork, repository)
        {
        }
    }
}
