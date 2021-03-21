using CocktailBookPro.Services.Interfaces;
using CocktailBookPro.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBookPro.Services.DAO
{
    /// <summary>
    /// Data Access Object related to the users.
    /// </summary>
    public class UserDAO : IUserDAO
    {
        private CocktailBookProDBContext context;

        public UserDAO(CocktailBookProDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Error: Context cannot be null");
            }

            this.context = context;
        }

        /// <summary>
        /// Gets the user, using their id from the data base.
        /// </summary>
        /// <param name="id">The id of the user.</param>
        /// <returns>The user with this id.</returns>
        public Users GetUserByID(int id)
        {
            return this.context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        /// <summary>
        /// Gets the first name of the user, using their id from the data base.
        /// </summary>
        /// <param name="id">The id of the user.</param>
        /// <returns>The first name.</returns>
        public string GetUserFirstName(int id)
        {
            return this.context.Users.Where(u => u.Id.Equals(id)).Select(v => v.FirstName).FirstOrDefault();
        }

        /// <summary>
        /// Deletes a user, using their id from the data base.
        /// </summary>
        /// <param name="id">The id of the user.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public int DeleteUserByID(int id)
        {
            var user = this.context.Logins.Where(u => u.Id.Equals(id)).Include(v => v.Users);
            this.context.Remove(user);

            return this.context.SaveChanges();
        }

        /// <summary>
        /// Gets the id of a user, using their username and password from the data base.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>The id of the user.</returns>
        public int GetUserID(string username, string password)
        {
            var userID = this.context.Logins.Where(u => u.Username.Equals(username) && u.PasswordHash.Equals(password))
                                            .Select(v => v.Id).FirstOrDefault();

            return userID;
        }

        /// <summary>
        /// Gets all the users from the data base.
        /// </summary>
        /// <returns>A list with the users.</returns>
        public List<Users> GetAllUsers()
        {
            return this.context.Users.ToList();
        }

        /// <summary>
        /// Gets a user, using their username from the data base.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>The user.</returns>
        public int GetUserByUsername(string username)
        {
            return this.context.Users.Where(u => u.Username.Equals(username)).Select(v => v.Id).FirstOrDefault();
        }
    }
}
