
namespace CocktailBookPro.Presenter
{
    partial class CocktailForm
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
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.publishCommentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cocktailLabel
            // 
            this.cocktailLabel.AutoSize = true;
            this.cocktailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cocktailLabel.Location = new System.Drawing.Point(57, 22);
            this.cocktailLabel.Name = "cocktailLabel";
            this.cocktailLabel.Size = new System.Drawing.Size(227, 31);
            this.cocktailLabel.TabIndex = 2;
            this.cocktailLabel.Text = "Име на коктейла";
            this.cocktailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientsLabel.Location = new System.Drawing.Point(15, 74);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(83, 20);
            this.ingredientsLabel.TabIndex = 3;
            this.ingredientsLabel.Text = "Съставки";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeLabel.Location = new System.Drawing.Point(15, 216);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(73, 20);
            this.recipeLabel.TabIndex = 4;
            this.recipeLabel.Text = "Рецепта";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTextBox.Location = new System.Drawing.Point(0, 326);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(303, 105);
            this.commentTextBox.TabIndex = 5;
            this.commentTextBox.TextChanged += new System.EventHandler(this.commentTextBox_TextChanged);
            // 
            // publishCommentButton
            // 
            this.publishCommentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishCommentButton.Location = new System.Drawing.Point(303, 326);
            this.publishCommentButton.Name = "publishCommentButton";
            this.publishCommentButton.Size = new System.Drawing.Size(115, 105);
            this.publishCommentButton.TabIndex = 6;
            this.publishCommentButton.Text = "Публикуване";
            this.publishCommentButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.recipeLabel);
            this.groupBox1.Controls.Add(this.ingredientsLabel);
            this.groupBox1.Controls.Add(this.cocktailLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 437);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рецепта";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(180, 386);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 45);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Изтрий";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(37, 386);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(115, 45);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Редактирай";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentTextBox);
            this.groupBox2.Controls.Add(this.publishCommentButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 437);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коментари";
            // 
            // CocktailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CocktailForm";
            this.Text = "Информация за коктейл";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cocktailLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button publishCommentButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}