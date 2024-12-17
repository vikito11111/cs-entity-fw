﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Recipes_Code_First_Demo.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}