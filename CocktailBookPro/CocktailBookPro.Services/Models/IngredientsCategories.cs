using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class IngredientsCategories
    {
        public IngredientsCategories()
        {
            IngredientsCategoriesIngredients = new HashSet<IngredientsCategoriesIngredients>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<IngredientsCategoriesIngredients> IngredientsCategoriesIngredients { get; set; }
    }
}
