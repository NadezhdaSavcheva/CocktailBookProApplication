using CocktailBookPro.Business;
using CocktailBookPro.Presenter;
using CocktailBookPro.Services;
using CocktailBookPro.Services.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailBookPro
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CocktailBookProDBContext context = new CocktailBookProDBContext();
            HomeDAO homeDAO = new HomeDAO(context);
            UserDAO userDAO = new UserDAO(context);
            RecipeDAO recipeDAO = new RecipeDAO(context);
            HomeController homeController = new HomeController(homeDAO, recipeDAO, userDAO);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(homeController));
        }
    }
}
