using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.DataTransferObjects
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
