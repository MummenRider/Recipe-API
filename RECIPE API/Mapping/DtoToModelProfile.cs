using AutoMapper;
using RECIPE_API.DataTransferObjects;
using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Mapping
{
    public class DtoToModelProfile: Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<SaveCategoryDto, Category>();

            CreateMap<RecipesDto, Recipe>();
        }
    }
}
