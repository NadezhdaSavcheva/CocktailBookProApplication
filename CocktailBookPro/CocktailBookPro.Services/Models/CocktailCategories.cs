using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// Stores information about the types of cocktails.
    /// </summary>
    public partial class CocktailCategories
    {
        public CocktailCategories()
        {
            CocktailCategoriesRecipes = new HashSet<CocktailCategoriesRecipes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CocktailCategoriesRecipes> CocktailCategoriesRecipes { get; set; }
    }
}
