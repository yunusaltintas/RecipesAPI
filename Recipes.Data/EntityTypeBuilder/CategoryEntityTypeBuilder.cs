using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.EntityTypeBuilder
{
    public class CategoryEntityTypeBuilder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(x => x.Recipes).WithMany(x => x.Category);
        }
    }
}
