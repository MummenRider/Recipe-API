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

        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync([FromBody] SaveCategoryDto addCategoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var category = _mapper.Map<SaveCategoryDto, Category>(addCategoryDto);
            var response = await _categoryService.AddCategoryAsync(category);

            if (!response.Success)
                return BadRequest(new { response.Error });

            var resource = _mapper.Map<Category, SaveCategoryDto>(response.Category);

            return Ok(resource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryAsync(int id, SaveCategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var catDto = _mapper.Map<SaveCategoryDto, Category>(categoryDto);

            var request = await _categoryService.UpdateCategoryAsync(id, catDto);

            if (!request.Success)
                return BadRequest(request.Error);

            var category = _mapper.Map<Category, SaveCategoryDto>(request.Category);

            return Ok(category);
        }
    }
}