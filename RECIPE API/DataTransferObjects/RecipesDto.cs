using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.DataTransferObjects
{
    public class RecipesDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public IList<string> Ingridients { get; set; }
        public CategoryDto Category { get; set; }
    }
}
