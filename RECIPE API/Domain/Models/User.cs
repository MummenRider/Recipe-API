using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Collection of User role (Admind / Regular) user
        public ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
    }
}
