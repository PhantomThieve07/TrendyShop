#pragma checksum "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32963e404895fa3e3eaf074da65b13267a485b3d"
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
#line 1 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
using TrendyShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32963e404895fa3e3eaf074da65b13267a485b3d", @"/Views/Add/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32963e404895fa3e3eaf074da65b13267a485b3d4310", async() => {
                WriteLiteral(@"

    <!-- Page Content -->
    <div class=""container"">
        <!-- Page Heading/Breadcrumbs -->

        <div class=""row"">

            <h1 class=""col-lg-4 mt-4 mb-3"">
                Artículos
            </h1>
            <div class=""col-lg-2""></div>
            <input type=""search"" class=""form-control col-lg-4 mt-4 mb-3"" id=""name"">
            <a class=""col-lg-1 btn btn-dark mt-4 mb-3 ml-1 text-white"">Buscar</a>

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
                <div class=""card"">
                    <div class=""card-body"">
                        <ul class=""navbar-nav flex-column"">
                            <li class=""card-title border-bottom h2"">");
                WriteLiteral("\r\n                                Filtrar por...\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1326, "\"", 1333, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link""><i class=""fas fa-dollar-sign""></i> Precio</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link active"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-1"" aria-controls=""submenu-1""><i class=""fas fa-chart-bar""></i> Categoría <span class=""badge badge-success""></span></a>
                                <div id=""submenu-1"" class=""collapse submenu""");
                BeginWriteAttribute("style", " style=\"", 1815, "\"", 1823, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <ul class=\"nav flex-column\">\r\n");
#nullable restore
#line 50 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                         foreach (Category cat in Model.Categories)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li class=\"nav-item mb-1 ml-4\">\r\n                                                ");
#nullable restore
#line 53 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                           Write(Html.ActionLink(cat.Name, "Index", "Add", new { categoryId = cat.CategoryId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </li>\r\n");
#nullable restore
#line 55 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </ul>
                                </div>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-1-1"" aria-controls=""submenu-1-1""><i class=""fas fa-gift""></i> Condición</a>
                                <div id=""submenu-1-1"" class=""collapse submenu""");
                BeginWriteAttribute("style", " style=\"", 2772, "\"", 2780, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <ul class=\"nav flex-column\">\r\n                                        <li class=\"nav-item mb-1 ml-4\">\r\n                                            ");
#nullable restore
#line 64 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                       Write(Html.ActionLink("Nuevo", "Index", "Add", new { isNew = "true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </li>\r\n                                        <li class=\"nav-item mb-1 ml-4\">\r\n                                            ");
#nullable restore
#line 67 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                       Write(Html.ActionLink("De Uso", "Index", "Add", new { isNew = "false" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </li>
                                    </ul>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class=""col-lg-9 mb-4"">
                <h2>Lista de Artículos</h2>

");
#nullable restore
#line 80 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                 foreach (Add a in Model.Adds)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-lg-12 mb-4\">\r\n                        <div class=\"card h-100\">\r\n                            <div class=\"card-body\" ");
                WriteLiteral(">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32963e404895fa3e3eaf074da65b13267a485b3d10448", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3935, "~/images/", 3935, 9, true);
#nullable restore
#line 85 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
AddHtmlAttributeValue("", 3944, a.Article.Image, 3944, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <h4 class=\"card-title border-bottom\">");
#nullable restore
#line 86 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                                                Write(a.Article.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n                                <div class=\"d-flex\">\r\n                                    <h5> <i class=\"fas fa-money-bill-alt\"></i> Precio: ");
#nullable restore
#line 89 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                                                                  Write(a.Article.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</h5>\r\n                                    <h5 class=\"ml-2\"><i class=\"fas fa-certificate\"></i> Marca: ");
#nullable restore
#line 90 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                                                                          Write(a.Article.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                </div>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 92 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                                Write(a.Article.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                                <div class=\"d-flex\">\r\n                                    <div class=\"ml-auto\">\r\n                                        ");
#nullable restore
#line 96 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                                   Write(Html.ActionLink("Ver Anuncio...", "Details", "Add", new { id = a.ArticleId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 102 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
                WriteLiteral("        </div>\r\n\r\n    </div>\r\n    <!-- /.container -->\r\n    <!-- Bootstrap core JavaScript -->\r\n\r\n");
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
