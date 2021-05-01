using Recipes.Repository.IRepositories;
using Recipes.Service.IUnitOfWorks;
using Recipes.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Recipes.Data;

namespace Recipes.Service.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepiceDbContext _context;
        private RecipeRepository _recipeRepository;
        private IngredientRepository _ingredientRepository;
        private CategoryRepository _categoryRepository;
        private AmountRepository _amountRepository;
        private DirectionRepository _directionRepository;
        public UnitOfWork(RepiceDbContext repiceDbContext)
        {
            _context = repiceDbContext;
        }

        public IRecipeRepository RecipeRepository => _recipeRepository = _recipeRepository ?? new RecipeRepository(_context);

        public ICategoryRepository CategoryRepository => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public IAmountRepository AmountRepository => _amountRepository = _amountRepository ?? new AmountRepository(_context);

        public IIngredientRepository IngredientRepository => _ingredientRepository = _ingredientRepository ?? new IngredientRepository(_context);

        public IDirectionRepository DirectionRepository => _directionRepository = _directionRepository ?? new DirectionRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
