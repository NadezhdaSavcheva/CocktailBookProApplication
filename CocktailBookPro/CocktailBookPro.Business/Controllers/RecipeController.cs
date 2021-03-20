using CocktailBookPro.Services.DAO;
using CocktailBookPro.Services.Models;
using System.Collections.Generic;

namespace CocktailBookPro.Business
{
    class RecipeController
    {
        private readonly RecipeDAO recipeDAO;
        private readonly UserDAO userDAO;

        public RecipeController(RecipeDAO recipeDAO, UserDAO userDAO)
        {
            this.recipeDAO = recipeDAO;
            this.userDAO = userDAO;
        }

        public int AddRecipe(string name, int userID, string description)
        {
            return this.recipeDAO.AddRecipe(name, userID, description);
        }

        public int DeleteRecipe(int userID)
        {
            int recipeID = this.recipeDAO.GetRecipeID(userID);
            return this.recipeDAO.DeleteRecipeByID(recipeID);
        }

        public List<Recipes> GetUserRecipes(int userID)
        {
            return this.recipeDAO.GetUserRecipes(userID);
        }

        public List<Recipes> GetAllRecipes()
        {
            return this.recipeDAO.GetAllRecipes();
        }

        public Recipes GetLastRecipe(int userID)
        {
            return this.recipeDAO.GetLastRecipe(userID);
        }

        public List<Recipes> GetRecipesByName(string recipeName)
        {
            return this.recipeDAO.GetRecipesByName(recipeName);
        }

        public List<Recipes> GetRecipesByIngredients(string ingredientName)
        {
            return this.recipeDAO.GetRecipesByIngredients(ingredientName);
        }

        public List<Recipes> GetRecipesByCategory(string categoryName)
        {
            return this.recipeDAO.GetRecipesByCategory(categoryName);
        }

        public int AddRecipeStep(int userID, int stepNumber, string description)
        {
            RecipeSteps newRecipeStep = new RecipeSteps();
            newRecipeStep.RecipeId = this.recipeDAO.GetRecipeID(userID);
            newRecipeStep.StepNumber = stepNumber;
            newRecipeStep.Description = description;
            return this.recipeDAO.AddRecipeSteps(newRecipeStep);
        }

        public int AddRecipeIngredients(int userID, string ingredientName, int amount, string unit)
        {
            RecipeIngredients recipeIngredient = new RecipeIngredients();
            recipeIngredient.RecipeId = this.recipeDAO.GetRecipeID(userID);
            recipeIngredient.IngredientId = this.recipeDAO.GetIngredientID(ingredientName);
            recipeIngredient.Amount = amount;
            recipeIngredient.Unit = unit;

            return this.recipeDAO.AddRecipeIngredients(recipeIngredient);
        }

        public int AddCommentToRecipe(int userID, string content)
        {
            RecipeComments newComment = new RecipeComments();
            newComment.RecipeId = this.recipeDAO.GetRecipeID(userID);
            newComment.UserId = userID;
            newComment.Content = content;

            return this.recipeDAO.AddCommentToRecipe(newComment);
        }
    }
}