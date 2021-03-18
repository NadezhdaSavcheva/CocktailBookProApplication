
namespace KursovProekt
{
    partial class NewRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cocktailNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.ingredientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cocktailNameTextBox
            // 
            this.cocktailNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cocktailNameTextBox.Location = new System.Drawing.Point(12, 38);
            this.cocktailNameTextBox.Name = "cocktailNameTextBox";
            this.cocktailNameTextBox.Size = new System.Drawing.Size(297, 38);
            this.cocktailNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Име на коктейл";
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeTextBox.Location = new System.Drawing.Point(16, 236);
            this.recipeTextBox.Multiline = true;
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.Size = new System.Drawing.Size(293, 142);
            this.recipeTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Рецепта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Съставки";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(16, 400);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 49);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // publishButton
            // 
            this.publishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishButton.Location = new System.Drawing.Point(163, 400);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(146, 49);
            this.publishButton.TabIndex = 10;
            this.publishButton.Text = "Публикуване";
            this.publishButton.UseVisualStyleBackColor = true;
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.Location = new System.Drawing.Point(16, 141);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(293, 69);
            this.ingredientListBox.TabIndex = 12;
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(137, 106);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(83, 29);
            this.addIngredientButton.TabIndex = 13;
            this.addIngredientButton.Text = "Добави";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.Location = new System.Drawing.Point(226, 106);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(83, 29);
            this.removeIngredientButton.TabIndex = 14;
            this.removeIngredientButton.Text = "Изтрий";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // ingredientTextBox
            // 
            this.ingredientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientTextBox.Location = new System.Drawing.Point(16, 106);
            this.ingredientTextBox.Name = "ingredientTextBox";
            this.ingredientTextBox.Size = new System.Drawing.Size(115, 26);
            this.ingredientTextBox.TabIndex = 15;
            // 
            // NewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.ingredientTextBox);
            this.Controls.Add(this.removeIngredientButton);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recipeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cocktailNameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "NewRecipeForm";
            this.Text = "Публикуване на нова рецепта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cocktailNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.TextBox ingredientTextBox;
    }
}