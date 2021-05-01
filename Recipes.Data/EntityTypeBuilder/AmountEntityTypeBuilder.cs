using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.EntityTypeBuilder
{
    public class AmountEntityTypeBuilder : IEntityTypeConfiguration<Amount>
    {
        public void Configure(EntityTypeBuilder<Amount> builder)
        {
            builder.HasMany(x => x.Ingredients).WithOne(x => x.Amount).HasForeignKey(x => x.AmountId);
        }
    }
}
