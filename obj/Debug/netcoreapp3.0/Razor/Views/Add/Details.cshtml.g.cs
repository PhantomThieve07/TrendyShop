#pragma checksum "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4670f07aa02ff7ef78a6e0607f5c86b3966c728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Details), @"mvc.1.0.view", @"/Views/Add/Details.cshtml")]
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
#line 1 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
using TrendyShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4670f07aa02ff7ef78a6e0607f5c86b3966c728", @"/Views/Add/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-10 mt-4 text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AccountDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4670f07aa02ff7ef78a6e0607f5c86b3966c7284686", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 248, "\"", 258, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 285, "\"", 295, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>Compra Venta (Artículo x)</title>\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4670f07aa02ff7ef78a6e0607f5c86b3966c7286227", async() => {
                WriteLiteral("\r\n\r\n\r\n    <!-- Page Content -->\r\n    <div class=\"container\">\r\n\r\n        <!-- Page Heading/Breadcrumbs -->\r\n\r\n        <div class=\"row\">\r\n            <h3 class=\"col-lg-4 mt-4\">");
#nullable restore
#line 28 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
                                 Write(Model.Article.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4670f07aa02ff7ef78a6e0607f5c86b3966c7286987", async() => {
#nullable restore
#line 29 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
                                                                                                                                        Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
                                                                                                           WriteLiteral(Model.User.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"
        </div>

        <div class=""row"">
            <div class=""col-lg-12 navbar-brand"">Imagen del producto</div>
            <div class=""col-lg-12"">
                <img src=""/images/img1.jpg"" height=""255"" width=""255"">
            </div>
        </div>

        <!-- Article Info -->
        <div class=""row"">
            <div class=""col-lg-11 mb-4"">
                <h4 class=""card-header my-4"">Descripción:</h4>
            </div>

            <div class=""col-lg-11 mb-4 card-body"">
                <p class=""card-text"">
                    ");
#nullable restore
#line 49 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
               Write(Model.AddDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"col-lg-11 mb-4 card-footer my-4\">\r\n                <h3>Precio: ");
#nullable restore
#line 54 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
                       Write(Model.Article.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-lg-11 mb-4 card-footer my-4\">\r\n                <h3>Cantidad Disponible: ");
#nullable restore
#line 57 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
                                    Write(Model.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n            </div>\r\n\r\n            <div class=\"col-lg-1 card-footer my-4\">\r\n");
                WriteLiteral("                ");
#nullable restore
#line 62 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
           Write(Html.ActionLink("Comprar", "Buy", "Buy", new { uid = @Model.UserName, aid = @Model.Article.ArticleId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"col-lg-1 card-footer my-4\">\r\n                ");
#nullable restore
#line 67 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
           Write(Html.ActionLink("Editar", "Edit", "Add", new { aid = @Model.Article.ArticleId, uid = Model.UserName }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"col-lg-1 card-footer my-4\">\r\n                ");
#nullable restore
#line 72 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\Views\Add\Details.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", "Add", new { aid = @Model.Article.ArticleId, uid = @Model.UserName }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n");
                WriteLiteral("\r\n        </div>\r\n        <!-- /.row -->\r\n\r\n    </div>\r\n    <!-- /.container -->\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
