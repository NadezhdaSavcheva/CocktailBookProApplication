using CocktailBookPro.Services.Models;
using System.Collections.Generic;

namespace CocktailBookPro.Business.Interfaces
{
    /// <summary>
    /// Interface for the operations related to the recipes.
    /// </summary>
    interface IRecipeController
    {
        public int AddRecipe(string name, int userID, string description);

        public int DeleteRecipe(int userID);

        public List<Recipes> GetUserRecipes(int userID);

        public List<Recipes> GetAllRecipes();

        public Recipes GetLastRecipe(int userID);

        public List<Recipes> GetRecipesByName(string recipeName);

        public List<Recipes> GetRecipesByIngredients(string ingredientName);

        public List<Recipes> GetRecipesByCategory(string categoryName);

        public int AddRecipeStep(int userID, int stepNumber, string description);

        public int AddRecipeIngredients(int userID, string ingredientName, int amount, string unit);

        public int AddCommentToRecipe(int userID, string content);
    }
}
