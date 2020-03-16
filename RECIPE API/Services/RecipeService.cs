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
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public Task<RecipeResponse> AddAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Recipe>> ListAsync()
        {
            return await _recipeRepository.ListAsync();
        }
    }
}
