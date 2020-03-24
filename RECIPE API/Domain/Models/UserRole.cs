using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Domain.Models
{
    public class UserRole
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
