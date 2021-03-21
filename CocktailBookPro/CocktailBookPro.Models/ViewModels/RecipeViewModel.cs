using System;
using System.Collections.Generic;

namespace CocktailBookPro.Models.ViewModels
{
    public class RecipeViewModel
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
        public List<string> Comments { get; set; }
    }
}
