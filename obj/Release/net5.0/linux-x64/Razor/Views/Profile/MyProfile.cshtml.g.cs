#pragma checksum "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e149f1d9244237c13f68cf891b143e50509d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MyProfile), @"mvc.1.0.view", @"/Views/Profile/MyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e149f1d9244237c13f68cf891b143e50509d18", @"/Views/Profile/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e94122892ecbca10176e98ccc63bda2c932096b", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
  
    IgnoreBody();

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e149f1d9244237c13f68cf891b143e50509d184343", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 7 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
      Write(UrlPaths.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;");
#nullable restore
#line 7 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
                           Write(ViewData["username"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1.0"">
    <meta name=""mobile-web-app-capable"" content=""yes"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""theme-color"" content=""#212121"">
    <link rel=""manifest""");
                BeginWriteAttribute("href", " href=\"", 426, "\"", 463, 1);
#nullable restore
#line 13 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 433, Url.Content(UrlPaths.pwapath), 433, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 497, "\"", 558, 3);
#nullable restore
#line 14 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 507, UrlPaths.metadecription, 507, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 531, "&nbsp;", 531, 6, true);
#nullable restore
#line 14 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 537, ViewData["username"], 537, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\"");
                BeginWriteAttribute("href", " href=\"", 613, "\"", 655, 1);
#nullable restore
#line 15 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 620, Url.Content(UrlPaths.favicon16x16), 620, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"32x32\"");
                BeginWriteAttribute("href", " href=\"", 710, "\"", 752, 1);
#nullable restore
#line 16 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 717, Url.Content(UrlPaths.favicon32x32), 717, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"apple-touch-icon\" sizes=\"180x180\"");
                BeginWriteAttribute("href", " href=\"", 804, "\"", 848, 1);
#nullable restore
#line 17 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 811, Url.Content(UrlPaths.favicon180x180), 811, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e149f1d9244237c13f68cf891b143e50509d187870", async() => {
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 939, "\"", 977, 1);
#nullable restore
#line 19 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 946, Url.Content(UrlPaths.bulmacss), 946, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1029, "\"", 1066, 1);
#nullable restore
#line 20 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1036, Url.Content(UrlPaths.sitecss), 1036, 30, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1118, "\"", 1159, 1);
#nullable restore
#line 21 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1125, Url.Content(UrlPaths.dropzonecss), 1125, 34, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1211, "\"", 1260, 1);
#nullable restore
#line 22 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1218, Url.Content(UrlPaths.justifiedgallerycss), 1218, 42, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1312, "\"", 1356, 1);
#nullable restore
#line 23 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1319, Url.Content(UrlPaths.fontawesomecss), 1319, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1408, "\"", 1453, 1);
#nullable restore
#line 24 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1415, Url.Content(UrlPaths.backtotopmincss), 1415, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1505, "\"", 1552, 1);
#nullable restore
#line 25 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1512, Url.Content(UrlPaths.fontawesomeallcss), 1512, 40, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1604, "\"", 1654, 1);
#nullable restore
#line 26 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1611, Url.Content(UrlPaths.jqueryuibasethemecss), 1611, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1698, "\"", 1733, 1);
#nullable restore
#line 27 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1704, Url.Content(UrlPaths.jquery), 1704, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1784, "\"", 1835, 1);
#nullable restore
#line 28 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1790, Url.Content(UrlPaths.justifiedgalleryscript), 1790, 45, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1886, "\"", 1929, 1);
#nullable restore
#line 29 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1892, Url.Content(UrlPaths.dropzonescript), 1892, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1980, "\"", 2020, 1);
#nullable restore
#line 30 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 1986, Url.Content(UrlPaths.modalscript), 1986, 34, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2071, "\"", 2112, 1);
#nullable restore
#line 31 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2077, Url.Content(UrlPaths.uploadscript), 2077, 35, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2163, "\"", 2213, 1);
#nullable restore
#line 32 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2169, Url.Content(UrlPaths.jqueryunobtrusiveajax), 2169, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2264, "\"", 2313, 1);
#nullable restore
#line 33 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2270, Url.Content(UrlPaths.jqueryvalidatescript), 2270, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2364, "\"", 2403, 1);
#nullable restore
#line 34 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2370, Url.Content(UrlPaths.infoscript), 2370, 33, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2454, "\"", 2501, 1);
#nullable restore
#line 35 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2460, Url.Content(UrlPaths.jquerynotifyscript), 2460, 41, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2552, "\"", 2596, 1);
#nullable restore
#line 36 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2558, Url.Content(UrlPaths.backtotopscript), 2558, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2647, "\"", 2696, 1);
#nullable restore
#line 37 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2653, Url.Content(UrlPaths.jqueryuisearchscript), 2653, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 2747, "\"", 2787, 1);
#nullable restore
#line 38 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2753, Url.Content(UrlPaths.startscript), 2753, 34, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e149f1d9244237c13f68cf891b143e50509d1818353", async() => {
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 2907, "\"", 2945, 1);
#nullable restore
#line 41 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 2914, Url.Content(UrlPaths.bulmacss), 2914, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 2997, "\"", 3037, 1);
#nullable restore
#line 42 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3004, Url.Content(UrlPaths.minsitecss), 3004, 33, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 3089, "\"", 3130, 1);
#nullable restore
#line 43 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3096, Url.Content(UrlPaths.dropzonecss), 3096, 34, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 3182, "\"", 3231, 1);
#nullable restore
#line 44 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3189, Url.Content(UrlPaths.justifiedgallerycss), 3189, 42, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 3283, "\"", 3327, 1);
#nullable restore
#line 45 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3290, Url.Content(UrlPaths.fontawesomecss), 3290, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 3379, "\"", 3424, 1);
#nullable restore
#line 46 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3386, Url.Content(UrlPaths.backtotopmincss), 3386, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 3476, "\"", 3523, 1);
#nullable restore
#line 47 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3483, Url.Content(UrlPaths.fontawesomeallcss), 3483, 40, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 3575, "\"", 3625, 1);
#nullable restore
#line 48 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3582, Url.Content(UrlPaths.jqueryuibasethemecss), 3582, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 3669, "\"", 3704, 1);
#nullable restore
#line 49 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3675, Url.Content(UrlPaths.jquery), 3675, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 3755, "\"", 3806, 1);
#nullable restore
#line 50 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3761, Url.Content(UrlPaths.justifiedgalleryscript), 3761, 45, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 3857, "\"", 3900, 1);
#nullable restore
#line 51 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3863, Url.Content(UrlPaths.dropzonescript), 3863, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 3951, "\"", 3994, 1);
#nullable restore
#line 52 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 3957, Url.Content(UrlPaths.minmodalscript), 3957, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4045, "\"", 4089, 1);
#nullable restore
#line 53 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4051, Url.Content(UrlPaths.minuploadscript), 4051, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4140, "\"", 4190, 1);
#nullable restore
#line 54 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4146, Url.Content(UrlPaths.jqueryunobtrusiveajax), 4146, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4241, "\"", 4290, 1);
#nullable restore
#line 55 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4247, Url.Content(UrlPaths.jqueryvalidatescript), 4247, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4341, "\"", 4383, 1);
#nullable restore
#line 56 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4347, Url.Content(UrlPaths.mininfoscript), 4347, 36, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4434, "\"", 4478, 1);
#nullable restore
#line 57 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4440, Url.Content(UrlPaths.backtotopscript), 4440, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4529, "\"", 4576, 1);
#nullable restore
#line 58 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4535, Url.Content(UrlPaths.jquerynotifyscript), 4535, 41, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4627, "\"", 4676, 1);
#nullable restore
#line 59 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4633, Url.Content(UrlPaths.jqueryuisearchscript), 4633, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 4727, "\"", 4770, 1);
#nullable restore
#line 60 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
WriteAttributeValue("", 4733, Url.Content(UrlPaths.minstartscript), 4733, 37, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e149f1d9244237c13f68cf891b143e50509d1829560", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 64 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
Write(await Component.InvokeAsync("ProfileHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 65 "C:\Users\fatih\source\repos\zepllin\zepllin\Views\Profile\MyProfile.cshtml"
Write(await Component.InvokeAsync("ProfileContainer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <a href=\"#\" class=\"backTop\">Top</a>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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