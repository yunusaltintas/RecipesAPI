using Newtonsoft.Json;
using Recipes.Data.DTOs;
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

        public async Task<CategoryWithResultCountDto> GetAllCategories()
        {
           CategoryWithResultCountDto categoryDtos=new CategoryWithResultCountDto();

            var response = await _httpClient.GetAsync("Recipe/Filter/Categories");

            if (response.IsSuccessStatusCode)
            {
                categoryDtos = JsonConvert.DeserializeObject<CategoryWithResultCountDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                categoryDtos = null;
            }
            return categoryDtos;
        }

        public async Task<RecipesDto> GetAllRecipes()
        {
            RecipesDto recipesDto;

            var response = await _httpClient.GetAsync("Recipe/All");

            if (response.IsSuccessStatusCode)
            {
                recipesDto = JsonConvert.DeserializeObject<RecipesDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                recipesDto = null;
            }
            return recipesDto;
        }





    }
}
