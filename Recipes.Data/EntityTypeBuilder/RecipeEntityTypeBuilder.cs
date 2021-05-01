using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.EntityTypeBuilder
{
    public class RecipeEntityTypeBuilder : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasMany(x => x.Ingredients).WithOne(x => x.Recipe).HasForeignKey(x => x.RecipeId);
            builder.HasOne(x => x.Direction).WithOne(x => x.Recipe).HasForeignKey<Recipe>(x => x.DirectionId);
        }
    }
}
