#pragma checksum "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ac248c4d81b6d0c278e0b68d4a05e6063a6951fb9c18460bf4c1434a05175ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ac248c4d81b6d0c278e0b68d4a05e6063a6951fb9c18460bf4c1434a05175ef7", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a874db409d8a73e2ac1fdbeb6779cdf1c4c62cc22f2012edef9e5226e66e5e66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShop.Models.Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>　</div>\n<h3>訂單詳細資訊</h3>\n<hr />\n\n<p></p>\n<div class=\"card shadow-sm rounded\">\n    <div class=\"card-body\">\n\n        <h5>訂單編號：");
#nullable restore
#line 15 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
            Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <div class=\"row\">\n            <div class=\"col\"><p class=\"text-muted\">");
#nullable restore
#line 17 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\n            <div class=\"col text-right\"><p class=\"text-muted\">");
#nullable restore
#line 18 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></div>
        </div>

        <div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>商品名稱</th>
                        <th>數量</th>
                        <th>小計</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                     foreach (var item in ViewBag.orderItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 34 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 35 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 36 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                           Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 38 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n            <div class=\"text-right pr-5\">\n                <p style=\"padding-right:12px\">總計： $");
#nullable restore
#line 42 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n        <hr />\n        <div class=\"row\">\n            <div class=\"col-7\">\n                <p>收貨人姓名：");
#nullable restore
#line 48 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>收貨人電話：");
#nullable restore
#line 49 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>收貨人地址：");
#nullable restore
#line 50 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n            <div class=\"col-5\">\n                <p>\n                    訂單狀態：\n");
#nullable restore
#line 55 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                     if (@Model.isPaid)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>已付款</span>\n");
#nullable restore
#line 58 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>未付款</span>\n");
#nullable restore
#line 62 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </p>
                <div class=""row"">
                    <p class=""col-3"">立即付款：</p>
                    <div class=""col-9"">
                        <div class=""w-75"" id=""payment-button""></div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
<p></p>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac248c4d81b6d0c278e0b68d4a05e6063a6951fb9c18460bf4c1434a05175ef79822", async() => {
                WriteLiteral("返回訂單列表");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<script src=""https://www.paypal.com/sdk/js?client-id=AROOEAjq-CEdjN74SU6zEGiQIc-1CKe_Cloaeuudb9ZCZZeAF3dVdqkeqO4fhFOM035egHsnUlK86pk1&currency=TWD""></script>
<script>
    paypal.Buttons({
        style: {
            shape: 'rect',
            size: 'small',
        },
        createOrder: function (data, actions) {
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: ");
#nullable restore
#line 92 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                          Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                        currency_code: \'TWD\',\n                        breakdown: {\n                            item_total: { value: ");
#nullable restore
#line 95 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                            Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(", currency_code: \'TWD\' }\n                        }\n                    },\n                    invoice_id: \'muesli_invoice_id\',\n                    items: [\n");
#nullable restore
#line 100 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                         foreach (var item in ViewBag.orderItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral("{ name:\'");
#nullable restore
#line 102 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                 Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', unit_amount: { value:");
#nullable restore
#line 102 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                                                           Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(", currency_code: \'TWD\' }, quantity:");
#nullable restore
#line 102 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                                                                                                            Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" },\n");
#nullable restore
#line 103 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    ]
                }]
            });
        },
        onApprove: function (data, actions) {
            return actions.order.capture().then(function (details) {
                console.log(details),
                window.location.replace(""/order/payment/?Id=");
#nullable restore
#line 111 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("&isSuccess=true\");\n            })\n        },\n        onCancel: function (data) {\n            window.location.replace(\"/order/payment/?Id=");
#nullable restore
#line 115 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\Details.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("&isSussess=false\");\n        }\n    }).render(\'#payment-button\')\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShop.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
