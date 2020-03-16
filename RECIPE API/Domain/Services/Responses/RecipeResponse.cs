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

        private RecipeResponse(bool success, string error, Recipe recipe) : base(success, error) { Recipe = recipe; }

        public RecipeResponse(Recipe recipe) : this(true, String.Empty, recipe) { }
        public RecipeResponse(string error) : this(true, error, null) { }

  
    }
}
