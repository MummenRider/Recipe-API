using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Repositories
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<Recipe>> ListAsync();
        Task AddRecipe(Recipe recipe);
        Task<Recipe> FindById(int recipeId);
        void Update(Recipe recipe);
    }
}
