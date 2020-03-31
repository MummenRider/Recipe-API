using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
        public Task<User> AddUserAsync(User user, ERole[] eRoles)
        {
            throw new NotImplementedException();
        }
    }
}
