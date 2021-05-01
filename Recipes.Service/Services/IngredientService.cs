using Recipes.Data.Entities;
using Recipes.Repository.IRepositories;
using Recipes.Service.IServices;
using Recipes.Service.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes.Service.Services
{
    public class IngredientService : BaseService<Ingredient>,IIngredientService
    {
        public IngredientService(IUnitOfWork unitOfWork, IBaseRepository<Ingredient> repository) : base(unitOfWork, repository)
        {
        }

    }
}
