using System;
using System.Collections.Generic;
using System.Text;
using CocktailBookPro.Business.Interfaces;
using CocktailBookPro.Models.ViewModels;
using CocktailBookPro.Services.DAO;
using CocktailBookPro.Services.Models;

namespace CocktailBookPro.Business.Controllers
{
    /// <summary>
    /// It is used for user management.
    /// </summary>
    public class UserController : IUserController
    {
        private UserDAO userDAO = null;
        public UserController(UserDAO userDAO)
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

        public int GetUserByUsername(string username)
        {
            return userDAO.GetUserByUsername(username);
        }
        public void UpdateUser(RegistrationViewModel registrationViewModel, int id)
        {
            userDAO.GetUserByID(id).FirstName = registrationViewModel.FirstName;
            userDAO.GetUserByID(id).LastName = registrationViewModel.LastName;
            userDAO.GetUserByID(id).Username = registrationViewModel.Username;
            userDAO.GetUserByID(id).Birthdate = registrationViewModel.Birthdate;
            userDAO.GetUserByID(id).Email = registrationViewModel.Email;
            userDAO.GetUserByID(id).MobilePhone = registrationViewModel.MobilePhone;
            userDAO.GetUserByID(id).PasswordHash = registrationViewModel.PasswordHash;
        }
    }
}
