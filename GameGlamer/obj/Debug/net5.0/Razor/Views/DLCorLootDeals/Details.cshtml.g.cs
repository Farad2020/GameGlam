#pragma checksum "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bdc27bf1a61402d7dc4deffb3cdc58e2b4e6c33"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bdc27bf1a61402d7dc4deffb3cdc58e2b4e6c33", @"/Views/DLCorLootDeals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafb58b9d39d5b5ef0a25d96a8c0256417840556", @"/Views/_ViewImports.cshtml")]
    public class Views_DLCorLootDeals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameGlamer.Models.DLCorLootDeal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DLCorLootDeal</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.worth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.worth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.thumbnail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.thumbnail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.open_giveaway_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.open_giveaway_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.published_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.published_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.platforms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.platforms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.end_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.end_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.users));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.users));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.gamerpower_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.gamerpower_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.open_giveaway));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
       Write(Html.DisplayFor(model => model.open_giveaway));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bdc27bf1a61402d7dc4deffb3cdc58e2b4e6c3315413", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\Faraby\Desktop\Course 3 Semestr 6\DotNet Core\GameGlamProject\GameGlam\GameGlamer\Views\DLCorLootDeals\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bdc27bf1a61402d7dc4deffb3cdc58e2b4e6c3317604", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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