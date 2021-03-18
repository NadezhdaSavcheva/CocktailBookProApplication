namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// Stores information about the necessary ingredients for a recipe.
    /// </summary>
    public partial class RecipeIngredients
    {
        public int? RecipeId { get; set; }
        public int? IngredientId { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }

        public virtual Ingredients Ingredient { get; set; }
        public virtual Recipes Recipe { get; set; }
    }
}
