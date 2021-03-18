using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailBookPro.Presenter
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // да се подаде информация, че потребителят е влязъл в профила си
            ProfileForm myProfileForm = new ProfileForm();
            myProfileForm.Show();
        }

        private void myRecipesButton_Click(object sender, EventArgs e)
        {

        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewRecipeForm newRecipeForm = new NewRecipeForm();
            newRecipeForm.Show();
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // да се подаде информация, че се търси потребител
            SearchForm userSearchForm = new SearchForm();
            userSearchForm.Show();
        }

        private void searchRecipeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // да се подаде информация, че се търси рецепта
            SearchForm recipeSearchForm = new SearchForm();
            recipeSearchForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //изход, връща се към първата форма
        }
    }
}
