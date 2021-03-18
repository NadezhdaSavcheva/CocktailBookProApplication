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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void showRecipesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // подаване на информация за потребителя
            UserRecipesForm userRecipesForm = new UserRecipesForm();
            userRecipesForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
