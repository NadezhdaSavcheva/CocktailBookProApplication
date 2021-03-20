using CocktailBookPro.Business.Interfaces;
using CocktailBookPro.Business.ViewModels;
using CocktailBookPro.Services.DAO;
using CocktailBookPro.Services.Models;

namespace CocktailBookPro.Business
{
    /// <summary>
    /// It is used to registrate and to log in users into the application.
    /// </summary>
    class HomeController : IHomeController
    {
        private HomeDAO homeDAO = null;
        private RecipeDAO recipeDAO = null;
        private UserDAO userDAO = null;
        public HomeController(HomeDAO homeDAO, RecipeDAO recipeDAO, UserDAO userDAO)
        {
            this.homeDAO = homeDAO;
            this.recipeDAO = recipeDAO;
            this.userDAO = userDAO;
        }

        /// <summary>
        /// Method for logins.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>The id of the user.</returns>
        public int Login(string username, string password)
        {
            Users user = this.homeDAO.Login(username, password);
            if (user == null)
                throw new System.Exception("Invalid information.");

            return user.Id;
        }

        /// <summary>
        /// Method for registration new user.
        /// </summary>
        /// <param name="registrationViewModel">Model, which contains the properties needed for the registration.</param>
        public void Register(RegistrationViewModel registrationViewModel)
        {
            Users newUser = new Users();
            newUser.FirstName = registrationViewModel.FirstName;
            newUser.LastName = registrationViewModel.LastName;
            newUser.Username = registrationViewModel.Username;
            newUser.Birthdate = registrationViewModel.Birthdate;
            newUser.Email = registrationViewModel.Email;
            newUser.MobilePhone = registrationViewModel.MobilePhone;
            newUser.PasswordHash = registrationViewModel.PasswordHash;

            Logins loginData = new Logins();
            loginData.Username = registrationViewModel.Username;
            loginData.PasswordHash = registrationViewModel.PasswordHash;

            this.homeDAO.RegisterUser(newUser);
        }
    }
}
