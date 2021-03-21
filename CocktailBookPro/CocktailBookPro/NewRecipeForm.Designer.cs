
namespace CocktailBookPro
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
            this.label1 = new System.Windows.Forms.Label();
            this.cocktailNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cocktailIngedientTextBox = new System.Windows.Forms.TextBox();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cocktailRecipeTextBox = new System.Windows.Forms.TextBox();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на коктейл";
            // 
            // cocktailNameTextBox
            // 
            this.cocktailNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cocktailNameTextBox.Location = new System.Drawing.Point(12, 47);
            this.cocktailNameTextBox.Name = "cocktailNameTextBox";
            this.cocktailNameTextBox.Size = new System.Drawing.Size(310, 29);
            this.cocktailNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Съставки";
            // 
            // cocktailIngedientTextBox
            // 
            this.cocktailIngedientTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cocktailIngedientTextBox.Location = new System.Drawing.Point(12, 121);
            this.cocktailIngedientTextBox.Name = "cocktailIngedientTextBox";
            this.cocktailIngedientTextBox.Size = new System.Drawing.Size(149, 29);
            this.cocktailIngedientTextBox.TabIndex = 3;
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.ItemHeight = 21;
            this.ingredientListBox.Location = new System.Drawing.Point(12, 156);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(307, 109);
            this.ingredientListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рецепта";
            // 
            // cocktailRecipeTextBox
            // 
            this.cocktailRecipeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cocktailRecipeTextBox.Location = new System.Drawing.Point(12, 301);
            this.cocktailRecipeTextBox.Multiline = true;
            this.cocktailRecipeTextBox.Name = "cocktailRecipeTextBox";
            this.cocktailRecipeTextBox.Size = new System.Drawing.Size(307, 124);
            this.cocktailRecipeTextBox.TabIndex = 6;
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIngredientButton.Location = new System.Drawing.Point(167, 121);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(74, 29);
            this.addIngredientButton.TabIndex = 7;
            this.addIngredientButton.Text = "Добави";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeIngredientButton.Location = new System.Drawing.Point(245, 120);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(74, 29);
            this.removeIngredientButton.TabIndex = 8;
            this.removeIngredientButton.Text = "Изтрий";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            // 
            // publishButton
            // 
            this.publishButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishButton.Location = new System.Drawing.Point(203, 442);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(116, 29);
            this.publishButton.TabIndex = 9;
            this.publishButton.Text = "Публикуване";
            this.publishButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 442);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 29);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // NewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 483);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.removeIngredientButton);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.cocktailRecipeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(this.cocktailIngedientTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cocktailNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewRecipeForm";
            this.Text = "NewRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cocktailNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cocktailIngedientTextBox;
        private System.Windows.Forms.ListBox ingredientListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cocktailRecipeTextBox;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button backButton;
    }
}