#pragma checksum "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb52dee61ef9fcfc57270072c8c8d3e6413c77cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/GetOrders.cshtml", typeof(AspNetCore.Views_Cart_GetOrders))]
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
#line 1 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 4 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb52dee61ef9fcfc57270072c8c8d3e6413c77cb", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4670d682d3ec9b0185b95a8321540583047ebee", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
  
    ViewData["Title"] = "GetOrders";

#line default
#line hidden
            BeginContext(74, 29, true);
            WriteLiteral("\r\n<h1>Orders</h1>\r\n<hr />\r\n\r\n");
            EndContext();
#line 9 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
 foreach(var order in Model)
{

#line default
#line hidden
            BeginContext(136, 176, true);
            WriteLiteral("    <table id=\"example\" class=\"table table-bordered table-sm mb-5\">\r\n        <thead class=\"bg-dark text-white\">\r\n            <tr>\r\n                <td colspan=\"2\">Sipariş Id: #");
            EndContext();
            BeginContext(313, 13, false);
#line 14 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                        Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(326, 126, true);
            WriteLiteral("</td>\r\n                <th>Fiyat</th>\r\n                <th>Miktar</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
             foreach (var orderItem in order.OrderItems)
            {

#line default
#line hidden
            BeginContext(525, 91, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"width:60px\">\r\n                        ");
            EndContext();
            BeginContext(616, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb52dee61ef9fcfc57270072c8c8d3e6413c77cb5593", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 626, "~/img/", 626, 6, true);
#line 24 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
AddHtmlAttributeValue("", 632, orderItem.ImageUrl, 632, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(665, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(745, 14, false);
#line 27 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(759, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(839, 15, false);
#line 30 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Price);

#line default
#line hidden
            EndContext();
            BeginContext(854, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(934, 18, false);
#line 33 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(952, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(1021, 123, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">Müşteri Adı</td>\r\n                <td>");
            EndContext();
            BeginContext(1145, 15, false);
#line 42 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1162, 14, false);
#line 42 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 47, true);
            WriteLiteral("</td>\r\n                <td rowspan=\"3\">Toplam: ");
            EndContext();
            BeginContext(1224, 18, false);
#line 43 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                   Write(order.TotalPrice());

#line default
#line hidden
            EndContext();
            BeginContext(1242, 109, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Adres:</td>\r\n                <td>");
            EndContext();
            BeginContext(1352, 13, false);
#line 47 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1365, 111, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Telefon:</td>\r\n                <td>");
            EndContext();
            BeginContext(1477, 11, false);
#line 51 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1488, 109, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Email:</td>\r\n                <td>");
            EndContext();
            BeginContext(1598, 11, false);
#line 55 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 118, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Sipariş Tarihi:</td>\r\n                <td>");
            EndContext();
            BeginContext(1728, 35, false);
#line 59 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.OrderDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1763, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(1767, 35, false);
#line 59 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                                      Write(order.OrderDate.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1802, 116, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Odeme Durumu:</td>\r\n                <td>");
            EndContext();
            BeginContext(1919, 47, false);
#line 63 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(GetEnumValue.GetDescription(order.PaymentTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 118, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Sipariş Durumu:</td>\r\n                <td>");
            EndContext();
            BeginContext(2085, 45, false);
#line 67 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(GetEnumValue.GetDescription(order.OrderState));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 58, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 71 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
}

#line default
#line hidden
            BeginContext(2191, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
