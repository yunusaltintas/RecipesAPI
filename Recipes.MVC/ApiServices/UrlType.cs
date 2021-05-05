using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.MVC.ApiServices
{
    public static class UrlType
    {

        public const string BaseUrl = "http://localhost:50554/Service/";
        public const string RecipeAll = "Recipe/All";
        public const string CategoreiesOfRecipe = "Recipe/Filter/Categories";
        public const string RecipeById = "Recipe/All/{0}";
    }
}
