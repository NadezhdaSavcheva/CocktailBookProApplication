using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
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
