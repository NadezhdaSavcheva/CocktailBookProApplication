using CocktailBookPro.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBookPro.Services.DAO
{
    class RecipeDAO
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

        public int AddRecipe(string name, int userID, string description)
        {
            Recipes newRecipe = new Recipes();
            newRecipe.Name = name;
            newRecipe.UserId = this.context.Users.Where(u => u.Id.Equals(userID)).Select(v => v.Id).FirstOrDefault();
            newRecipe.Description = description;
            this.context.Recipes.Add(newRecipe);

            return this.context.SaveChanges();
        }

        public int GetRecipeID(int userID)
        {
            return this.context.Recipes.Where(u => u.UserId.Equals(userID)).Select(v => v.Id).FirstOrDefault();
        }

        public int DeleteRecipeByID(int id)
        {
            var recipe = this.context.Recipes.Where(u => u.Id.Equals(id))
                                             .Include(v => v.RecipeComments).Include(s => s.RecipeSteps).Include(t => t.CocktailCategoriesRecipes);
            this.context.Remove(recipe);

            return this.context.SaveChanges();
        }

        public List<Recipes> GetUserRecipes(int userID)
        {
            return this.context.Recipes.Where(u => u.UserId.Equals(userID)).Include(v => v.RecipeSteps).ThenInclude(r => r.StepNumber)
                                       .Include(s => s.RecipeComments).Include(t => t.CocktailCategoriesRecipes).ThenInclude(p => p.RecipeCategory)
                                       .ToList();
        }

        public List<Recipes> GetAllRecipes()
        {
            return this.context.Recipes.Include(v => v.RecipeSteps).ThenInclude(r => r.StepNumber).Include(s => s.RecipeComments)
                                       .Include(t => t.CocktailCategoriesRecipes).ThenInclude(p => p.RecipeCategory).ToList();
        }

        public Recipes GetLastRecipe(int userID)
        {
            return this.context.Recipes.Where(u => u.UserId.Equals(userID)).Include(v => v.RecipeSteps).ThenInclude(r => r.StepNumber)
                                       .Include(s => s.RecipeComments).Include(t => t.CocktailCategoriesRecipes).ThenInclude(p => p.RecipeCategory)
                                       .ToList().LastOrDefault();
        }

        public List<Recipes> GetRecipesByName(string recipeName)
        {
            return this.context.Recipes.Where(u => u.Name.Equals(recipeName)).ToList();
        }

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

        public int AddRecipeSteps(RecipeSteps recipeStep)
        {
            this.context.RecipeSteps.Add(recipeStep);
            return this.context.SaveChanges();
        }

        public int AddRecipeIngredients(RecipeIngredients recipeIngredients)
        {
            this.context.RecipeIngredients.Add(recipeIngredients);
            return this.context.SaveChanges();
        }

        public int AddCommentToRecipe(RecipeComments newComment)
        {
            this.context.RecipeComments.Add(newComment);
            return this.context.SaveChanges();
        }

        public int GetIngredientID(string ingredientName)
        {
            return this.context.Ingredients.Where(u => u.Name.Equals(ingredientName)).Select(v => v.Id).FirstOrDefault();
        }
    }
}
