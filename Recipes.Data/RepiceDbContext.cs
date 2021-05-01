using Microsoft.EntityFrameworkCore;
using Recipes.Data.Entities;
using Recipes.Data.EntityTypeBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data
{
    public class RepiceDbContext : DbContext
    {
        public RepiceDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Amount> Amounts { get; set; }
        public DbSet<Direction> Directions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AmountEntityTypeBuilder())
                .ApplyConfiguration(new CategoryEntityTypeBuilder())
                .ApplyConfiguration(new DirectionEntityTypeBuilder())
                .ApplyConfiguration(new IngredientEntityTypeBuilder())
                .ApplyConfiguration(new RecipeEntityTypeBuilder());
        }

    }
}
