using CocktailBookPro.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CocktailBookPro.Services.DAO
{
    class HomeDAO
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

        public void RegisterUser(Users newUser)
        {
            this.context.Users.Add(newUser);
            this.context.SaveChanges();
        }

        public Users Login(string username, string password)
        {
            var user = this.context.Logins
                .Include(l => l.Users)
                .Where(u => u.Username.Equals(username) && u.PasswordHash.Equals(password))
                .FirstOrDefault()?.Users;

            return user;
        }

        public bool IsUsernameFree(string username)
        {
            bool isFree = this.context.Logins.Where(u => u.Username.Equals(username)).Any();

            return isFree;
        }
    }
}
