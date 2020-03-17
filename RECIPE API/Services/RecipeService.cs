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
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;

        public RecipeService(IRecipeRepository recipeRepository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
        {
            _recipeRepository = recipeRepository;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }
        
        public async Task<RecipeResponse> AddAsync(Recipe recipe)
        {
            var checkCategory = await _categoryRepository.FindById(recipe.CategoryId);
            if(checkCategory == null)
                return new RecipeResponse($"Category could not be found");
            try
            {
                await _recipeRepository.AddRecipe(recipe);
                await _unitOfWork.SaveChanges();

                return new RecipeResponse(recipe);
            }
            catch (Exception ex)
            {
                return new RecipeResponse($"An unexpected error occured: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Recipe>> ListAsync()
        {
            return await _recipeRepository.ListAsync();
        }

        public async Task<RecipeResponse> UpdateAsync(int recipeId, Recipe recipe)
        {
            var existingRecipe = await _recipeRepository.FindById(recipeId);
            if (existingRecipe == null)
                return new RecipeResponse($"Recipe could not be found");

            var existingCategory = await _categoryRepository.FindById(recipe.CategoryId);
            if(existingCategory == null)
                return new RecipeResponse($"Invalid category number");

            existingRecipe.Title = recipe.Title;
            existingRecipe.Summary = recipe.Summary;
            existingRecipe.ImageUrl = recipe.ImageUrl;
            existingRecipe.Ingridients = recipe.Ingridients;

            try
            {
                _recipeRepository.Update(existingRecipe);
                await _unitOfWork.SaveChanges();

                return new RecipeResponse(existingRecipe);
            }
            catch (Exception ex)
            {
                return new RecipeResponse($"An unexpected error occured: {ex.Message}");
            }
        }
    }
}
