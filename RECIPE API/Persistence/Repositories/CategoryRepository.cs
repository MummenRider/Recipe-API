using Microsoft.EntityFrameworkCore;
using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context) { }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<Category> FindByName(Category category)
        {
            return await _context.Categories.FirstOrDefaultAsync(p => p.CategoryName == category.CategoryName);
        }

        /// <summary>
        /// Get all the categories from the database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
