#pragma checksum "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Shared\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83faa5211695e8766035271f011dbdced5f09a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NotFound), @"mvc.1.0.view", @"/Views/Shared/NotFound.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\_ViewImports.cshtml"
using zepllin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\_ViewImports.cshtml"
using zepllin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\_ViewImports.cshtml"
using zepllin.Extra;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83faa5211695e8766035271f011dbdced5f09a52", @"/Views/Shared/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e94122892ecbca10176e98ccc63bda2c932096b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""hero is-fullheight is-light"">
    <div class=""hero-body pt-b-30"">
        <div class=""container has-text-centered"">
            <div class=""column is-4 is-offset-4"">
                <h1 class=""title"">
                    <span class=""is-size-2 has-text-centered is-black"">pPage Not Found</span>
                    <span>");
#nullable restore
#line 7 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Shared\NotFound.cshtml"
                     Write(ViewBag.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </h1>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 406, "\"", 440, 1);
#nullable restore
#line 9 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Shared\NotFound.cshtml"
WriteAttributeValue("", 413, Url.Action("Index","Home"), 413, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"nofollow\" class=\"is-black has-text-centered is-black\">Return</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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