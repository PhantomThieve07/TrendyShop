#pragma checksum "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5956430b81d1afddc1a399d23ef158bb13076652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml"
using TrendyShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5956430b81d1afddc1a399d23ef158bb13076652", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeViewModel>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5956430b81d1afddc1a399d23ef158bb130766523620", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 318, "\"", 328, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 355, "\"", 365, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>Compra Venta (Página de Inicio)</title>\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5956430b81d1afddc1a399d23ef158bb130766525163", async() => {
                WriteLiteral(@"
    <div id=""carouselExampleIndicators"" class=""carousel slide mt-4"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner mt-4"" role=""listbox"">

            <div class=""carousel-item active"" style=""background-image: url('/images/img00.jpg')"">
                <div class=""carousel-caption d-none d-md-block"">
                    <h3>Bienvenido</h3>
                    <p>Somos el mejor sitio de ventas online y subastas</p>
                </div>
            </div>
            <div class=""carousel-item"" style=""background-image: url('/images/guy.jpg'); background-size:cover"">
                <div class=""carousel-caption d-none d-md-block"">
                    <h3>Siéntase en Casa</h3>
");
                WriteLiteral(@"                    <p>Trabajamos para usted. No dude en contactarnos!</p>
                </div>
            </div>
            <div class=""carousel-item"" style=""background-image: url('/images/img02.jpg')"">
                <div class=""carousel-caption d-none d-md-block"">
                    <h3>Nos preocupamos por usted</h3>
                    <p>Su seguridad y protección es nuestra prioridad. Su información está a salvo con nosotros.</p>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </");
                WriteLiteral("div>\r\n    <!-- slider-area start -->\r\n");
                WriteLiteral("    <!-- slider-area end -->\r\n    <!-- Page Content -->\r\n    <div class=\"container\">\r\n        <h1 class=\"my-4 text-center\"> Artículos recientes</h1>\r\n\r\n");
#nullable restore
#line 99 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml"
         foreach (HomeViewModel add in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-lg-12 mb-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title border-bottom\">");
#nullable restore
#line 104 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml"
                                                        Write(add.ArticleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n                        <div class=\"d-flex flex-column\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 107 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml"
                                            Write(add.AddDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            ");
#nullable restore
#line 108 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Ver más...", "Details", "Add", new { id = add.AddId }, new { @class = "ml-auto" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 113 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
