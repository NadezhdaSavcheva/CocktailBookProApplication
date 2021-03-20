using CocktailBookPro.Services.Models;

namespace CocktailBookPro.Services.Interfaces
{
    /// <summary>
    /// Interface for the HomeDAO.
    /// </summary>
    public interface IHomeDAO
    {
        public void RegisterUser(Users newUser);

        public Users Login(string username, string password);

        public bool IsUsernameFree(string username);
    }
}
