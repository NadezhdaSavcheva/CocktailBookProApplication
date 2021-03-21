using System;
using CocktailBookPro.Business.Controllers;
using System.Text;
using CocktailBookPro.Models.ViewModels;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using CocktailBookPro.Services.Models;
using System.Collections.Generic;

namespace CocktailBookPro.ConsoleApp.Menus
{
    class HomeMenu
    {
        private RecipeViewModel recipeViewModel;
        private RecipeController recipeController;
        private UserController userController;
        private HomeController homeController;
        private int userId;
        public HomeMenu(UserController userController, RecipeController recipeController,
            HomeController homeController, int userId)
        {
            this.recipeController = recipeController;
            this.userController = userController;
            this.homeController = homeController;
            this.userId = userId;
            try
            {
                MainMenu();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            finally
            {
                MainMenu();
            }
        }
        public void MainMenu()
        {
            Console.Clear();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string(' ', 8) + "Welcome");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("1. View my profile");
            Console.WriteLine("2. View my recipes");
            Console.WriteLine("3. Add new recipe");
            Console.WriteLine("4. Search users");
            Console.WriteLine("5. Search recipes");
            Console.WriteLine("6. Exit");
            Console.WriteLine(new string('-', 30));

            int option = 0;
            do
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: ShowProfile(userId); ; break;
                    case 2: ViewUserRecipes(userId); break;
                    case 3: NewRecipeInput(); break;
                    case 4:
                        string s = Console.ReadLine();
                        SearchUser(s); break;
                    case 5:
                        s = Console.ReadLine();
                        SearchRecipes(s);
                        break;
                    case 6: LoginMenu l = new LoginMenu(userController, recipeController, homeController); break;
                    default: break;
                }
            }
            while (true);

        }

        public void ShowProfile(int id)
        {
            bool isMyProfile = false;
            if (id == this.userId)
            {
                isMyProfile = true;
            }
            RegistrationViewModel profile = userController.GetUserByID(id);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string(' ', 6) + "My profile");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("First name: " + profile.FirstName);
            Console.WriteLine("Last name: " + profile.LastName);
            Console.WriteLine("Username: " + profile.Username);
            Console.WriteLine("Born: " + profile.Birthdate.ToShortDateString());
            Console.WriteLine("Email: " + profile.Email);
            Console.WriteLine("Phone number: " + profile.MobilePhone);

            Console.WriteLine("1. Back");
            Console.WriteLine("2. View user's recipes");
            if (isMyProfile)
            {
                Console.WriteLine("3. Edit");
            }
            if (Console.ReadLine() == "1")
            {
                MainMenu();
            }
            else if (Console.ReadLine() == "2")
            {
                ViewUserRecipes(id);
            }
            else if (Console.ReadLine() == "3" && isMyProfile)
            {
                EditMyProfile(profile, id);
            }
            else
            {
                ShowProfile(id);
            }

        }
        public void EditMyProfile(RegistrationViewModel profile, int id)
        {
            Console.Clear();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string(' ', 6) + "Edit profile");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("1. First name: " + profile.FirstName);
            Console.WriteLine("2. Last name: " + profile.LastName);
            Console.WriteLine("3. Username: " + profile.Username);
            Console.WriteLine("4. Born: " + profile.Birthdate.ToShortDateString());
            Console.WriteLine("5. Email: " + profile.Email);
            Console.WriteLine("6. Phone number: " + profile.MobilePhone);
            Console.WriteLine("7. Edit password");
            Console.WriteLine("8. Cancel");

            try
            {
                int option = 0;
                do
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Write("First name: ");
                            profile.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Last name: ");
                            profile.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Username: ");
                            profile.Username = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Born (dd-mm-yyyy): ");
                            string s = Console.ReadLine();
                            int day = int.Parse(s.Substring(0, 2));
                            int month = int.Parse(s.Substring(3, 2));
                            int year = int.Parse(s.Substring(6, 4));
                            profile.Birthdate = new DateTime(year, month, day);
                            break;
                        case 5:
                            Console.Write("Email: ");
                            profile.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("Phone number: ");
                            profile.MobilePhone = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("Old password: ");
                            string oldPass = HashPassword(Console.ReadLine());
                            if (oldPass == profile.PasswordHash)
                            {
                                Console.Write("New password: ");
                                profile.PasswordHash = HashPassword(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Incorrect password.");
                            }
                            break;
                        case 8:
                            ShowProfile(id); break;
                        default:
                            break;
                    }
                }
                while (true);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            finally
            {
                MainMenu();
            }
        }
        public void ViewUserRecipes(int id)
        {
            Console.Clear();

            List<Recipes> recipes = recipeController.GetUserRecipes(id);
            int n = 0;
            foreach (Recipes recipe in recipes)
            {
                Console.WriteLine((n + 1) + ". " + recipe.Name);
                n++;
            }

            int recipeId = int.Parse(Console.ReadLine());
            ViewRecipe(recipeId, id);
        }
        public void ViewRecipe(int recipeId, int id)
        {
            Console.Clear();

            bool isMyProfile = false;
            if (id == this.userId)
            {
                isMyProfile = true;
            }
            RecipeViewModel r = recipeController.GetRecipeForDisplay(recipeId, id);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string(' ', 3) + r.Name);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(r.Description);
            foreach (string s in r.Ingredients)
            {
                Console.WriteLine(s);
            }
            foreach (string s in r.Steps)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("1. Back");
            Console.WriteLine("2. View comments");
            Console.WriteLine("3. Leave a comment");
            //if (isMyProfile)
            //{
            //    Console.WriteLine("4. Edit this recipe");
            //}
            try
            {
                int option = 0;
                do
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            MainMenu(); break;
                        case 2:
                            ViewComments(recipeController.GetRecipeForDisplay(recipeId, id).Comments, recipeId, id); break;
                        case 3:
                            PostComment(recipeId, id); break;
                        default:
                            break;
                    }
                }
                while (true);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            finally
            {
                MainMenu();
            }
        }
        public void ViewComments(List<string> comments, int recipeId, int id)
        {
            Console.Clear();

            foreach (string s in comments)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(s);
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine();
            Console.WriteLine("1. Back");
            Console.WriteLine("2. Leave a comment");
            try
            {
                int option = 0;
                do
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1: MainMenu(); break;
                        case 2: PostComment(recipeId, id); break;
                        default: break;
                    }
                }
                while (true);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            finally
            {
                MainMenu();
            }
        }
        public void PostComment(int recipeId, int id)
        {
            Console.Clear();

            string content = Console.ReadLine();
            Console.Write("Y to confirm, any key to cancel");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                recipeController.AddCommentToRecipe(this.userId, content);
            }
            else ViewRecipe(recipeId, id);
        }
        public void NewRecipeInput()
        {
            Console.Clear();

            try
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(new string(' ', 5) + "Add new recipe");
                Console.WriteLine(new string('-', 30));
                Console.Write("Name of cocktail: ");
                recipeViewModel.Name = Console.ReadLine();
                Console.Write("Ingredients (ENTER when done): ");
                int n = 1;
                string element;
                do
                {
                    Console.Write(n + ". ");
                    element = Console.ReadLine();
                    recipeViewModel.Ingredients.Add(element);
                    n++;
                    Console.WriteLine();
                }
                while (element != null);
                Console.Write("Steps (ENTER when done): ");
                n = 1;
                do
                {
                    Console.Write(n + ". ");
                    element = Console.ReadLine();
                    recipeViewModel.Steps.Add(element);
                    n++;
                    Console.WriteLine();
                }
                while (element != null);
                Console.Write("Description of cocktail: ");
                recipeViewModel.Description = Console.ReadLine();

                Console.WriteLine("Success. Press any key to continue");
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            finally
            {
                MainMenu();
            }
        }
        public void DisplayRecipeSearchResults(List<RecipeViewModel> recipes)
        {
            Console.Clear();

            int n = 1;
            foreach(RecipeViewModel r in recipes)
            {
                Console.WriteLine(n + ". " + r.Name);
            }

            int recipeId = int.Parse(Console.ReadLine());
            
            //ViewRecipe(recipeId, );
        }
        public List<RecipeViewModel> SearchRecipes(string query)
        {
            List<Recipes> recipes = this.recipeController.GetRecipesByName(query);
            List<RecipeViewModel> results = new List<RecipeViewModel>();
            foreach(Recipes recipe in recipes)
            {
                RecipeViewModel r = recipeController.GetRecipeForDisplay(recipe.Id, (int)recipe.UserId);
                results.Add(r);
            }
            return results;
        }
        public RegistrationViewModel SearchUser(string query)
        {
            int id = this.userController.GetUserByUsername(query);
            return this.userController.GetUserByID(id);
        }
        public bool IsStringValid(string input)
        {
            string validCharacterPattern = @"^[a-z A-Z]+$";
            return Regex.IsMatch(input, validCharacterPattern);
        }
        private string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }
    }

}
