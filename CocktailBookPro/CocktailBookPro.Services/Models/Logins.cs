using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class Logins
    {
        public Logins()
        {
            RecipeComments = new HashSet<RecipeComments>();
            Recipes = new HashSet<Recipes>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public virtual Users Users { get; set; }
        public virtual ICollection<RecipeComments> RecipeComments { get; set; }
        public virtual ICollection<Recipes> Recipes { get; set; }
    }
}
