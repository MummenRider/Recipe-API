﻿using System;
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
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public RecipesController(IRecipeService recipeService, IMapper mapper)
        {
            _recipeService = recipeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<RecipesDto>> ListAsync()
        {
            var recipes = await _recipeService.ListAsync();
            var resorces = _mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipesDto>>(recipes);

            return resorces;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(SaveRecipeDto recipeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            var recipe = _mapper.Map<SaveRecipeDto, Recipe>(recipeDto);
            var response = await _recipeService.AddAsync(recipe);

            if (!response.Success)
                return BadRequest(new { response.Error });

            var resource = _mapper.Map<Recipe, RecipesDto>(response.Resource);

            return Ok(resource);
        }

        [HttpPut("{recipeId}")]
        public async Task<IActionResult> UpdateAsync(int recipeId, SaveRecipeDto saveRecipeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var recipe = _mapper.Map<SaveRecipeDto, Recipe>(saveRecipeDto);
            var response = await _recipeService.UpdateAsync(recipeId, recipe);

            if (!response.Success)
                return BadRequest(new { response.Error });

            var resources = _mapper.Map<Recipe, RecipesDto>(response.Resource);

            return Ok(resources);
        }

        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> DeleteAsync(int recipeId)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var response = await _recipeService.DeleteAsync(recipeId);

            if (!response.Success)
                return BadRequest(new { response.Error });

            var resource = _mapper.Map<Recipe, RecipesDto>(response.Resource);

            return Ok(resource);
        }

    }
}