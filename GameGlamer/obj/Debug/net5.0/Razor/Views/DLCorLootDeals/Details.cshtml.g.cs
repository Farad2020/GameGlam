#pragma checksum "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04b9d2a64bb1c8bf52c35836ab5d4dbf7fff997"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DLCorLootDeals_Details), @"mvc.1.0.view", @"/Views/DLCorLootDeals/Details.cshtml")]
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
#line 1 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\_ViewImports.cshtml"
using GameGlamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\_ViewImports.cshtml"
using GameGlamer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04b9d2a64bb1c8bf52c35836ab5d4dbf7fff997", @"/Views/DLCorLootDeals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafb58b9d39d5b5ef0a25d96a8c0256417840556", @"/Views/_ViewImports.cshtml")]
    public class Views_DLCorLootDeals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameGlamer.Models.DLCorLootDeal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 my_sidebar_gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/media/gifs/sidebar.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e04b9d2a64bb1c8bf52c35836ab5d4dbf7fff9975373", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e04b9d2a64bb1c8bf52c35836ab5d4dbf7fff9976434", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"pt-3\">\r\n        <h3 class=\"m-0 text-black my_main_header text-center\">");
#nullable restore
#line 16 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                                                         Write(Model.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-7\">\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 472, "\"", 480, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 508, "\"", 530, 1);
#nullable restore
#line 21 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
WriteAttributeValue("", 514, Model.thumbnail, 514, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-block w-100 h-100\" alt=\"...\">\r\n                </div>\r\n                <hr />\r\n                <dl class=\"row\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.worth != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.worth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.worth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 34 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.description != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 42 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 44 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.open_giveaway_url != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.open_giveaway_url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            <span><a class=\"text_det_link\"");
                BeginWriteAttribute("href", " href=\"", 1808, "\"", 1839, 1);
#nullable restore
#line 52 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
WriteAttributeValue("", 1815, Model.open_giveaway_url, 1815, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">Click here to get the information source!</a> </span>\r\n                        </dd>\r\n");
#nullable restore
#line 54 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.published_date != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 59 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.published_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 62 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.published_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 64 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.type != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 69 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 72 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.type));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 74 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.platforms != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 79 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.platforms));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 82 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.platforms));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 84 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.end_date != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 89 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.end_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 92 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.end_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 94 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 96 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.users != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 99 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.users));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 102 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.users));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 104 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 106 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                     if (Model.status != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 109 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 112 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </dd>\r\n");
#nullable restore
#line 114 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </dl>\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e04b9d2a64bb1c8bf52c35836ab5d4dbf7fff99721399", async() => {
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
            </div>

            <!--

                    temple
                https://media0.giphy.com/media/10GVNnqO2ZoAh2/giphy.gif?cid=790b7611680a81fc66c7b57577b7643cf1b0c593249651e9&rid=giphy.gif&ct=g
                        batman
                        https://media4.giphy.com/media/l3V0hWP5as4hPaxbi/giphy.gif?cid=790b7611ccdf76c15d17cfa00058ba45a411ae8f78b409e9&rid=giphy.gif&ct=g

            -->
        </div>
    </div>
    <div class=""d-flex justify-content-end"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e04b9d2a64bb1c8bf52c35836ab5d4dbf7fff99723079", async() => {
                    WriteLiteral("Back to Main Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameGlamer.Models.DLCorLootDeal> Html { get; private set; }
    }
}
#pragma warning restore 1591
