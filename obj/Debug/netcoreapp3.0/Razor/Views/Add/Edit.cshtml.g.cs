#pragma checksum "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ece47ca0054acbedb75a0af04796ee70bae5a72d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Edit), @"mvc.1.0.view", @"/Views/Add/Edit.cshtml")]
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
#line 1 "C:\My Projects\Proyecto IS\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Projects\Proyecto IS\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece47ca0054acbedb75a0af04796ee70bae5a72d", @"/Views/Add/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrendyShop.ViewModels.EditAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
  
    ViewData["Title"] = "EditAdd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EditAdd</h1>\r\n\r\n\r\n<!-- Navigation -->\r\n\r\n");
#nullable restore
#line 11 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
 using (Html.BeginForm("SaveEdition", "Add"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 14 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.TextBoxFor(a => a.Add.Article.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 20 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Article.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.TextBoxFor(a => a.Add.Article.Brand, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Article.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 26 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.TextBoxFor(a => a.Add.Article.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 32 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Article.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.TextBoxFor(a => a.Add.Article.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Article.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 38 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Article.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.DropDownListFor(a => a.Add.Article.CategoryId, new SelectList(Model.Categories, "CategoryId", "Name"), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 43 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Article.IsNew));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.CheckBoxFor(a => a.Add.Article.IsNew, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 45 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Article.IsNew));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 49 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 50 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.TextBoxFor(a => a.Add.Amount, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 51 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 55 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.LabelFor(a => a.Add.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 56 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.TextBoxFor(a => a.Add.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 57 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
   Write(Html.ValidationMessageFor(a => a.Add.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
Write(Html.HiddenFor(a => a.Add.UserId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
Write(Html.HiddenFor(a => a.Add.ArticleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\" btn btn-primary\">Editar Anuncio</button>\r\n");
#nullable restore
#line 64 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrendyShop.ViewModels.EditAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
