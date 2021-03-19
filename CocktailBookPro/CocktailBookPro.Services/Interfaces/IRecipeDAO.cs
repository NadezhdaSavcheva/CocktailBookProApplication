using CocktailBookPro.Services.Models;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Interfaces
{
    /// <summary>
    /// Interface for the RecipeDAO.
    /// </summary>
    interface IRecipeDAO
    {
        public int AddRecipe(string name, int userID, string description);

        public int GetRecipeID(int userID);

        public int DeleteRecipeByID(int id);

        public List<Recipes> GetUserRecipes(int userID);

        public List<Recipes> GetAllRecipes();

        public Recipes GetLastRecipe(int userID);

        public List<Recipes> GetRecipesByName(string recipeName);

        public List<Recipes> GetRecipesByIngredients(string ingredientName);

        public List<Recipes> GetRecipesByCategory(string categoryName);

        public int AddRecipeSteps(RecipeSteps recipeStep);

        public int AddRecipeIngredients(RecipeIngredients recipeIngredients);

        public int AddCommentToRecipe(RecipeComments newComment);

        public int GetIngredientID(string ingredientName);
    }
}
