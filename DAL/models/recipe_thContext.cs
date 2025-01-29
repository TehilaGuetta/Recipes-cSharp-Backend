using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.models
{
    public partial class recipe_thContext : DbContext
    {
        public recipe_thContext()
        {
        }

        public recipe_thContext(DbContextOptions<recipe_thContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ingedient> Ingedients { get; set; } = null!;
        public virtual DbSet<IngredientForRecipe> IngredientForRecipes { get; set; } = null!;
        public virtual DbSet<RecipeTable> RecipeTables { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=kitotSrv\\sql;Database=recipe_th;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingedient>(entity =>
            {
                entity.ToTable("ingedient");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IngedientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ingedient_Name");
            });

            modelBuilder.Entity<IngredientForRecipe>(entity =>
            {
                entity.HasKey(e => e.CodeIngredientRecipe);

                entity.ToTable("ingredient_for_recipe");

                entity.Property(e => e.CodeIngredientRecipe).HasColumnName("Code_Ingredient_Recipe");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeIngredient).HasColumnName("Code_Ingredient");

                entity.Property(e => e.CodeRecipe).HasColumnName("Code_Recipe");

                entity.HasOne(d => d.CodeIngredientNavigation)
                    .WithMany(p => p.IngredientForRecipes)
                    .HasForeignKey(d => d.CodeIngredient)
                    .HasConstraintName("FK_ingredient_for_recipe_ingedient");

                entity.HasOne(d => d.CodeRecipeNavigation)
                    .WithMany(p => p.IngredientForRecipes)
                    .HasForeignKey(d => d.CodeRecipe)
                    .HasConstraintName("FK_ingredient_for_recipe_recipe_table");
            });

            modelBuilder.Entity<RecipeTable>(entity =>
            {
                entity.HasKey(e => e.CodeRecipe);

                entity.ToTable("recipe_table");

                entity.Property(e => e.CodeRecipe).HasColumnName("Code_Recipe");

                entity.Property(e => e.Descrebtion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.Img)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Instraction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LevelRecipe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Level_Recipe");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.RecipeTables)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_recipe_table_user");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Family)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
