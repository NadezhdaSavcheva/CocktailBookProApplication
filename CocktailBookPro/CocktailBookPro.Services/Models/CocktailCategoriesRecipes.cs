using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class CocktailCategoriesRecipes
    {
        public int RecipeCategoryId { get; set; }
        public int RecipeId { get; set; }

        public virtual Recipes Recipe { get; set; }
        public virtual CocktailCategories RecipeCategory { get; set; }
    }
}
