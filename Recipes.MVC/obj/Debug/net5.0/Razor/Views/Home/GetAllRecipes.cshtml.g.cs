#pragma checksum "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e478082ee8db6a842996a83bbfab91f23642b64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllRecipes), @"mvc.1.0.view", @"/Views/Home/GetAllRecipes.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\_ViewImports.cshtml"
using Recipes.Data.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e478082ee8db6a842996a83bbfab91f23642b64", @"/Views/Home/GetAllRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44fcb8c66fd0eadc2144120adc33e3548dbb69a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAllRecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecipeDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
  
    ViewData["Title"] = "GetAllRecipes";


#line default
#line hidden
#nullable disable
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e478082ee8db6a842996a83bbfab91f23642b643812", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e478082ee8db6a842996a83bbfab91f23642b644801", async() => {
                WriteLiteral("\r\n    <h1>GetAllCategories</h1>\r\n\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e478082ee8db6a842996a83bbfab91f23642b645115", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </p><br />\r\n\r\n");
#nullable restore
#line 19 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
     foreach (var item in @Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h4>");
#nullable restore
#line 21 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4><br />\r\n        <h5>Categories:</h5>\r\n");
#nullable restore
#line 23 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
         foreach (var category in item.Categories)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>");
#nullable restore
#line 25 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>Ingredients:</h5>\r\n");
#nullable restore
#line 29 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
         foreach (var Ingredient in item.Ingredients)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>IngredientName: ");
#nullable restore
#line 31 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
                          Write(Ingredient.IngredientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Quantity: ");
#nullable restore
#line 32 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
                    Write(Ingredient.Amount.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(", Unit: ");
#nullable restore
#line 32 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
                                                       Write(Ingredient.Amount.Unit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Direction:");
#nullable restore
#line 35 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
                Write(item.Direction.Step);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("        <br /><br />\r\n");
#nullable restore
#line 38 "C:\Users\yunus\source\repos\GİT\RecipesAPI\Recipes.MVC\Views\Home\GetAllRecipes.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecipeDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
