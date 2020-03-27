using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RECIPE_API.DataTransferObjects;
using RECIPE_API.Domain.Models;
using RECIPE_API.Domain.Services;

namespace RECIPE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAsync(SaveUserDto saveUserDto)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            var user = _mapper.Map<SaveUserDto, User>(saveUserDto);
            var response = await _userService.AddUserAsync(user, ERole.Regular);

            if (!response.Success)
                return BadRequest(new { response.Error });

            var resource = _mapper.Map<User, UserDto>(user);

            return Ok(resource);
        }
    }
}