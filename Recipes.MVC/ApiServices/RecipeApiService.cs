using Newtonsoft.Json;
using Recipes.Data.DTOs;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Recipes.MVC.ApiServices
{
    public class RecipeApiService
    {
        private readonly HttpClient _httpClient;
        public RecipeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public CategoryWithResultCountDto GetAllCategories()
        {
            var client = new RestClient(UrlType.BaseUrl);
            var request = new RestRequest(UrlType.CategoreiesOfRecipe, Method.GET);
            var query = client.Execute<CategoryWithResultCountDto>(request);

            var categoriesString=JsonConvert.DeserializeObject<CategoryWithResultCountDto>(query.Content);

            return categoriesString;
        }

        public List<RecipeDto> GetAllRecipes()
        {

            var client = new RestClient(UrlType.BaseUrl);
            var request = new RestRequest(UrlType.RecipeAll, Method.GET);
            var query = client.Execute<RecipeDto>(request);

            var RepicesString = JsonConvert.DeserializeObject<List<RecipeDto>>(query.Content);

            return RepicesString;
        }

        public RecipeDto GetRecipeById(int id)
        {
            var client = new RestClient(UrlType.BaseUrl);
            var request = new RestRequest(string.Format(UrlType.RecipeById, id), Method.GET);
            var query = client.Execute<RecipeDto>(request);

            var RepicesString = JsonConvert.DeserializeObject<RecipeDto>(query.Content);

            return RepicesString;
        }

        public RecipeDto UpdateRecipe(RecipeDto recipeDto)
        {
            var client = new RestClient(UrlType.BaseUrl);
            var request = new RestRequest(string.Format(UrlType.RecipeById,recipeDto.RecipeId), Method.PUT);
            var query = client.Execute<RecipeDto>(request);

            var RepicesString = JsonConvert.DeserializeObject<RecipeDto>(query.Content);

            return RepicesString;


        }
        public RecipeDto AddRecipe(RecipeDto recipeDto)
        {
            var client = new RestClient(UrlType.BaseUrl);
            var request = new RestRequest(UrlType.RecipeAll, Method.POST);
            var query = client.Execute<RecipeDto>(request);

            var RepicesString = JsonConvert.DeserializeObject<RecipeDto>(query.Content);

            return RepicesString;


        }

    }
}
