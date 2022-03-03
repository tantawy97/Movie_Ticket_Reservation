#pragma checksum "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a5c5529d883f2869a69c36a30bf4fdd8ff4d62"
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
#line 1 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a5c5529d883f2869a69c36a30bf4fdd8ff4d62", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079eb81a01d1a792c4bbac455db6644dedc4b68f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("viewall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cinema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
  
	Layout="~/Views/Shared/_UserLayout.cshtml";
	ViewData["Title"] = "Home Page";
	int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slider movie-items"">
	<div class=""container"">
		<div class=""row"">
			<div class=""social-link"">
				<p>Follow us: </p>
				<a href=""#""><i class=""ion-social-facebook""></i></a>
				<a href=""#""><i class=""ion-social-twitter""></i></a>
				<a href=""#""><i class=""ion-social-googleplus""></i></a>
				<a href=""#""><i class=""ion-social-youtube""></i></a>
			</div>
	    	<div  class=""slick-multiItemSlider"">
");
#nullable restore
#line 20 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                 foreach(var item in Model.Movies){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t    \t\t<div class=\"movie-item\">\r\n\t    \t\t\t<div class=\"mv-img\">\r\n\t    \t\t\t\t<a href=\"#\"><img ");
#nullable restore
#line 23 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                    Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral(" alt=\"\" width=\"285\" height=\"437\"></a>\r\n\t    \t\t\t</div>\r\n\t    \t\t\t<div class=\"title-in\">\r\n\t    \t\t\t\t<div class=\"cate\">\r\n\t    \t\t\t\t\t<span class=\"blue\"><a href=\"#\">");
#nullable restore
#line 27 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                                      Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n\t    \t\t\t\t</div>\r\n\t    \t\t\t\t<h6><a href=\"#\">");
#nullable restore
#line 29 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\t    \t\t\t\r\n\t    \t\t\t</div>\r\n\t    \t\t</div>\r\n");
#nullable restore
#line 33 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</div>
	    </div>
	</div>
</div>
<div class=""movie-items"">
	<div class=""container"">
		<div class=""row ipad-width"">
			<div class=""col-md-8"">
				<div class=""title-hd"">
					<h2>Categories</h2>
					<a href=""#"" class=""viewall"">View all <i class=""ion-ios-arrow-right""></i></a>
				</div>
				<div class=""tabs"">
					
				    <div class=""tab-content"">
				        <div id=""tab1"" class=""tab active"">
				            <div class=""row"">
				            	<div class=""slick-multiItem"">
");
#nullable restore
#line 52 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                     foreach(var item in Model.Categories){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t            \t\t<div class=\"slide-it\">\r\n\t\t\t\t            \t\t\t<div class=\"movie-item\">\r\n\t\t\t\t\t            \t\t\t<div class=\"mv-img\">\r\n\t\t\t\t\t            \t\t\t\t<img src=\"images/uploads/mv-item1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1723, "\"", 1729, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div> 
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">");
#nullable restore
#line 62 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\t\t\t\t\t            \t\t\t\t\r\n\t\t\t\t\t            \t\t\t</div>\r\n\t\t\t\t\t            \t\t</div>\r\n\t\t\t\t            \t\t</div>\r\n");
#nullable restore
#line 67 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t            \t</div>\r\n\t\t\t\t            </div>\r\n\t\t\t       \t \t</div>\r\n\t\t\t\t    </div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"title-hd\">\r\n\t\t\t\t\t<h2>Our Cinemas</h2>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a5c5529d883f2869a69c36a30bf4fdd8ff4d628934", async() => {
                WriteLiteral("View all <i class=\"ion-ios-arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"tabs\">\r\n\t\t\t\t\t\r\n\t\t\t\t    <div class=\"tab-content\">\r\n\t\t\t\t      \r\n\t\t\t\t        <div id=\"tab22\" class=\"tab active\">\r\n\t\t\t\t           <div class=\"row\">\r\n\t\t\t\t            \t<div class=\"slick-multiItem\">\r\n");
#nullable restore
#line 85 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                     foreach(var item in Model.Cinemas){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t            \t\t<div class=\"slide-it\">\r\n\t\t\t\t            \t\t\t<div class=\"movie-item\">\r\n\t\t\t\t\t            \t\t\t<div class=\"mv-img\">\r\n\t\t\t\t\t            \t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2892, "\"", 2909, 1);
#nullable restore
#line 89 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
WriteAttributeValue("", 2898, item.Image, 2898, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2910, "\"", 2916, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""185"" height=""284"">
					            			</div>
					            			<div class=""hvr-inner"">
					            				<a  href=""moviesingle.html""> Read more <i class=""ion-android-arrow-dropright""></i> </a>
					            			</div>
					            			<div class=""title-in"">
					            				<h6><a href=""#"">");
#nullable restore
#line 95 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\t\t\t\t\t            \t\t\t\t<p><i class=\"ion-android-star\"></i><span>7.4</span> /10</p>\r\n\t\t\t\t\t            \t\t\t</div>\r\n\t\t\t\t\t            \t\t</div>\r\n\t\t\t\t            \t\t</div>\r\n");
#nullable restore
#line 100 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\r\n\t\t\t\r\n\t\t</div>\r\n\t\t</div>\r\n\t\t</div>\r\n\t\t</div>\r\n\t\t</div>\r\n\t\t</div>\r\n\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t<div class=\"sidebar\">\r\n\t\t\t\t\t<div class=\"ads\">\r\n\t\t\t\t\t\t<img src=\"images/uploads/ads1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3627, "\"", 3633, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"336\" height=\"296\">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"celebrities\">\r\n\t\t\t\t\t\t<h4 class=\"sb-title\">Spotlight Celebrities</h4>\r\n");
#nullable restore
#line 116 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                         foreach(var item in Model.Actors){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"celeb-item\">\r\n\t\t\t\t\t\t\t<a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 3860, "\"", 3877, 1);
#nullable restore
#line 118 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
WriteAttributeValue("", 3866, item.Image, 3866, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3878, "\"", 3884, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" height=\"70\"></a>\r\n\t\t\t\t\t\t\t<div class=\"celeb-author\">\r\n\t\t\t\t\t\t\t\t<h6><a href=\"#\">");
#nullable restore
#line 120 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 124 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Home\Index.cshtml"
							if(i==6){
								break;
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<a href=\"#\" class=\"btn\">See all Actors<i class=\"ion-ios-arrow-right\"></i></a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
