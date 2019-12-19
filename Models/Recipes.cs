using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeDesignFood.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Display(Name = "Recipe Title")]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Directions { get; set; }

        public string Ethnicity { get; set; }

        public string Creator { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }
    }
}
