#pragma checksum "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e228ea8cd5de8b4f7ec8825953fc6984256cb7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Index), @"mvc.1.0.view", @"/Views/Add/Index.cshtml")]
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
#nullable restore
#line 1 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
using TrendyShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e228ea8cd5de8b4f7ec8825953fc6984256cb7e", @"/Views/Add/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddIndexViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e228ea8cd5de8b4f7ec8825953fc6984256cb7e3417", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 284, "\"", 294, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 321, "\"", 331, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>Compra Venta (Artículos)</title>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e228ea8cd5de8b4f7ec8825953fc6984256cb7e4953", async() => {
                WriteLiteral(@"

    <!-- Page Content -->
    <div class=""container"">
        <!-- Page Heading/Breadcrumbs -->

        <div class=""row"">

            <h1 class=""col-lg-4 mt-4 mb-3"">
                Artículos
                <small>(Filtros)</small>
            </h1>
            <div class=""col-lg-2""></div>
            <input type=""text"" class=""form-control col-lg-5 mt-4 mb-3"" id=""name"">
            <a class=""col-lg-1 btn btn-primary mt-4 mb-4 text-white"">Buscar</a>

        </div>

        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""/Home/Index"">Inicio</a>
            </li>
            <li class=""breadcrumb-item active"">Artículos</li>
        </ol>

        <!-- Content Row -->
        <div class=""row"">
            <!-- Sidebar Column -->
            <div class=""col-lg-3 mb-4"">
                <h3>Filtrar por:</h3>
                <div class=""list-group"">
");
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 1425, "\"", 1432, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item\">Precio</a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1492, "\"", 1499, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item\">Categoría</a>\r\n");
#nullable restore
#line 54 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                     foreach (Category cat in Model.Categories)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                   Write(Html.ActionLink(cat.Name, "Index", "Add", new { categoryId = cat.CategoryId }, new { @class = "list-group-item" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                                                                                                                                           ;

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 1817, "\"", 1824, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"list-group-item\">Condición</a>\r\n                    ");
#nullable restore
#line 60 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
               Write(Html.ActionLink("Nuevo", "Index", "Add", new { isNew = "true" }, new { @class = "list-group-item" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
               Write(Html.ActionLink("De Uso", "Index", "Add", new { isNew = "false" }, new { @class = "list-group-item" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-9 mb-4\">\r\n                <h2>Lista de Artículos</h2>\r\n\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 70 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                     foreach (Add a in Model.Adds)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-lg-12 mb-4\">\r\n                            <div class=\"card h-100\">\r\n                                <h4 class=\"card-header\">");
#nullable restore
#line 74 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                                                   Write(a.Article.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <div class=\"card-body\">\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 76 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                                                    Write(a.Article.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>

                                <div class=""card-footer"">
                                    <div class=""row"">
                                        <div class=""col-lg-11"">
                                            <h3>Precio: ");
#nullable restore
#line 82 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                                                   Write(a.Article.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                        </div>\r\n                                        <div class=\"col-lg-1\">\r\n");
                WriteLiteral("                                            ");
#nullable restore
#line 86 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                                       Write(Html.ActionLink("Mas", "Details", "Add", new { id = a.ArticleId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 92 "C:\My Projects\Proyecto IS\TrendyShop\Views\Add\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n");
                WriteLiteral("        </div>\r\n\r\n    </div>\r\n    <!-- /.container -->\r\n \r\n    <!-- Bootstrap core JavaScript -->\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
