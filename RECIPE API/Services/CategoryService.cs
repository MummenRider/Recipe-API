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
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CategoryResponse> AddCategoryAsync(Category category)
        {
            var checkCategoryName = await _categoryRepository.FindByName(category);

            if (checkCategoryName != null)
            {
                return new CategoryResponse($"Category name already exist in the database");
            }

            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.SaveChanges();

                return new CategoryResponse(category);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"An unexpected error occured: {ex.Message}");
            }
        }

        public Task<CategoryResponse> DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<CategoryResponse> UpdateCategoryAsync(int categoryId, Category category)
        {
            var existingCategoryName = await _categoryRepository.FindById(categoryId);
            if (existingCategoryName == null)
                return new CategoryResponse($"Category not found");

            existingCategoryName.CategoryName = category.CategoryName;
            try
            {
                 _categoryRepository.Update(existingCategoryName);
                await _unitOfWork.SaveChanges();
                return new CategoryResponse(category);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"An unexpected error occured: {ex.Message}");
            }
        }
    }
}
