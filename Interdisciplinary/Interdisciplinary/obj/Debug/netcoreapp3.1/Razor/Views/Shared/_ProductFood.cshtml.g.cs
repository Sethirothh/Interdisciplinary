#pragma checksum "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\Shared\_ProductFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1a65bfa050684e7d26ebec0b56601821b11362b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductFood), @"mvc.1.0.view", @"/Views/Shared/_ProductFood.cshtml")]
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
#line 1 "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\_ViewImports.cshtml"
using Interdisciplinary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\_ViewImports.cshtml"
using Interdisciplinary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a65bfa050684e7d26ebec0b56601821b11362b", @"/Views/Shared/_ProductFood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f4c8588e9379963aa53f7a1bdb1857f518eafe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interdisciplinary.Models.Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"product\" data-category=\"");
#nullable restore
#line 3 "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\Shared\_ProductFood.cshtml"
                               Write(Html.DisplayFor(model => model.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <div class=\"image\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1a65bfa050684e7d26ebec0b56601821b11362b4156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 166, "~/uploaded-images/", 166, 18, true);
#nullable restore
#line 5 "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\Shared\_ProductFood.cshtml"
AddHtmlAttributeValue("", 184, Html.DisplayFor(model => model.Picture), 184, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <h5>\r\n        ");
#nullable restore
#line 8 "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\Shared\_ProductFood.cshtml"
   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </h5>\r\n    <p>\r\n        ");
#nullable restore
#line 12 "C:\Users\asger\OneDrive\Skrivebord\Web Development\Interdiscplinary\Interdisciplinary\Interdisciplinary\Interdisciplinary\Views\Shared\_ProductFood.cshtml"
   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" DKK / stk. \r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interdisciplinary.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
