using CocktailBookPro.Business;
using CocktailBookPro.Business.ViewModels;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CocktailBookPro.Presenter
{
    public partial class RegisterForm : Form
    {
        private HomeController homeController;
        public RegisterForm(HomeController homeController)
        {
            InitializeComponent();
            this.homeController = homeController;
        }

        /// <summary>
        /// Returns to the login form
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this.homeController);
            loginForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Confirms registration and redirects to the home form
        /// </summary>
        private void nextButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            string username = this.userNameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string email = this.emailTextBox.Text;
            string mobile = this.mobileTextBox.Text;
            DateTime birthDate = this.birthDatePicker.Value;

            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            registrationViewModel.FirstName = firstName;
            registrationViewModel.LastName = lastName;
            registrationViewModel.Username = username;
            registrationViewModel.PasswordHash = HashPassword(password);
            registrationViewModel.Email = email;
            registrationViewModel.MobilePhone = mobile;
            registrationViewModel.Birthdate = birthDate;

            this.homeController.Register(registrationViewModel);

            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Checks whether the two passwords match
        /// </summary>
        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != repeatPasswordTextBox.Text && passwordTextBox.Text != null)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Passwords don't match";
            }
            else
            {
                errorLabel.Visible = false;
            }
        }
        private string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }
    }
}