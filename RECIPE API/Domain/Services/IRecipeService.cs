using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> ListAsync();
        Task<RecipeResponse> AddAsync(Recipe recipe);
        Task<RecipeResponse> UpdateAsync(int recipeId, Recipe recipe);
        Task<RecipeResponse> DeleteAsync(int recipeId);
    }
}
