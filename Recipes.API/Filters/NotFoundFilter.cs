using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Recipes.Data.DTOs;
using Recipes.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.API.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IRecipeService _recipeService;

        public NotFoundFilter(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var result = await _recipeService.GetByIdAsync(id);

            if (result != null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"id'si {id} olan ürün veritabanında bulunamadı");

                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
