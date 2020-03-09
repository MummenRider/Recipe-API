using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public IList<string> Ingridients { get; set; }

        //FK
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
