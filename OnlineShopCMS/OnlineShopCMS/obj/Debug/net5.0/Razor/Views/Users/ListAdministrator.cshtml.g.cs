#pragma checksum "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1211af634e2670a95ca95b40124bd1eca9ba5884211f27c820f996b5e3c28c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ListAdministrator), @"mvc.1.0.view", @"/Views/Users/ListAdministrator.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\_ViewImports.cshtml"
using OnlineShopCMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
using OnlineShopCMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1211af634e2670a95ca95b40124bd1eca9ba5884211f27c820f996b5e3c28c20", @"/Views/Users/ListAdministrator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"889ed1f8af1561721a181c3e6cf1b65a271e913231d74deb9ee0431e7118d1c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_ListAdministrator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopCMS.Areas.Identity.Data.OnlineShopUserViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
  
    ViewData["Title"] = "ListAdministrator";
    Layout = "~/Views/Shared/_UserManagLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Administrator Users</h2>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Username</th>\n            <th>Email</th>\n            <th>Role</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 20 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Users\ListAdministrator.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopCMS.Areas.Identity.Data.OnlineShopUserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591