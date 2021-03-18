using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// Stores information about the ingredients that can be used in cocktails.
    /// </summary>
    public partial class Ingredients
    {
        public Ingredients()
        {
            IngredientsCategoriesIngredients = new HashSet<IngredientsCategoriesIngredients>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<IngredientsCategoriesIngredients> IngredientsCategoriesIngredients { get; set; }
    }
}
