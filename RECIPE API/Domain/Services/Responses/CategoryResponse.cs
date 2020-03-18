using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public class CategoryResponse : BaseResponse<Category>
    {

        public CategoryResponse(Category category) : base(category) { }
        public CategoryResponse(string message) : base(message) { }
  


    }
}
