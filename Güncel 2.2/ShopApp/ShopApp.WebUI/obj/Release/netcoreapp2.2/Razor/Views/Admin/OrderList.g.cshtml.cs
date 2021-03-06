#pragma checksum "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4adf21dd14622af2aeefa13dd5b348afa36eaf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrderList), @"mvc.1.0.view", @"/Views/Admin/OrderList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/OrderList.cshtml", typeof(AspNetCore.Views_Admin_OrderList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4adf21dd14622af2aeefa13dd5b348afa36eaf9", @"/Views/Admin/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4670d682d3ec9b0185b95a8321540583047ebee", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewData["Title"] = "GetOrders";

#line default
#line hidden
            BeginContext(104, 46, true);
            WriteLiteral("\r\n<h1 class=\"mt-5\">Siparişler</h1>\r\n<hr />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
 foreach (var order in Model)
    {


#line default
#line hidden
            BeginContext(190, 1168, true);
            WriteLiteral(@"        <br />
        <div class=""card mb-4"">
            <div class=""card-header"">
                <i class=""fas fa-table mr-1""></i>
                Siparişler
            </div>
            <div class=""card-body"">

                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""example"" width=""100%"" cellspacing=""0"">

                        <thead>
                            <tr>
                                <th>Müşteri Adı</th>
                                <th>Adresi</th>
                                <th>Tel No</th>
                                <th>E Posta</th>
                                <th>Odeme Durumu</th>
                                <th>Sipariş Durumu</th>
                                <th>Sipariş Tarihi</th>
                                
                                    <th>Alınanlar</th>
                               
                                <th>Toplam Tutar</th>

                            </");
            WriteLiteral("tr>\r\n                        </thead>\r\n\r\n                        <tbody>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1359, 15, false);
#line 43 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(order.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1374, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1376, 14, false);
#line 43 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                                                Write(order.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1434, 13, false);
#line 44 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(order.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1491, 11, false);
#line 45 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(order.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1502, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1546, 11, false);
#line 46 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(order.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1601, 18, false);
#line 47 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(order.PaymentTypes);

#line default
#line hidden
            EndContext();
            BeginContext(1619, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1663, 45, false);
#line 48 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(GetEnumValue.GetDescription(order.OrderState));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1752, 35, false);
#line 49 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                               Write(order.OrderDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1787, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(1791, 35, false);
#line 49 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                                                                      Write(order.OrderDate.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1826, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 51 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                                     foreach (var orderItem in order.OrderItems)
                                    {

                                        

#line default
#line hidden
            BeginContext(2035, 14, false);
#line 54 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                                   Write(orderItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 25, true);
            WriteLiteral(" <small>x</small> <small>");
            EndContext();
            BeginContext(2075, 18, false);
#line 54 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                                                                           Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2093, 10, true);
            WriteLiteral("</small>\r\n");
            EndContext();
#line 55 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"


                                    }

#line default
#line hidden
            BeginContext(2146, 79, true);
            WriteLiteral("                                </td>\r\n                                    <td>");
            EndContext();
            BeginContext(2226, 18, false);
#line 59 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"
                                   Write(order.TotalPrice());

#line default
#line hidden
            EndContext();
            BeginContext(2244, 182, true);
            WriteLiteral("</td>\r\n\r\n\r\n                                </tr>\r\n\r\n\r\n                        </tbody>\r\n\r\n\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 72 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\OrderList.cshtml"

    }

#line default
#line hidden
            BeginContext(2435, 64, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2518, 257, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#example').DataTable({

                dom: 'Bfrtip',
                buttons: [
                    'print'
                ]
            });
        });

    </script>

");
                EndContext();
            }
            );
            BeginContext(2778, 4, true);
            WriteLiteral("\r\n\r\n");
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
