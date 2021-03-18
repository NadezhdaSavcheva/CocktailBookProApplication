using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class RecipeIngredients
    {
        public int? RecipeId { get; set; }
        public int? IngredientId { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }

        public virtual Ingredients Ingredient { get; set; }
        public virtual Recipes Recipe { get; set; }
    }
}
