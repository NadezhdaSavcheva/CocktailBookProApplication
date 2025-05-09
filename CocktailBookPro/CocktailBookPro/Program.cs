using CocktailBookPro.Services;
using CocktailBookPro.Services.DAO;
using CocktailBookPro.Business.Controllers;
using System;
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
            HomeController homeController = new HomeController(homeDAO);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(homeController));
        }
    }
}
