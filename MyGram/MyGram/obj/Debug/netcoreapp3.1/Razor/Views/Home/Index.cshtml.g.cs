#pragma checksum "/Users/moigolez/Desktop/MyGramCS115/MyGram/MyGram/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e480513456b2a077d27e411c3d921f4579c05ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/moigolez/Desktop/MyGramCS115/MyGram/MyGram/Views/_ViewImports.cshtml"
using MyGram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/moigolez/Desktop/MyGramCS115/MyGram/MyGram/Views/_ViewImports.cshtml"
using MyGram.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e480513456b2a077d27e411c3d921f4579c05ca", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03436bc665f1d74e611f06357016a07baccd8dbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/moigolez/Desktop/MyGramCS115/MyGram/MyGram/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e480513456b2a077d27e411c3d921f4579c05ca3896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""MainContainer"">
    <table id=""MainProfileInformation"">
        <tbody>
            <tr>
                <td rowspan=""3"">
                    <img src=""https://i.pinimg.com/originals/4e/64/7a/4e647abd2f8c16af867ad64a5cc0b04c.jpg"" />
                </td>
                <td>
                    <span>Moises Golez</span>
                </td>
                <td>
                    <button class=""GramButtons"">Follow</button>
                </td>
            </tr>
            <tr>
                <td colspan=""2"">
                    <span class=""FontBold"">6</span>
                    <span>Posts</span>
                    <span class=""FontBold"">No</span>
                    <span>Followers</span>
                    <span class=""FontBold"">0</span>
                    <span>Following</span>
                </td>
            </tr>
            <tr>
                <td colspan=""2"">
                    <span>This is an example description</span>
                </td>
            </tr>
        </tbody>
 ");
            WriteLiteral(@"   </table>
    <div id=""SectionsTable"">
        <table id=""Sections"">
            <tbody>
                <tr>
                    <td>
                        <img src=""https://cdn.cnn.com/cnnnext/dam/assets/200713132223-delta-airlines-0403-full-169.jpg"" />
                        <br>
                        <span>My Airline</span>
                    </td>
                    <td>
                        <img src=""https://i0.wp.com/softwareengineeringdaily.com/wp-content/uploads/2019/09/delta-airlines-750x437.jpg?resize=730%2C389&ssl=1"" />
                        <br>
                        <span>Keep Climbing</span>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <div id=""Options"">
        <table id=""OptionsTable"">
            <tbody>
                <tr>
                    <td>
                        <span>POSTS</span>
                    </td>
                    <td>
                        <span>REELS</span>
                    </td>
           ");
            WriteLiteral(@"         <td>
                        <span>IGTV</span>
                    </td>
                    <td>
                        <span>TAGGED</span>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>


    <div id=""MainImagesContainer"">
        <table id=""MainImages"">
            <tbody>
                <tr>
                    <td>
                        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSyqdFdpm5Ss2w9Wl6Y2EScnzWG-EIcyXA1fQ&usqp=CAU"" />
                    </td>
                    <td>
                        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT6FWS8ObB4flcwvaKrejU1oDdYcX-09o3WDw&usqp=CAU"" />
                    </td>
                    <td>
                        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjuruhr3NO1A9AZh3dZsROe0g71mCxDgdqyw&usqp=CAU"" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <img s");
            WriteLiteral(@"rc=""https://cdn.pixabay.com/photo/2012/04/12/23/52/germany-31017__340.png"" />
                    </td>
                    <td>
                        <img src=""https://wallpapercave.com/wp/wp3281804.jpg"" />
                    </td>
                    <td>
                        <iframe width=""200"" height=""200"" src=""https://www.youtube.com/embed/FObcHFtRNJM"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                    </td>
                </tr>

            </tbody>
        </table>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591