using CocktailBookPro.Business.ViewModels;

namespace CocktailBookPro.Business.Interfaces
{
    /// <summary>
    /// Interface for registration and login.
    /// </summary>
    interface IHomeController
    {
        int Login(string username, string password);
        void Register(RegistrationViewModel registrationViewModel);
    }
}
