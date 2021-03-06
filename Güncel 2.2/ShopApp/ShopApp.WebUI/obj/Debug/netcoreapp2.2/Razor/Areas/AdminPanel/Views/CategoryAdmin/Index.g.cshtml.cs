#pragma checksum "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76bf3a7990c8efa064b3e76c4db690694139ab53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_CategoryAdmin_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/CategoryAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/CategoryAdmin/Index.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_CategoryAdmin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bf3a7990c8efa064b3e76c4db690694139ab53", @"/Areas/AdminPanel/Views/CategoryAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_CategoryAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp.WebUI.Areas.AdminPanel.Models.CategoryAdminListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletecategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
   
    Layout = "_Layout";
    ViewBag.Title = "Kategoriler Index";

#line default
#line hidden
            BeginContext(144, 736, true);
            WriteLiteral(@"
<div class=""card mb-4"">
    <div class=""card-header"">
        <i class=""fas fa-table mr-1""></i>
        DataTable Example
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Kategori Adı</th>
                        
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>ID</th>
                        <th>Kategori Adı</th>
                    </tr>
                </tfoot>
                <tbody>
");
            EndContext();
#line 29 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
                     foreach (var item in Model.Categories)
                    {

#line default
#line hidden
            BeginContext(964, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1027, 7, false);
#line 32 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1034, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1074, 9, false);
#line 33 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 111, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1229, 2);
            WriteAttributeValue("", 1201, "/admin/editcategory/", 1201, 20, true);
#line 35 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
WriteAttributeValue("", 1221, item.Id, 1221, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1230, 43, true);
            WriteLiteral(">Edit</a>\r\n                                ");
            EndContext();
            BeginContext(1273, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76bf3a7990c8efa064b3e76c4db690694139ab537089", async() => {
                BeginContext(1348, 76, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"categoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1424, "\"", 1440, 1);
#line 37 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
WriteAttributeValue("", 1432, item.Id, 1432, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1441, 142, true);
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1590, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 42 "C:\Users\halilozat\source\repos\ShopApp\ShopApp.WebUI\Areas\AdminPanel\Views\CategoryAdmin\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1681, 86, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1786, 134, true);
                WriteLiteral(" \r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#categoriesTable\').DataTable();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp.WebUI.Areas.AdminPanel.Models.CategoryAdminListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
