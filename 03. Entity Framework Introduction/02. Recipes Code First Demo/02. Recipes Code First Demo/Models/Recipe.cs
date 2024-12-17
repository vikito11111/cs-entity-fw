using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Recipes_Code_First_Demo.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}