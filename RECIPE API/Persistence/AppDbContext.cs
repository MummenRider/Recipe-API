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
        }
    }
}
