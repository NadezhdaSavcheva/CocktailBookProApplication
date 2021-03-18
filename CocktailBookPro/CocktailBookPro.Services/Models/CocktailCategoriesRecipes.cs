namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// A connecting table between the categories of cocktails and recipes.
    /// </summary>
    public partial class CocktailCategoriesRecipes
    {
        public int RecipeCategoryId { get; set; }
        public int RecipeId { get; set; }

        public virtual Recipes Recipe { get; set; }
        public virtual CocktailCategories RecipeCategory { get; set; }
    }
}
