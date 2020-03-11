using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Repositories;
using RECIPE_API.Domain.Services;
using RECIPE_API.Domain.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryResponse> AddCategoryAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddCategoryAsync(category);
                return new CategoryResponse(category);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"An unexpected error occured: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
