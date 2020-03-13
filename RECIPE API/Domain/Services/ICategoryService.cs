using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> AddCategoryAsync(Category category);

        Task<CategoryResponse> UpdateCategoryAsync(int id, Category category);
    }
}
