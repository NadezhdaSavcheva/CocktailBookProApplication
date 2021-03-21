using CocktailBookPro.Models.ViewModels;

namespace CocktailBookPro.Business
{
    /// <summary>
    /// Interface for user management.
    /// </summary>
    interface IUserController
    {
        void DeleteUserByID(int id);
        RegistrationViewModel GetUserByID(int id);
        void UpdateUser(RegistrationViewModel registrationViewModel, int id);
    }
}
