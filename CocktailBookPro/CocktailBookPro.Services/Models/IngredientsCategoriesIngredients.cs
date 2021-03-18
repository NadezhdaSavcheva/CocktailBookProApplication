namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// A connecting table between the categories of ingredients and the ingredients for cocktails.
    /// </summary>
    public partial class IngredientsCategoriesIngredients
    {
        public int IngredientCategoryId { get; set; }
        public int CocktailIngredientsId { get; set; }

        public virtual Ingredients CocktailIngredients { get; set; }
        public virtual IngredientsCategories IngredientCategory { get; set; }
    }
}
