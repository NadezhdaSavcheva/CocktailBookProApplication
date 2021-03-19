using CocktailBookPro.Services.Interfaces;
using CocktailBookPro.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CocktailBookPro.Services.DAO
{
    /// <summary>
    /// Data Access Object related to the registration and the log in.
    /// </summary>
    public class HomeDAO : IHomeDAO
    {
        private CocktailBookProDBContext context;

        public HomeDAO(CocktailBookProDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Error: Context cannot be null");
            }

            this.context = context;
        }

        /// <summary>
        /// Adds new user in the data base.
        /// </summary>
        /// <param name="newUser">The information of the user who will be added.</param>
        public void RegisterUser(Users newUser)
        {
            this.context.Users.Add(newUser);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Method for the login information of a registrated user.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The hashed password of the user.</param>
        /// <returns>The user with these username and password.</returns>
        public Users Login(string username, string password)
        {
            var user = this.context.Logins
                .Include(l => l.Users)
                .Where(u => u.Username.Equals(username) && u.PasswordHash.Equals(password))
                .FirstOrDefault()?.Users;

            return user;
        }

        /// <summary>
        /// Checks if the username of the user is unused.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>True or false.</returns>
        public bool IsUsernameFree(string username)
        {
            bool isFree = this.context.Logins.Where(u => u.Username.Equals(username)).Any();

            return isFree;
        }
    }
}
