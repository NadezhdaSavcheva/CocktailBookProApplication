using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CocktailBookPro.Services.Models;

namespace CocktailBookPro.Services
{
    public partial class CocktailBookProDBContext : DbContext
    {
        public CocktailBookProDBContext()
        {
        }

        public CocktailBookProDBContext(DbContextOptions<CocktailBookProDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CocktailCategories> CocktailCategories { get; set; }
        public virtual DbSet<CocktailCategoriesRecipes> CocktailCategoriesRecipes { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<IngredientsCategories> IngredientsCategories { get; set; }
        public virtual DbSet<IngredientsCategoriesIngredients> IngredientsCategoriesIngredients { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<RecipeComments> RecipeComments { get; set; }
        public virtual DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public virtual DbSet<RecipeSteps> RecipeSteps { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=cocktailbook_pro;uID=root;pwd=MyNewSQLPass***;persistsecurityinfo=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CocktailCategories>(entity =>
            {
                entity.ToTable("cocktail_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CocktailCategoriesRecipes>(entity =>
            {
                entity.HasKey(e => new { e.RecipeCategoryId, e.RecipeId })
                    .HasName("PRIMARY");

                entity.ToTable("cocktail_categories_recipes");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("fk_recipe_id_categories");

                entity.Property(e => e.RecipeCategoryId).HasColumnName("recipe_category_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.HasOne(d => d.RecipeCategory)
                    .WithMany(p => p.CocktailCategoriesRecipes)
                    .HasForeignKey(d => d.RecipeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recipe_category_id");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.CocktailCategoriesRecipes)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recipe_id_categories");
            });

            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.ToTable("ingredients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IngredientsCategories>(entity =>
            {
                entity.ToTable("ingredients_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IngredientsCategoriesIngredients>(entity =>
            {
                entity.HasKey(e => new { e.IngredientCategoryId, e.CocktailIngredientsId })
                    .HasName("PRIMARY");

                entity.ToTable("ingredients_categories_ingredients");

                entity.HasIndex(e => e.CocktailIngredientsId)
                    .HasName("fk_cocktail_ingredients_id");

                entity.Property(e => e.IngredientCategoryId).HasColumnName("ingredient_category_id");

                entity.Property(e => e.CocktailIngredientsId).HasColumnName("cocktail_ingredients_id");

                entity.HasOne(d => d.CocktailIngredients)
                    .WithMany(p => p.IngredientsCategoriesIngredients)
                    .HasForeignKey(d => d.CocktailIngredientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cocktail_ingredients_id");

                entity.HasOne(d => d.IngredientCategory)
                    .WithMany(p => p.IngredientsCategoriesIngredients)
                    .HasForeignKey(d => d.IngredientCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ingredient_category_id");
            });

            modelBuilder.Entity<Logins>(entity =>
            {
                entity.ToTable("logins");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash")
                    .HasMaxLength(200);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RecipeComments>(entity =>
            {
                entity.ToTable("recipe_comments");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("fk_recipe_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_user_id_comments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeComments)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("fk_recipe_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RecipeComments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_user_id_comments");
            });

            modelBuilder.Entity<RecipeIngredients>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recipe_ingredients");

                entity.HasIndex(e => e.IngredientId)
                    .HasName("fk_ingredient_id");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("fk_recipe_id_ingredients");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(25);

                entity.HasOne(d => d.Ingredient)
                    .WithMany()
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("fk_ingredient_id");

                entity.HasOne(d => d.Recipe)
                    .WithMany()
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("fk_recipe_id_ingredients");
            });

            modelBuilder.Entity<RecipeSteps>(entity =>
            {
                entity.ToTable("recipe_steps");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("fk_recipe_id_steps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.StepNumber).HasColumnName("step_number");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeSteps)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("fk_recipe_id_steps");
            });

            modelBuilder.Entity<Recipes>(entity =>
            {
                entity.ToTable("recipes");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_user_id");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasColumnName("mobile_phone")
                    .HasMaxLength(15);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash")
                    .HasMaxLength(200);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Users)
                    .HasForeignKey<Users>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
