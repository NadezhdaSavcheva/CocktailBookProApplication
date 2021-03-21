using System;
using CocktailBookPro.Services;
using CocktailBookPro.Services.DAO;
using CocktailBookPro.Business.Controllers;
using CocktailBookPro.ConsoleApp.Menus;

namespace CocktailBookPro.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CocktailBookProDBContext context = new CocktailBookProDBContext();

            RecipeDAO recipeDAO = new RecipeDAO(context);
            UserDAO userDAO = new UserDAO(context);
            HomeDAO homeDAO = new HomeDAO(context);

            UserController userController = new UserController(userDAO);
            RecipeController recipeController = new RecipeController(recipeDAO, userDAO);
            HomeController homeController = new HomeController(homeDAO);

            LoginMenu login = new LoginMenu(userController, recipeController, homeController);
        }
    }
}
