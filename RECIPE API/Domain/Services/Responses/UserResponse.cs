using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Services.Responses
{
    public class UserResponse : BaseResponse<User>
    {
        public UserResponse(User user) : base(user) { }
        public UserResponse(string message) : base(message) { }

    }
}
