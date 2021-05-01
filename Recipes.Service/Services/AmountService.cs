using Recipes.Data.Entities;
using Recipes.Repository.IRepositories;
using Recipes.Service.IServices;
using Recipes.Service.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Service.Services
{
    public class AmountService : BaseService<Amount>, IAmountService
    {
        public AmountService(IUnitOfWork unitOfWork, IBaseRepository<Amount> repository) : base(unitOfWork, repository)
        {
        }
    }
}
