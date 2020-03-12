using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public abstract class BaseResponse
    {
        public bool Success { get; protected set; }
        public string Error { get; protected set; }

        public BaseResponse(bool success, string error)
        {
            Success = success;
            Error = error;
        }
    }
}
