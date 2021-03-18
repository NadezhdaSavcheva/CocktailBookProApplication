using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class IngredientsCategoriesIngredients
    {
        public int IngredientCategoryId { get; set; }
        public int CocktailIngredientsId { get; set; }

        public virtual Ingredients CocktailIngredients { get; set; }
        public virtual IngredientsCategories IngredientCategory { get; set; }
    }
}
