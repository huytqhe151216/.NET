#pragma checksum "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7cbdcdf53a03d00d4dda77fc6ca8fd9f326613c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7cbdcdf53a03d00d4dda77fc6ca8fd9f326613c", @"/Views/Movie/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
  
    ViewBag.Title = Model.MovieName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div margine=\"max-width:80%; margin:0 auto\">\r\n    <h3>Nội dung phim</h3>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\" style=\"height:350px\">\r\n            <img style=\"height:100%;width:100%; object-fit: contain\"");
            BeginWriteAttribute("src", " src=\"", 526, "\"", 542, 1);
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
WriteAttributeValue("", 532, Model.Img, 532, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 543, "\"", 549, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\" col-md-9\">\r\n            <div class=\"row\">\r\n                <h3 class=\"col-md-10\">");
#nullable restore
#line 20 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                 Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 730, "\"", 752, 1);
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
WriteAttributeValue("", 738, Model.MovieId, 738, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"mid\" />\r\n");
#nullable restore
#line 22 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                  
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
            WriteLiteral("                <svg class=\"col-md-2\" id=\"heart\" onclick=\"AddFavourite()\" xmlns=\"http://www.w3.org/2000/svg\" width=\"30\" height=\"30\" fill=\"currentColor\" class=\"bi bi-heart-fill\" viewBox=\"0 0 16 16\"");
            BeginWriteAttribute("style", " style=\"", 1684, "\"", 1732, 2);
            WriteAttributeValue("", 1692, "color:", 1692, 6, true);
#nullable restore
#line 37 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
WriteAttributeValue("", 1698, checkLove == true?"red":"black", 1698, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <path fill-rule=\"evenodd\" d=\"M8 1.314C12.438-3.248 23.534 4.735 8 15-7.534 4.736 3.562-3.248 8 1.314z\" />\r\n                </svg>\r\n            </div>\r\n\r\n            <div><span style=\"font-weight:600\">Diễn viên:</span> ");
#nullable restore
#line 42 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                            Write(Model.Actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>\r\n                <span style=\"font-weight:600\">Thể loại: </span>");
#nullable restore
#line 44 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                                 

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
#line 52 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                            Write(ViewBag.ListGenres[j].GenreName+", ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                                       
                            }
                        }
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div><span style=\"font-weight:600\">Khởi chiếu:</span> ");
#nullable restore
#line 59 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                             Write(Model.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><span style=\"font-weight:600\">Thời lượng:</span> ");
#nullable restore
#line 60 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                             Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" phút</div>\r\n            <div><span style=\"font-weight:600\">Giới hạn tuổi:</span> ");
#nullable restore
#line 61 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                                Write(ViewBag.AgeLimit.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><span style=\"font-weight:600\">Mô tả:</span> ");
#nullable restore
#line 62 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
                                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <iframe style=\"margin:30px 30px\" width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 3036, "\"", 3086, 2);
            WriteAttributeValue("", 3042, "https://www.youtube.com/embed/", 3042, 30, true);
#nullable restore
#line 65 "C:\Users\ADMIN\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Movie\Detail.cshtml"
WriteAttributeValue("", 3072, Model.Trailer, 3072, 14, false);

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
                      window.location.reload()
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
