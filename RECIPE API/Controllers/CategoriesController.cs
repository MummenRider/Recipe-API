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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(
            ICategoryService categoryService,
            IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryService.ListAsync();
            var categoryDto = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);
            return categoryDto;
        }
    }
}