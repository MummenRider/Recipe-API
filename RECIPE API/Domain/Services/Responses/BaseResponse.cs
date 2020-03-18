using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public abstract class BaseResponse<T>
    {
        public bool Success { get; private set; }
        public string Error { get; private set; }
        public T Resource { get; private set; }

        protected BaseResponse(T resource)
        {
            Success = true;
            Error = string.Empty;
            Resource = resource;
        }

        protected BaseResponse(string error)
        {
            Success = false;
            Error = error;
            Resource = default;
        }
    }
}
