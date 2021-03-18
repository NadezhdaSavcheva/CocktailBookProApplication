using CocktailBookPro.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBookPro.Services.DAO
{
    class UserDAO
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

        public Users GetUserByID(int id)
        {
            return this.context.Users.Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public string GetUserFirstName(int id)
        {
            return this.context.Users.Where(u => u.Id.Equals(id)).Select(v => v.FirstName).FirstOrDefault();
        }

        public int DeleteUserByID(int id)
        {
            var user = this.context.Logins.Where(u => u.Id.Equals(id)).Include(v => v.Users);
            this.context.Remove(user);

            return this.context.SaveChanges();
        }

        public int GetUserID(string username, string password)
        {
            var userID = this.context.Logins.Where(u => u.Username.Equals(username) && u.PasswordHash.Equals(password))
                                            .Select(v => v.Id).FirstOrDefault();

            return userID;
        }

        public List<Users> GetAllUsers()
        {
            return this.context.Users.ToList();
        }

        public string SearchForUserByUsername(string username)
        {
            return this.context.Users.Where(u => u.Username.Equals(username)).Select(v => v.Username).FirstOrDefault();
        }
    }
}
