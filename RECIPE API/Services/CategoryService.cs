using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IEnumerable<Category>> ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
