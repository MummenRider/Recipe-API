using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public class RecipeResponse : BaseResponse
    {
        public Recipe Recipe { get; private set; }

        private RecipeResponse(bool success, string message, Recipe recipe) : base(success, message) { Recipe = recipe; }

        public RecipeResponse(Recipe recipe) : this(true, String.Empty, recipe) { }
        public RecipeResponse(string message) : this(false, message, null) { }

  
    }
}
