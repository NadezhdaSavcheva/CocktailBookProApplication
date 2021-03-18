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
    public partial class NewRecipeForm : Form
    {
        public NewRecipeForm()
        {
            InitializeComponent();
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            this.ingredientListBox.Items.Add(this.ingredientTextBox.Text);
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            this.ingredientListBox.Items.RemoveAt(this.ingredientListBox.SelectedIndex);
        }
    }
}
