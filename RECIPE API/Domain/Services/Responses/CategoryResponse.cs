using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public class CategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }
        /// <summary>
        /// This will pass the parameters to base response
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="category"></param>
        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        public CategoryResponse(Category category) : this (true, String.Empty, category) { }
        public CategoryResponse(string message) : this (false, message, null) { }
  


    }
}
