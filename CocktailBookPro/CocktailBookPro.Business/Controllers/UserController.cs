using CocktailBookPro.Business.ViewModels;
using CocktailBookPro.Services.Interfaces;
using CocktailBookPro.Services.Models;

namespace CocktailBookPro.Business
{
    /// <summary>
    /// It is used for user management.
    /// </summary>
    public class UserController : IUserController
    {
        private IUserDAO userDAO = null;
        public UserController(IUserDAO userDAO)
        {
            this.userDAO = userDAO;
        }
        /// <summary>
        /// Used for retrieving a user's information.
        /// </summary>
        /// <param name="id"></param>
        public RegistrationViewModel GetUserByID(int id)
        {
            Users user = userDAO.GetUserByID(id);
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = user.FirstName;
            registrationViewModel.LastName = user.LastName;
            registrationViewModel.Username = user.LastName;
            registrationViewModel.Email = user.Email;

            return registrationViewModel;
        }

        public void DeleteUserByID(int id)
        {
            userDAO.DeleteUserByID(id);
        }

        public void UpdateUser(int id)
        {

        }
    }
}
