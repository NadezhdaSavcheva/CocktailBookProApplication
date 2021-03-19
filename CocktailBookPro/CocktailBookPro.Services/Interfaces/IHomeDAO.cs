using CocktailBookPro.Services.Models;

namespace CocktailBookPro.Services.Interfaces
{
    interface IHomeDAO
    {
        public void RegisterUser(Users newUser);

        public Users Login(string username, string password);

        public bool IsUsernameFree(string username);
    }
}
