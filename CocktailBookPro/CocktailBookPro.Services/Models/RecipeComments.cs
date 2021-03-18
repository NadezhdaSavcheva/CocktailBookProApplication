using System;
using System.Collections.Generic;

namespace CocktailBookPro.Services.Models
{
    public partial class RecipeComments
    {
        public int Id { get; set; }
        public int? RecipeId { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }

        public virtual Recipes Recipe { get; set; }
        public virtual Logins User { get; set; }
    }
}
