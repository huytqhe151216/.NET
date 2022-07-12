#pragma checksum "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd691f4b0c9f9e5a1aeda68489c83b4d1dba5abc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.VIews_Product_List), @"mvc.1.0.view", @"/VIews/Product/List.cshtml")]
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
#line 6 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
using BtNorthwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd691f4b0c9f9e5a1aeda68489c83b4d1dba5abc", @"/VIews/Product/List.cshtml")]
    #nullable restore
    public class VIews_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
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
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd691f4b0c9f9e5a1aeda68489c83b4d1dba5abc2939", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd691f4b0c9f9e5a1aeda68489c83b4d1dba5abc4131", async() => {
                WriteLiteral(@"
    <div style=""display:flex; justify-content:space-around"">
        <div>
            <h1>List Categories</h1>
            <table border=1>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Category</th>
                        <th>Show products</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>");
#nullable restore
#line 28 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                       Write(Html.ActionLink("Show all","List","Product",new{categoryId=0}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                     foreach (Category item in ViewBag.categories)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(Html.ActionLink("Show","List","Product",new{categoryId=item.CategoryId}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div>
            <h1>
                List product
            </h1>
            <table border=1>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Unit in stock</th>
                        <th>Quantity per unit</th>
                        <th>Price per unit</th>
                        <></>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 57 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                     foreach (Product product in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(product.UnitsInStock);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(product.QuantityPerUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                           Write(Html.ActionLink("Add to cart","List","Product", new{productId=@product.ProductId}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n            <nav aria-label=\"Page navigation example\">\r\n                <ul class=\"pagination\">\r\n                    <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 2801, "\"", 2882, 4);
                WriteAttributeValue("", 2808, "/Product/List?categoryId=", 2808, 25, true);
#nullable restore
#line 72 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
WriteAttributeValue("", 2833, ViewBag.categoryId, 2833, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2852, "&page=", 2852, 6, true);
#nullable restore
#line 72 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
WriteAttributeValue("", 2858, ViewBag.currentPage-1, 2858, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Previous</a></li>\r\n");
#nullable restore
#line 73 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                     for (var i = 1; i <= ViewBag.numberOfPage; i++)
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 3058, "\"", 3117, 4);
                WriteAttributeValue("", 3065, "/Product/List?categoryId=", 3065, 25, true);
#nullable restore
#line 75 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
WriteAttributeValue("", 3090, ViewBag.categoryId, 3090, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3109, "&page=", 3109, 6, true);
#nullable restore
#line 75 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
WriteAttributeValue("", 3115, i, 3115, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 75 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\n");
#nullable restore
#line 76 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("                   \r\n                    <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 3236, "\"", 3317, 4);
                WriteAttributeValue("", 3243, "/Product/List?categoryId=", 3243, 25, true);
#nullable restore
#line 78 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
WriteAttributeValue("", 3268, ViewBag.categoryId, 3268, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3287, "&page=", 3287, 6, true);
#nullable restore
#line 78 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
WriteAttributeValue("", 3293, ViewBag.currentPage+1, 3293, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Next</a></li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n    <div style=\"margin:0 auto\" >\r\n        <div>Have ");
#nullable restore
#line 84 "C:\Users\ADMIN\source\repos\SE1422_solution\BtNorthwind\VIews\Product\List.cshtml"
             Write(ViewBag.countCart);

#line default
#line hidden
#nullable disable
                WriteLiteral(" products in cart</div>\r\n        <a href=\"Cart/ViewCart\">View cart</a>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591