#pragma checksum "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17aafe1f40bfb9bc4d5a2060e48d55ec3486f03f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_AddToShoppCart), @"mvc.1.0.view", @"/Views/ShoppingCart/AddToShoppCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17aafe1f40bfb9bc4d5a2060e48d55ec3486f03f", @"/Views/ShoppingCart/AddToShoppCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_AddToShoppCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrendyShop.ViewModels.AddToSCViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml"
  
    ViewData["Title"] = "AddToShoppCart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>AddToShoppCart</h1>

<!-- Navigation -->
<nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">Inicio</a>
        <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
            <ul class=""navbar-nav ml-auto"">

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Anuncios
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        ");
            WriteLiteral(@"<a class=""dropdown-item"" href=""/Add/NewAdd"">Anunciar</a>
                        <a class=""dropdown-item"" href=""/Add"">Lista de Anuncios</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/ShoppingCart/Index"">Carrito de Compra</a>
                </li>

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Subasta
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        <a class=""dropdown-item"" href=""/Auction/NewAuction"">Nueva Subasta</a>
                        <a class=""dropdown-item"" href=""/Auction"">Lista de Subastas</a>
                    </div>
                </li>

                <li class=""nav-item"">
                    <a");
            WriteLiteral(@" class=""nav-link"" href=""/Home/About"">Acerca de</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/Contact"">Contáctanos</a>
                </li>

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        Usuario
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        <a class=""dropdown-item"" href=""/User/Login"">Entrar</a>
                        <a class=""dropdown-item"" href=""/Home/Register"">Registrar</a>
                    </div>
                </li>

            </ul>
        </div>
    </div>
</nav>

");
#nullable restore
#line 64 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml"
 using (Html.BeginForm("AddToCart", "ShoppingCart", new { aid = @Model.Add.ArticleId, uid = @Model.Add.UserId, amountToBuy = @Model.AmountToAdd }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 67 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml"
   Write(Html.LabelFor(m => m.AmountToAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 68 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml"
   Write(Html.TextBoxFor(m => m.AmountToAdd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 69 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml"
   Write(Html.ValidationMessageFor(m => m.AmountToAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\" btn btn-primary\">Agregar</button>\r\n");
#nullable restore
#line 74 "C:\Users\amali\OneDrive\Documents\Visual Studio 2019\projects\CompraVenta\TrendyShop\ShoppingCart\AddToShoppCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrendyShop.ViewModels.AddToSCViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591