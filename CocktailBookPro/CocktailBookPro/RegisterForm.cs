using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailBookPro.Presenter
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text != this.repeatPasswordTextBox.Text)
            {
                this.errorsLabel.Text = "Паролите не съвпадат";
            }
            else
            {
                this.errorsLabel.Text = "";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
        // може да се преизползва за други полета, да се премести в Utils
        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s]");
            if (e.KeyChar != (char)Keys.Back)
            {
                if (regex.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
