#pragma checksum "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be5895e50c3bdbf08100ae062c31d38f8da89c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageCustomer), @"mvc.1.0.view", @"/Views/Admin/ManageCustomer.cshtml")]
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
#line 1 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
using MovieTicketBooking.Logics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be5895e50c3bdbf08100ae062c31d38f8da89c2", @"/Views/Admin/ManageCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ManageCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
  
    ViewBag.Title = "Quản lý khách hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table border=1 style=""width:100%"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Email</th>
            <th>Tên</th>
            <th>Số điện thoại</th>
            <th>Số dư trong ví</th>
            <th>Trạng thái</th>
            <th>Quản lý</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
         foreach (Customer c in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
               Write(c.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
               Write(AccountLogic.GetAccountById(c.CustomerId).Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
               Write(c.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
               Write(c.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
               Write(c.BalanceInWallet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
                Write(((bool)AccountLogic.GetAccountById(c.CustomerId).IsActive)?"Active":"Inactive");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <!-- Button trigger modal -->\r\n                <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalCenter-");
#nullable restore
#line 35 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
                                                                                                              Write(c.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Nạp tiền\r\n                    </button>\r\n\r\n                    <!-- Modal -->\r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1351, "\"", 1388, 2);
            WriteAttributeValue("", 1356, "exampleModalCenter-", 1356, 19, true);
#nullable restore
#line 40 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
WriteAttributeValue("", 1375, c.CustomerId, 1375, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLongTitle1"">Nạp tiền cho ");
#nullable restore
#line 44 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
                                                                                                Write(c.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">×</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3be5895e50c3bdbf08100ae062c31d38f8da89c28795", async() => {
                WriteLiteral(@"
                                        <label>Nhập số tiền:</label>
                                        <input type=""number"" name=""money"" required>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>

                                            <input type=""submit"" class=""btn btn-primary"" value=""Nạp tiền"">
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2195, "/Admin/AddMoney?cid=", 2195, 20, true);
#nullable restore
#line 50 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
AddHtmlAttributeValue("", 2215, c.CustomerId, 2215, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2982, "\"", 3026, 2);
            WriteAttributeValue("", 2989, "/Admin/Active?accountId=", 2989, 24, true);
#nullable restore
#line 63 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
WriteAttributeValue("", 3013, c.CustomerId, 3013, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
                                                                                        Write(((bool)AccountLogic.GetAccountById(c.CustomerId).IsActive)?"Inactive":"Active");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div style=\"width:100%; padding:30px\">\r\n    <nav aria-label=\"Page navigation example\" style=\"margin:0 auto\">\r\n        <ul class=\"pagination\">\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3407, "\"", 3465, 2);
            WriteAttributeValue("", 3414, "/Admin/ManageCustomer/page=", 3414, 27, true);
#nullable restore
#line 73 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
WriteAttributeValue("", 3441, ViewBag.currentPage-1, 3441, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                    <span class=\"sr-only\">Previous</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 78 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
             for (var i = 1; i <= ViewBag.numberPage; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3785, "\"", 3821, 2);
            WriteAttributeValue("", 3792, "/Admin/ManageCustomer?page=", 3792, 27, true);
#nullable restore
#line 80 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
WriteAttributeValue("", 3819, i, 3819, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 81 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3925, "\"", 3983, 2);
            WriteAttributeValue("", 3932, "/Admin/ManageCustomer/page=", 3932, 27, true);
#nullable restore
#line 84 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ManageCustomer.cshtml"
WriteAttributeValue("", 3959, ViewBag.currentPage+1, 3959, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                    <span class=\"sr-only\">Next</span>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
