using CocktailBookPro.Services.Models;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Interfaces
{
    /// <summary>
    /// Interface for the UserDAO.
    /// </summary>
    public interface IUserDAO
    {
        public Users GetUserByID(int id);

        public string GetUserFirstName(int id);

        public int DeleteUserByID(int id);

        public int GetUserID(string username, string password);

        public List<Users> GetAllUsers();

        public string GetUserByUsername(string username);
    }
}
