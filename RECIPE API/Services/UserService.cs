using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Services;
using RECIPE_API.Domain.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Services
{
    public class UserService : IUserService
    {

        public Task<UserResponse> AddUserAsync(User user, params ERole[] eRoles)
        {
            throw new NotImplementedException();
        }
    }
}
