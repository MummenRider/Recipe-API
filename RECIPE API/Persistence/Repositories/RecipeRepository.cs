using Microsoft.EntityFrameworkCore;
using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Persistence.Repositories
{
    public class RecipeRepository : BaseRepository, IRecipeRepository
    {
        public RecipeRepository(AppDbContext context) : base(context) { }

        public async Task AddRecipe(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);    
        }

        public void Delete(Recipe recipe)
        {
            _context.Recipes.Remove(recipe);
        }

        public async Task<Recipe> FindById(int recipeId)
        {
            return await _context.Recipes.Include(p => p.Category).FirstOrDefaultAsync(p => p.RecipeId == recipeId);
        }

        public async Task<IEnumerable<Recipe>> ListAsync()
        {
            return await _context.Recipes.Include(category => category.Category).ToListAsync();
        }

        public void Update(Recipe recipe)
        {
            _context.Recipes.Update(recipe);
        }
    }
}
