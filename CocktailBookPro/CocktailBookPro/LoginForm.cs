using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CocktailBookPro.Presenter
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            // проверка на входни данни
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // липсват аргументи
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
