using CocktailBookPro.Business;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CocktailBookPro.Presenter
{
    public partial class LoginForm : Form
    {
        private HomeController homeController;
        public LoginForm(HomeController homeController)
        {
            InitializeComponent();
            this.homeController = homeController;
        }

        /// <summary>
        /// Redirects to the home form if login information is correct
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.usernameTextBox.Text;
                string password = this.passwordTextBox.Text;

                int userId = this.homeController.Login(username, HashPassword(password));

                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = error.Message;
            }
        }

        /// <summary>
        /// Redirects to the registration form
        /// </summary>
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this.homeController);
            registerForm.Show();
            this.Hide();
        }
        private string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }
    }
}