using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.DataTransferObjects
{
    public class SaveRecipeDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public IList<string> Ingridients { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
