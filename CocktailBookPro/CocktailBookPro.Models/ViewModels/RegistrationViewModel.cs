using System;

namespace CocktailBookPro.Models.ViewModels
{
    /// <summary>
    /// Model, which contains the properties needed for the registration.
    /// </summary>
    public class RegistrationViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string PasswordHash { get; set; }
    }
}
