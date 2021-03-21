
namespace CocktailBookPro
{
    partial class HomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.myRecipesButton = new System.Windows.Forms.Button();
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(278, 90);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(224, 37);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Здравейте, [име]";
            // 
            // myProfileButton
            // 
            this.myProfileButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myProfileButton.Location = new System.Drawing.Point(112, 147);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(184, 73);
            this.myProfileButton.TabIndex = 1;
            this.myProfileButton.Text = "Моят профил";
            this.myProfileButton.UseVisualStyleBackColor = true;
            // 
            // myRecipesButton
            // 
            this.myRecipesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myRecipesButton.Location = new System.Drawing.Point(302, 147);
            this.myRecipesButton.Name = "myRecipesButton";
            this.myRecipesButton.Size = new System.Drawing.Size(184, 73);
            this.myRecipesButton.TabIndex = 2;
            this.myRecipesButton.Text = "Моите рецепти";
            this.myRecipesButton.UseVisualStyleBackColor = true;
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newRecipeButton.Location = new System.Drawing.Point(492, 147);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(184, 73);
            this.newRecipeButton.TabIndex = 3;
            this.newRecipeButton.Text = "Нова рецепта";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(399, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(184, 73);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Изход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(209, 226);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(184, 73);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Търсене";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.newRecipeButton);
            this.Controls.Add(this.myRecipesButton);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button myRecipesButton;
        private System.Windows.Forms.Button newRecipeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchButton;
    }
}