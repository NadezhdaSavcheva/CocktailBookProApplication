using CocktailBookPro.Services.Interfaces;
using CocktailBookPro.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBookPro.Services.DAO
{
    /// <summary>
    /// Data Access Object related to the recipes.
    /// </summary>
    public class RecipeDAO : IRecipeDAO
    {
        private CocktailBookProDBContext context;

        public RecipeDAO(CocktailBookProDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Error: Context cannot be null");
            }

            this.context = context;
        }

        /// <summary>
        /// Adds new recipe in the data base.
        /// </summary>
        /// <param name="name">The name of the recipe.</param>
        /// <param name="userID">The id of the user.</param>
        /// <param name="description">The description of the recipe.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddRecipe(string name, int userID, string description)
        {
            Recipes newRecipe = new Recipes();
            newRecipe.Name = name;
            newRecipe.UserId = this.context.Users.Where(u => u.Id.Equals(userID)).Select(v => v.Id).FirstOrDefault();
            newRecipe.Description = description;
            this.context.Recipes.Add(newRecipe);

            return this.context.SaveChanges();
        }
        public int AddRecipe(Recipes recipe, int userID, List<string> steps, List<string> ingredients)
        {
            List<RecipeSteps> recipeSteps = new List<RecipeSteps>();
            foreach(string step in steps)
            {
                RecipeSteps r = new RecipeSteps();
                r.Description = step;
                r.RecipeId = recipe.Id;
                r.Recipe = recipe;
                recipeSteps.Add(r);
            }
            List<RecipeIngredients> recipeIngredients = new List<RecipeIngredients>();
            foreach (string ingredient in ingredients)
            {
                RecipeIngredients i = new RecipeIngredients();
                i.RecipeId = recipe.Id;
                i.Recipe = recipe;
                Ingredients ingr = new Ingredients();
                i.Ingredient = ingr;
                ingr.Name = ingredient;
                recipeIngredients.Add(i);
            }
            recipe.RecipeSteps = recipeSteps;
            this.context.Recipes.Add(recipe);

            return this.context.SaveChanges();
        }

        /// <summary>
        /// Gets the id of the recipe from the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>The id of the recipe.</returns>
        public int GetRecipeID(int userID)
        {
            return this.context.Recipes.Where(u => u.UserId.Equals(userID)).Select(v => v.Id).FirstOrDefault();
        }

        /// <summary>
        /// Deletes the recipe from the data base, using its id.
        /// </summary>
        /// <param name="id">The id of the recipe.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int DeleteRecipeByID(int id)
        {
            var recipe = this.context.Recipes.Where(u => u.Id.Equals(id))
                                             .Include(v => v.RecipeComments).Include(s => s.RecipeSteps).Include(t => t.CocktailCategoriesRecipes);
            this.context.Remove(recipe);

            return this.context.SaveChanges();
        }

        /// <summary>
        /// Gets the recipes that are published by one user from the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetUserRecipes(int userID)
        {
            //return this.context.Recipes.Where(u => u.UserId.Equals(userID)).Include(v => v.RecipeSteps).ThenInclude(r => r.StepNumber)
            //                           .Include(s => s.RecipeComments).Include(t => t.CocktailCategoriesRecipes).ThenInclude(p => p.RecipeCategory)
            //                           .ToList();
            return this.context.Recipes.ToList();
        }

        /// <summary>
        /// Gets all the recipes from the application from the data base.
        /// </summary>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetAllRecipes()
        {
            return this.context.Recipes.Include(v => v.RecipeSteps).ThenInclude(r => r.StepNumber).Include(s => s.RecipeComments)
                                       .Include(t => t.CocktailCategoriesRecipes).ThenInclude(p => p.RecipeCategory).ToList();
        }

        /// <summary>
        /// Gets the last recipe that is published by the user from the data base.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>The recipe.</returns>
        public Recipes GetLastRecipe(int userID)
        {
            return this.context.Recipes.Where(u => u.UserId.Equals(userID)).Include(v => v.RecipeSteps).ThenInclude(r => r.StepNumber)
                                       .Include(s => s.RecipeComments).Include(t => t.CocktailCategoriesRecipes).ThenInclude(p => p.RecipeCategory)
                                       .ToList().LastOrDefault();
        }


        /// <summary>
        /// Get all the recipes with the same name from the data base.
        /// </summary>
        /// <param name="recipeName">The name of the recipe.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetRecipesByName(string recipeName)
        {
            return this.context.Recipes.Where(u => u.Name.Equals(recipeName)).ToList();
        }

        /// <summary>
        /// Get all the recipes that have a common ingredient from the data base.
        /// </summary>
        /// <param name="ingredientName">The name of the ingredient.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetRecipesByIngredients(string ingredientName)
        {
            var recipes = new List<Recipes>();
            var recipeIDs = this.context.RecipeIngredients.Where(u => u.Ingredient.Equals(ingredientName)).Select(v => v.RecipeId).ToList();
            for (int i = 0; i < recipeIDs.Count; i++)
            {
                recipes = this.context.Recipes.Where(t => t.Id.Equals(recipeIDs[i])).ToList();
            }

            return recipes;
        }

        /// <summary>
        /// Get all the recipes that are from one category from the data base.
        /// </summary>
        /// <param name="categoryName">The name of the category.</param>
        /// <returns>A list with the recipes.</returns>
        public List<Recipes> GetRecipesByCategory(string categoryName)
        {
            var recipes = new List<Recipes>();
            var recipeIDs = this.context.CocktailCategoriesRecipes.Where(u => u.RecipeCategory.Equals(categoryName)).Select(v => v.RecipeId).ToList();
            for (int i = 0; i < recipeIDs.Count; i++)
            {
                recipes = this.context.Recipes.Where(t => t.Id.Equals(recipeIDs[i])).ToList();
            }

            return recipes;
        }

        /// <summary>
        /// Adds the steps for the preparation of a recipe to the data base.
        /// </summary>
        /// <param name="recipeStep">A step from the preparation of a recipe.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddRecipeSteps(RecipeSteps recipeStep)
        {
            this.context.RecipeSteps.Add(recipeStep);
            return this.context.SaveChanges();
        }

        /// <summary>
        /// Adds the ingredients that are needed for a recipe to the data base.
        /// </summary>
        /// <param name="recipeIngredients">The needed ingredients.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddRecipeIngredients(RecipeIngredients recipeIngredients)
        {
            this.context.RecipeIngredients.Add(recipeIngredients);
            return this.context.SaveChanges();
        }

        /// <summary>
        /// Adds a comment on a recipe to the data base.
        /// </summary>
        /// <param name="newComment">The new recipe comment.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int AddCommentToRecipe(RecipeComments newComment)
        {
            this.context.RecipeComments.Add(newComment);
            return this.context.SaveChanges();
        }

        /// <summary>
        /// Gets the id of a ingredient, using its name from the data base.
        /// </summary>
        /// <param name="ingredientName">The name of the ingredient.</param>
        /// <returns>The id of the ingredient.</returns>
        public int GetIngredientID(string ingredientName)
        {
            return this.context.Ingredients.Where(u => u.Name.Equals(ingredientName)).Select(v => v.Id).FirstOrDefault();
        }

        public List<RecipeIngredients> GetAllIngredients()
        {
            return this.context.RecipeIngredients.ToList();
        }
        public List<RecipeIngredients> GetAllIngredientsForRecipe(int recipeId)
        {
            return this.context.RecipeIngredients.ToList().Where(x => x.RecipeId == recipeId).ToList();
        }
        public List<RecipeSteps> GetAllStepsForRecipe(int recipeId)
        {
            return this.context.RecipeSteps.ToList().Where(x => x.RecipeId == recipeId).ToList();
        }
        public List<RecipeComments> GetAllCommentsForRecipe(int recipeId)
        {
            return this.context.RecipeComments.ToList().Where(x => x.RecipeId == recipeId).ToList();
        }
        public Recipes GetRecipe(int recipeId, int userId)
        {
            return this.context.Recipes.Where(x => x.UserId == userId).Where(y => y.Id == recipeId).FirstOrDefault();
        }
    }
}
