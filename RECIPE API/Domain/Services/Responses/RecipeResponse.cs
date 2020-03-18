using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public class RecipeResponse : BaseResponse<Recipe>
    {
        public RecipeResponse(Recipe recipe) : base(recipe) { }
        public RecipeResponse(string message) : base(message) { }


    }
}
