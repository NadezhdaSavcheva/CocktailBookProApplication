
namespace KursovProekt
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
            this.cocktailLabel = new System.Windows.Forms.Label();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.myRecipesButton = new System.Windows.Forms.Button();
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.searchRecipeButton = new System.Windows.Forms.Button();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cocktailLabel
            // 
            this.cocktailLabel.AutoSize = true;
            this.cocktailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cocktailLabel.Location = new System.Drawing.Point(269, 99);
            this.cocktailLabel.Name = "cocktailLabel";
            this.cocktailLabel.Size = new System.Drawing.Size(228, 31);
            this.cocktailLabel.TabIndex = 3;
            this.cocktailLabel.Text = "Здравейте, [име]";
            this.cocktailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // myProfileButton
            // 
            this.myProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myProfileButton.Location = new System.Drawing.Point(92, 177);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(189, 56);
            this.myProfileButton.TabIndex = 4;
            this.myProfileButton.Text = "Моят профил";
            this.myProfileButton.UseVisualStyleBackColor = true;
            this.myProfileButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // myRecipesButton
            // 
            this.myRecipesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myRecipesButton.Location = new System.Drawing.Point(287, 177);
            this.myRecipesButton.Name = "myRecipesButton";
            this.myRecipesButton.Size = new System.Drawing.Size(189, 56);
            this.myRecipesButton.TabIndex = 5;
            this.myRecipesButton.Text = "Моите рецепти";
            this.myRecipesButton.UseVisualStyleBackColor = true;
            this.myRecipesButton.Click += new System.EventHandler(this.myRecipesButton_Click);
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRecipeButton.Location = new System.Drawing.Point(482, 177);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(189, 56);
            this.newRecipeButton.TabIndex = 6;
            this.newRecipeButton.Text = "Публикуване на нова рецепта";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            this.newRecipeButton.Click += new System.EventHandler(this.newRecipeButton_Click);
            // 
            // searchRecipeButton
            // 
            this.searchRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchRecipeButton.Location = new System.Drawing.Point(287, 239);
            this.searchRecipeButton.Name = "searchRecipeButton";
            this.searchRecipeButton.Size = new System.Drawing.Size(189, 56);
            this.searchRecipeButton.TabIndex = 7;
            this.searchRecipeButton.Text = "Търсене на рецепти";
            this.searchRecipeButton.UseVisualStyleBackColor = true;
            this.searchRecipeButton.Click += new System.EventHandler(this.searchRecipeButton_Click);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchUserButton.Location = new System.Drawing.Point(92, 239);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(189, 56);
            this.searchUserButton.TabIndex = 8;
            this.searchUserButton.Text = "Търсене на потребители";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Location = new System.Drawing.Point(482, 239);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(189, 56);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Изход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.searchRecipeButton);
            this.Controls.Add(this.newRecipeButton);
            this.Controls.Add(this.myRecipesButton);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.cocktailLabel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cocktailLabel;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button myRecipesButton;
        private System.Windows.Forms.Button newRecipeButton;
        private System.Windows.Forms.Button searchRecipeButton;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.Button logoutButton;
    }
}