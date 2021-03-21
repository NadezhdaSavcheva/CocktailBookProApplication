using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CocktailBookPro.Business.Controllers;
using CocktailBookPro.Models.ViewModels;

namespace CocktailBookPro.ConsoleApp.Menus
{
    class LoginMenu
    {
        private UserController userController;
        private RecipeController recipeController;
        private HomeController homeController;

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string(' ', 7) + "CocktailBookPro");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.WriteLine(new string('-', 30));
        }

        public void Login()
        {
            Console.Clear();
            try
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = HashPassword(Console.ReadLine());
                int id = homeController.Login(username, password);
                HomeMenu homeMenu = new HomeMenu(this.userController, this.recipeController, this.homeController,
                    this.userController.GetUserByUsername(username));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }

        public void Register()
        {
            Console.Clear();
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            if (!this.IsStringValid(firstName)) throw new FormatException("Incorrect format");
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            if (!this.IsStringValid(lastName)) throw new FormatException("Incorrect format");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            if (!this.IsStringValid(username)) throw new FormatException("Incorrect format");
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = HashPassword(Console.ReadLine());
            Console.Write("Repeat password: ");
            string repeatPassword = HashPassword(Console.ReadLine());
            if (password != repeatPassword) throw new FormatException("Passwords do not match");
            Console.Write("Birthdate: ");
            string s = Console.ReadLine();
            string s1 = s.Substring(0, 2);
            string s2 = s.Substring(3, 2);
            string s3 = s.Substring(6, 4);
            int day = int.Parse(s.Substring(0, 2));
            int month = int.Parse(s.Substring(3, 2));
            int year = int.Parse(s.Substring(6, 4));
            DateTime birthdate = new DateTime(year, month, day);
            Console.Write("Phone number: ");
            string mobile = Console.ReadLine();

            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = firstName;
            registrationViewModel.LastName = lastName;
            registrationViewModel.Username = username;
            registrationViewModel.Email = email;
            registrationViewModel.PasswordHash = password;
            registrationViewModel.Birthdate = birthdate;
            registrationViewModel.MobilePhone = mobile;

            this.homeController.Register(registrationViewModel);
            HomeMenu homeMenu = new HomeMenu(this.userController, this.recipeController, this.homeController,
                this.userController.GetUserByUsername(username));
        }
        public LoginMenu(UserController userController, RecipeController recipeController, HomeController homeController)
        {
            if (userController == null) throw new ArgumentNullException("userController");
            if (recipeController == null) throw new ArgumentNullException("recipeController");
            if (homeController == null) throw new ArgumentNullException("homeController");
            this.userController = userController;
            this.recipeController = recipeController;
            this.homeController = homeController;

            DisplayMenu();
            int option = 0;
            do
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: Login(); break;
                    case 2: Register(); break;
                }
            }
            while (option != 3);
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
