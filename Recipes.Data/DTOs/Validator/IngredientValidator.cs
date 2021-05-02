using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Data.DTOs.Validator
{
    public class IngredientValidator : AbstractValidator<IngredientDto>
    {
        public IngredientValidator()
        {
            RuleFor(o => o.IngredientName).NotEmpty().NotNull();
        }
 
    }
}
