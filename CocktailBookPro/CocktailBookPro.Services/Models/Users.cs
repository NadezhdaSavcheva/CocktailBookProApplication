using System;

namespace CocktailBookPro.Services.Models
{
    /// <summary>
    /// Stores information for each user.
    /// </summary>
    public partial class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string PasswordHash { get; set; }

        public virtual Logins IdNavigation { get; set; }
    }
}
