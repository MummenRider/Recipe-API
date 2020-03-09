using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string RecipeName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public Category()
        {
            Recipes = new List<Recipe>();
        }
    }
}
