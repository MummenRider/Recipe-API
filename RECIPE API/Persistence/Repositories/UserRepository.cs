using Microsoft.EntityFrameworkCore;
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
        public async Task AddUserAsync(User user, ERole[] eRoles)
        {
            var roleName = eRoles.Select(p => p.ToString()).ToList();
            var checkExistingRoles = await _context.Roles.Where(role => roleName.Contains(role.RoleName)).ToListAsync();

            foreach (var role in checkExistingRoles)
            {
                user.UsersRole.Add(new UserRole { RoleId = role.RoleId });
            }

            _context.Users.Add(user);
        }
    }
}
