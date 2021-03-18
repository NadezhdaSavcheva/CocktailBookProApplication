using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class Recipes
    {
        public Recipes()
        {
            CocktailCategoriesRecipes = new HashSet<CocktailCategoriesRecipes>();
            RecipeComments = new HashSet<RecipeComments>();
            RecipeSteps = new HashSet<RecipeSteps>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }

        public virtual Logins User { get; set; }
        public virtual ICollection<CocktailCategoriesRecipes> CocktailCategoriesRecipes { get; set; }
        public virtual ICollection<RecipeComments> RecipeComments { get; set; }
        public virtual ICollection<RecipeSteps> RecipeSteps { get; set; }
    }
}
