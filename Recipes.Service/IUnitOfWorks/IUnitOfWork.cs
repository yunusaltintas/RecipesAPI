using Recipes.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Service.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        IRecipeRepository RecipeRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IAmountRepository AmountRepository { get; }
        IDirectionRepository DirectionRepository { get; }

        Task CommitAsync();
        void Commit();

    }
}
