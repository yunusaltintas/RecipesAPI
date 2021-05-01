using Recipes.Data.DTOs;
using Recipes.Data.Entities;
using Recipes.Repository.IRepositories;
using Recipes.Service.IServices;
using Recipes.Service.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Service.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IBaseRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<CategoryWithResultCountDto> GetAllAsyncWithResults()
        {
            var categories = await _unitOfWork.CategoryRepository.GetAllAsync();

            CategoryWithResultCountDto categoryDto = new CategoryWithResultCountDto();
            categoryDto.ResultsCount = categories.Count();
            foreach (var item in categories)
            {
                categoryDto.Categories.Add(item.CategoryName);
            }

            return categoryDto;
        }

    }
}
