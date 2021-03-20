using CocktailBookPro.Business.Interfaces;
using CocktailBookPro.Services.Interfaces;
using CocktailBookPro.Services.Models;
using System.Collections.Generic;

namespace CocktailBookPro.Business
{
    /// <summary>
    /// It is used for the operations related to the recipes.
    /// </summary>
    public class RecipeController : IRecipeController
    {
        private readonly IRecipeDAO recipeDAO;
        private readonly IUserDAO userDAO;

        public RecipeController(IRecipeDAO recipeDAO, IUserDAO userDAO)
        {
            this.recipeDAO = recipeDAO;
            this.userDAO = userDAO;
        }

        /// <summary>
        /// Adds new recipe to the data base.
        /// </summary>
        /// <param name="name">The name of the recipe.</param>
        /// <param name="userID">The id of the user.</param>
        /// <param name="description">The description of the recipe.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddRecipe(string name, int userID, string description)
        {
            return this.recipeDAO.AddRecipe(name, userID, description);
        }

        /// <summary>
        /// Deletes the recipe from the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int DeleteRecipe(int userID)
        {
            int recipeID = this.recipeDAO.GetRecipeID(userID);
            return this.recipeDAO.DeleteRecipeByID(recipeID);
        }

        /// <summary>
        /// Gets the recipes that are published by one user from the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetUserRecipes(int userID)
        {
            return this.recipeDAO.GetUserRecipes(userID);
        }

        /// <summary>
        /// Gets all the recipes from the application from the data base.
        /// </summary>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetAllRecipes()
        {
            return this.recipeDAO.GetAllRecipes();
        }

        /// <summary>
        /// Gets the last recipe that is published by the user from the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>The recipe.</returns>
        public Recipes GetLastRecipe(int userID)
        {
            return this.recipeDAO.GetLastRecipe(userID);
        }

        /// <summary>
        /// Get all the recipes with the same name from the data base.
        /// </summary>
        /// <param name="recipeName">The name of the recipe.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetRecipesByName(string recipeName)
        {
            return this.recipeDAO.GetRecipesByName(recipeName);
        }

        /// <summary>
        /// Get all the recipes that have a common ingredient from the data base.
        /// </summary>
        /// <param name="ingredientName">The name of the ingredient.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetRecipesByIngredients(string ingredientName)
        {
            return this.recipeDAO.GetRecipesByIngredients(ingredientName);
        }

        /// <summary>
        /// Get all the recipes that are from one category from the data base.
        /// </summary>
        /// <param name="categoryName">The name of the category.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetRecipesByCategory(string categoryName)
        {
            return this.recipeDAO.GetRecipesByCategory(categoryName);
        }

        /// <summary>
        /// Adds the steps for the preparation of a recipe to the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <param name="stepNumber">The number of the step.</param>
        /// <param name="description">The description of the step.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddRecipeStep(int userID, int stepNumber, string description)
        {
            RecipeSteps newRecipeStep = new RecipeSteps();
            newRecipeStep.RecipeId = this.recipeDAO.GetRecipeID(userID);
            newRecipeStep.StepNumber = stepNumber;
            newRecipeStep.Description = description;
            return this.recipeDAO.AddRecipeSteps(newRecipeStep);
        }

        /// <summary>
        /// Adds the ingredients that are needed for a recipe to the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <param name="ingredientName">The name of the ingredient.</param>
        /// <param name="amount">The amount of the ingredient.</param>
        /// <param name="unit">The unit of measurment for the ingredient.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddRecipeIngredients(int userID, string ingredientName, int amount, string unit)
        {
            RecipeIngredients recipeIngredient = new RecipeIngredients();
            recipeIngredient.RecipeId = this.recipeDAO.GetRecipeID(userID);
            recipeIngredient.IngredientId = this.recipeDAO.GetIngredientID(ingredientName);
            recipeIngredient.Amount = amount;
            recipeIngredient.Unit = unit;

            return this.recipeDAO.AddRecipeIngredients(recipeIngredient);
        }

        /// <summary>
        /// Adds a comment on a recipe to the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <param name="content">The content of the comment.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
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