#pragma checksum "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb39aafa1f2f0269c3c0e9f30c8d52b26f0934b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\_ViewImports.cshtml"
using zepllin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\_ViewImports.cshtml"
using zepllin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\_ViewImports.cshtml"
using zepllin.Extra;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb39aafa1f2f0269c3c0e9f30c8d52b26f0934b5", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e94122892ecbca10176e98ccc63bda2c932096b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb39aafa1f2f0269c3c0e9f30c8d52b26f0934b54258", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 4 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(UrlPaths.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width,initial-scale=1.0\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 214, "\"", 248, 1);
#nullable restore
#line 7 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 224, UrlPaths.metadecription, 224, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\"");
                BeginWriteAttribute("href", " href=\"", 303, "\"", 345, 1);
#nullable restore
#line 8 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 310, Url.Content(UrlPaths.favicon16x16), 310, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"32x32\"");
                BeginWriteAttribute("href", " href=\"", 400, "\"", 442, 1);
#nullable restore
#line 9 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 407, Url.Content(UrlPaths.favicon32x32), 407, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"apple-touch-icon\" sizes=\"180x180\"");
                BeginWriteAttribute("href", " href=\"", 494, "\"", 538, 1);
#nullable restore
#line 10 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 501, Url.Content(UrlPaths.favicon180x180), 501, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb39aafa1f2f0269c3c0e9f30c8d52b26f0934b56691", async() => {
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 629, "\"", 667, 1);
#nullable restore
#line 12 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 636, Url.Content(UrlPaths.bulmacss), 636, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 719, "\"", 756, 1);
#nullable restore
#line 13 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 726, Url.Content(UrlPaths.sitecss), 726, 30, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 808, "\"", 857, 1);
#nullable restore
#line 14 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 815, Url.Content(UrlPaths.justifiedgallerycss), 815, 42, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 909, "\"", 959, 1);
#nullable restore
#line 15 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 916, Url.Content(UrlPaths.jqueryuibasethemecss), 916, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1011, "\"", 1056, 1);
#nullable restore
#line 16 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1018, Url.Content(UrlPaths.backtotopmincss), 1018, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1100, "\"", 1135, 1);
#nullable restore
#line 17 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1106, Url.Content(UrlPaths.jquery), 1106, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1186, "\"", 1236, 1);
#nullable restore
#line 18 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1192, Url.Content(UrlPaths.jqueryunobtrusiveajax), 1192, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1287, "\"", 1326, 1);
#nullable restore
#line 19 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1293, Url.Content(UrlPaths.infoscript), 1293, 33, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1377, "\"", 1428, 1);
#nullable restore
#line 20 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1383, Url.Content(UrlPaths.justifiedgalleryscript), 1383, 45, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1479, "\"", 1528, 1);
#nullable restore
#line 21 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1485, Url.Content(UrlPaths.jqueryuisearchscript), 1485, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1579, "\"", 1619, 1);
#nullable restore
#line 22 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1585, Url.Content(UrlPaths.modalscript), 1585, 34, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1670, "\"", 1714, 1);
#nullable restore
#line 23 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1676, Url.Content(UrlPaths.backtotopscript), 1676, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1765, "\"", 1805, 1);
#nullable restore
#line 24 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1771, Url.Content(UrlPaths.startscript), 1771, 34, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb39aafa1f2f0269c3c0e9f30c8d52b26f0934b514043", async() => {
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1925, "\"", 1963, 1);
#nullable restore
#line 27 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1932, Url.Content(UrlPaths.bulmacss), 1932, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 2015, "\"", 2055, 1);
#nullable restore
#line 28 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2022, Url.Content(UrlPaths.minsitecss), 2022, 33, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 2107, "\"", 2156, 1);
#nullable restore
#line 29 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2114, Url.Content(UrlPaths.justifiedgallerycss), 2114, 42, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 2208, "\"", 2258, 1);
#nullable restore
#line 30 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2215, Url.Content(UrlPaths.jqueryuibasethemecss), 2215, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 2310, "\"", 2355, 1);
#nullable restore
#line 31 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2317, Url.Content(UrlPaths.backtotopmincss), 2317, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2399, "\"", 2434, 1);
#nullable restore
#line 32 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2405, Url.Content(UrlPaths.jquery), 2405, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2485, "\"", 2535, 1);
#nullable restore
#line 33 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2491, Url.Content(UrlPaths.jqueryunobtrusiveajax), 2491, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2586, "\"", 2637, 1);
#nullable restore
#line 34 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2592, Url.Content(UrlPaths.justifiedgalleryscript), 2592, 45, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2688, "\"", 2737, 1);
#nullable restore
#line 35 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2694, Url.Content(UrlPaths.jqueryuisearchscript), 2694, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2788, "\"", 2830, 1);
#nullable restore
#line 36 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2794, Url.Content(UrlPaths.mininfoscript), 2794, 36, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2881, "\"", 2924, 1);
#nullable restore
#line 37 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2887, Url.Content(UrlPaths.minmodalscript), 2887, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2975, "\"", 3019, 1);
#nullable restore
#line 38 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2981, Url.Content(UrlPaths.backtotopscript), 2981, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 3070, "\"", 3113, 1);
#nullable restore
#line 39 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3076, Url.Content(UrlPaths.minstartscript), 3076, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb39aafa1f2f0269c3c0e9f30c8d52b26f0934b522128", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 43 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 44 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <a href=\"#\" rel=\"nofollow\" class=\"backTop\"></a>\r\n");
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
