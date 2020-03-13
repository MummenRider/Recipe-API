using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.DataTransferObjects
{
    public class SaveCategoryDto
    {
        [MaxLength(50)]
        [Required]
        public string CategoryName { get; set; }
    }
}
