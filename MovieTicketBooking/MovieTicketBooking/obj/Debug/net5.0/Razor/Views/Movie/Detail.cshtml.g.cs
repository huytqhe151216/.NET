#pragma checksum "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1efbde8a1ab2a27eac1c5dbf25e967e06660e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Detail), @"mvc.1.0.view", @"/Views/Movie/Detail.cshtml")]
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
#line 8 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
using MovieTicketBooking.Logics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1efbde8a1ab2a27eac1c5dbf25e967e06660e81", @"/Views/Movie/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:350px;width:247px; object-fit: contain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
  
    ViewBag.Title = Model.MovieName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .fillcolor {\r\n        color: red;\r\n    }\r\n</style>\r\n<div margine=\"max-width:80%; margin:0 auto\">\r\n    <h3>N???i dung phim</h3>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\" style=\"height:350px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1efbde8a1ab2a27eac1c5dbf25e967e06660e814989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 599, "~/movie/images/", 599, 15, true);
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
AddHtmlAttributeValue("", 614, Model.Img, 614, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\" col-md-9\">\r\n            <div class=\"row\">\r\n                <h3 class=\"col-md-10\">");
#nullable restore
#line 25 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                 Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 812, "\"", 834, 1);
#nullable restore
#line 26 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
WriteAttributeValue("", 820, Model.MovieId, 820, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"mid\" />\r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                  
                    var setting = new JsonSerializerSettings();
                    setting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    string json = Context.Session.GetString("Account");
                    Account account = null;
                    if (json != null)
                    {
                        account = JsonConvert.DeserializeObject<Account>(json, setting);
                    }
                    bool checkLove = false;
                    if (account != null)
                    {
                        checkLove = MovieLogic.CheckLoveMovieByCustomer(account.AccountId, Model.MovieId);
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <svg");
            BeginWriteAttribute("class", " class=\"", 1590, "\"", 1711, 3);
            WriteAttributeValue("", 1598, "col-md-2", 1598, 8, true);
            WriteAttributeValue("   \r\n                ", 1606, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 43 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                  
                    if(checkLove) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                             Write(Html.Raw("fillcolor"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                        ;
                

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1627, 80, false);
            WriteAttributeValue("\r\n\r\n", 1707, "", 1711, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""heart"" 
                onclick=""AddFavourite()"" 
                xmlns=""http://www.w3.org/2000/svg"" 
                width=""30"" 
                height=""30"" 
                fill=""currentColor"" 
                class=""bi bi-heart-fill"" viewBox=""0 0 16 16"">");
            WriteLiteral("                    <path fill-rule=\"evenodd\" d=\"M8 1.314C12.438-3.248 23.534 4.735 8 15-7.534 4.736 3.562-3.248 8 1.314z\" />\r\n                </svg>\r\n            </div>\r\n\r\n            <div><span style=\"font-weight:600\">Di???n vi??n:</span> ");
#nullable restore
#line 58 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                            Write(Model.Actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>\r\n                <span style=\"font-weight:600\">Th??? lo???i: </span>");
#nullable restore
#line 60 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                                 

                    for (var i = 0; i < @Model.GenreMovies.Count; i++)
                    {
                        for (var j = 0; j < ViewBag.ListGenres.Count; j++)
                        {
                            if (i == j)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                            Write(ViewBag.ListGenres[j].GenreName+", ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                                       
                            }
                        }
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div><span style=\"font-weight:600\">Kh???i chi???u:</span> ");
#nullable restore
#line 75 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                             Write(Model.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><span style=\"font-weight:600\">Th???i l?????ng:</span> ");
#nullable restore
#line 76 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                             Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ph??t</div>\r\n            <div><span style=\"font-weight:600\">Gi???i h???n tu???i:</span> ");
#nullable restore
#line 77 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                                Write(ViewBag.AgeLimit.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><span style=\"font-weight:600\">M?? t???:</span> ");
#nullable restore
#line 78 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <iframe style=\"margin:30px 30px\" width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 3282, "\"", 3332, 2);
            WriteAttributeValue("", 3288, "https://www.youtube.com/embed/", 3288, 30, true);
#nullable restore
#line 81 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
WriteAttributeValue("", 3318, Model.Trailer, 3318, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
</div>
<script>
    function AddFavourite(){
    var mid = $('#mid').val();
    $.ajax({
              url: ""/Customer/AddFavourite/""+mid,
              type: ""post"",
              data: {

              },
              success: function() {
                   $(""#heart"").toggleClass(""fillcolor"");
          },
          error: function(){
              window.location.href = ""/User/Login"";
          }
      });
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
