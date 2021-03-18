using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// Stores information about the types of ingredients for the recipes.
    /// </summary>
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
