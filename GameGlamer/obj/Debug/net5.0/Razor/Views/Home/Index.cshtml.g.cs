#pragma checksum "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bccbe4786fae46d370d9382221e53a9b7a1269b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bccbe4786fae46d370d9382221e53a9b7a1269b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafb58b9d39d5b5ef0a25d96a8c0256417840556", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeMainVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("banner_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/media/gifs/main_banner.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GameDeals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stretched-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DLCorLootDeals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""text-center"" style=""min-height: 200vh"">
    <h1 class=""display-4"">Welcome To <span class=""text-courgette"">GameGlam</span>!</h1>
    <p>Here you can observe game and loot giveaways, just like these observing the sea.</p>

    <div class=""my_image_banner"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bccbe4786fae46d370d9382221e53a9b7a1269b5889", async() => {
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


    <div class=""pb-2"">
        <h3 class=""m-0 text-black my_main_header"">Popular</h3>
        <hr />
    </div>

    <div class=""container"">
        <div class=""row"">
            <!-- click=""redirect(item.id)""  v-for=""item in content"" :key=""item.id""-->
");
#nullable restore
#line 24 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
             foreach (GameDeal gameDeal in Model.topGames)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3 pb-3\">\r\n                    <div class=\"card w-100\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 902, "\"", 927, 1);
#nullable restore
#line 28 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
WriteAttributeValue("", 908, gameDeal.thumbnail, 908, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title text-center\">");
#nullable restore
#line 30 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                          Write(gameDeal.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bccbe4786fae46d370d9382221e53a9b7a1269b8662", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                                             WriteLiteral(gameDeal.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>

    <div class=""py-2"">
        <h3 class=""m-0 text-black my_main_header"">Top Items</h3>
        <hr />
    </div>
    <div class=""container"">
        <nav class=""nav justify-content-center"">
            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                <button class=""nav-link active"" id=""nav-games-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-games"" type=""button"" role=""tab"" aria-controls=""nav-games"" aria-selected=""true"">Games</button>
                <button class=""nav-link"" id=""nav-loot-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-loot"" type=""button"" role=""tab"" aria-controls=""nav-loot"" aria-selected=""false"">Loot</button>
            </div>
        </nav>
        <div class=""tab-content"" id=""nav-tabContent"">
            <div class=""tab-pane fade show active"" id=""nav-games"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                <ul class=""list-group"">
");
#nullable restore
#line 54 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                     foreach (GameDeal gameDeal in Model.top16Games)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""list-group-item my_list_item mb-2"" tabindex=""0"">
                            <div class=""row"">
                                <div class=""col-3"">
                                    <img class=""my_search_list_image d-block w-100""");
            BeginWriteAttribute("src", " src=\"", 2620, "\"", 2645, 1);
#nullable restore
#line 59 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
WriteAttributeValue("", 2626, gameDeal.thumbnail, 2626, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""..."">
                                </div>
                                <div class=""col m-0 justify-content-start"">
                                    <div class=""text-left"">
                                        <span class=""item_primary_text"">");
#nullable restore
#line 63 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                                   Write(gameDeal.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <br />\r\n                                        <span class=\"item_secondary_text\">");
#nullable restore
#line 65 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                                     Write(gameDeal.platforms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bccbe4786fae46d370d9382221e53a9b7a1269b14655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                                                 WriteLiteral(gameDeal.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 71 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"tab-pane fade\" id=\"nav-loot\" role=\"tabpanel\" aria-labelledby=\"nav-profile-tab\">\r\n                <ul class=\"list-group\">\r\n");
#nullable restore
#line 76 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                     foreach (DLCorLootDeal lootDeal in Model.top16Loot)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item my_list_item mb-2\" tabindex=\"0\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-3\">\r\n                                <img class=\"my_search_list_image d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 3931, "\"", 3956, 1);
#nullable restore
#line 81 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
WriteAttributeValue("", 3937, lootDeal.thumbnail, 3937, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\">\r\n                            </div>\r\n                            <div class=\"col m-0 justify-content-start\">\r\n                                <div class=\"text-left\">\r\n                                    <span class=\"item_primary_text\">");
#nullable restore
#line 85 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                               Write(lootDeal.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <br />\r\n                                    <span class=\"item_secondary_text\">");
#nullable restore
#line 87 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                                 Write(lootDeal.platforms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bccbe4786fae46d370d9382221e53a9b7a1269b19794", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(lootDeal.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 93 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
        </div>
    </div>



</div>

<!--


                <ul class=""mdc-list mdc-list--two-line mdc-list--image-list"">
                    <li click=""redirect(item.id)"" class=""mdc-list-item"" tabindex=""0"" v-for=""item in loot"" :key=""item.id"">
                        <div class=""mdc-list--icon-list m-1"">
                            <div class=""my_search_list_image"">
                                <img v-bind:src=""item.thumbnail"" class=""d-block w-100"" alt=""..."">
                            </div>
                        </div>
                        <span class=""mdc-list-item__ripple""></span>
                        <span class=""mdc-list-item__text"">
                            <span class=""mdc-list-item__primary-text""></span>
                            <span class=""mdc-list-item__secondary-text""></span>
                        </span>
                        <div class=""w-100""></div>
                    </li>
                    <div class=");
            WriteLiteral("\"mdc-list-divider mt-1 mb-1\"></div>\r\n                </ul>\r\n-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeMainVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
