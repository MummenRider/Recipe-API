using Microsoft.EntityFrameworkCore;
using RECIPE_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RECIPE_API.Persistence
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Recipe>()
                .Property(p => p.Ingridients)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                );

            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.CategoryId);
            builder.Entity<Category>().Property(p => p.CategoryId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.CategoryName).IsRequired().HasMaxLength(100);
            builder.Entity<Category>().HasMany(p => p.Recipes).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
                (
                    new Category { CategoryId = 100, CategoryName = "Chicken"},
                    new Category { CategoryId = 101, CategoryName = "Beef"},
                    new Category { CategoryId = 102, CategoryName = "Pork"}
                );

            builder.Entity<Recipe>().HasKey(p => p.RecipeId);
            builder.Entity<Recipe>().Property(p => p.RecipeId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Recipe>().Property(p => p.Title).IsRequired();
            builder.Entity<Recipe>().Property(p => p.ImageUrl).IsRequired();

            builder.Entity<Recipe>().HasData
                (
                    new Recipe
                    {
                        RecipeId = 1000,
                        Title = "Chicken Adobo",
                        Summary = "Chicken braised in vinegar and soy sauce with lots of garlic. This easy, savory chicken dish has become a staple in my home. As this simmers, your kitchen fills with an intoxicating sweet and sour aroma that will leave you anxious to eat.",
                        ImageUrl = "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Filipino-Chicken-Adobo_EXPS_THAM18_212833_C11_09_8b.jpg",
                        Ingridients = new List<string> {
                                "8 skinless chicken drumsticks, on the bone",
                                "1/3 cup low sodium soy sauce, use gluten-free soy sauce for GF and coconut aminos for Paleo",
                                "1 / 3 cup apple cider vinegar",
                                "1 small head of garlic, crushed",
                                "6 ground peppercorns",
                                "4 bay leaves",
                                "1 jalapeño, chopped(optional)"
                        },
                         CategoryId = 100
                    },
                    new Recipe {
                        RecipeId = 1001,
                        Title = "Chicken Inasal",
                        Summary = "Chicken Inasal is a grilled chicken dish and one of the well known Ilonggo dishes. This is done by marinating chicken pieces in a unique blend of spices and grilling them until done.",
                        ImageUrl = "https://i.pinimg.com/originals/1d/96/84/1d96844b21a7e547cb4a433cb41c1b4f.jpg",
                        Ingridients = new List<string> {
                                "2 lbs chicken cut into serving pieces",
                                "2 tablespoons ginger minced",
                                "2 tablespoons garlic minced",
                                "3/4 cup lemongrass chopped",
                                "1 cup coconut vinegar",
                                "1/2 cup lemon or calamansi juice",
                                "1 tablespoon salt",
                                "1/4 cup brown sugar",
                                "1 cup lemon soda softdrink",
                                "1/2 tablespoon ground black pepper",
                        },
                        CategoryId = 100

                    }
                );
             
        }
    }
}
