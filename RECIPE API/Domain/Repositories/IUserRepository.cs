using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(User user, ERole[] eRoles);
    }
}
