#pragma checksum "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e1701fad1cf6a12d429224f6117221844817d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminRoleList_Views_AdminRolesList_Index), @"mvc.1.0.view", @"/Areas/AdminRoleList/Views/AdminRolesList/Index.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\_ViewImports.cshtml"
using zepllin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\_ViewImports.cshtml"
using zepllin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\_ViewImports.cshtml"
using zepllin.Extra;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e1701fad1cf6a12d429224f6117221844817d1", @"/Areas/AdminRoleList/Views/AdminRolesList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e94122892ecbca10176e98ccc63bda2c932096b", @"/Areas/AdminRoleList/Views/_ViewImports.cshtml")]
    public class Areas_AdminRoleList_Views_AdminRolesList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NormalUserRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminRoleList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminRolesList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleApply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("roleeditcomplete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("roleeditfailure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e1701fad1cf6a12d429224f6117221844817d18036", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 5 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
      Write(UrlPaths.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width,initial-scale=1.0\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 241, "\"", 275, 1);
#nullable restore
#line 8 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 251, UrlPaths.metadecription, 251, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\"");
                BeginWriteAttribute("href", " href=\"", 330, "\"", 372, 1);
#nullable restore
#line 9 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 337, Url.Content(UrlPaths.favicon16x16), 337, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"32x32\"");
                BeginWriteAttribute("href", " href=\"", 427, "\"", 469, 1);
#nullable restore
#line 10 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 434, Url.Content(UrlPaths.favicon32x32), 434, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"apple-touch-icon\" sizes=\"180x180\"");
                BeginWriteAttribute("href", " href=\"", 521, "\"", 565, 1);
#nullable restore
#line 11 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 528, Url.Content(UrlPaths.favicon180x180), 528, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e1701fad1cf6a12d429224f6117221844817d110538", async() => {
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 656, "\"", 694, 1);
#nullable restore
#line 13 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 663, Url.Content(UrlPaths.bulmacss), 663, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 746, "\"", 783, 1);
#nullable restore
#line 14 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 753, Url.Content(UrlPaths.sitecss), 753, 30, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 827, "\"", 862, 1);
#nullable restore
#line 15 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 833, Url.Content(UrlPaths.jquery), 833, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 913, "\"", 963, 1);
#nullable restore
#line 16 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 919, Url.Content(UrlPaths.jqueryunobtrusiveajax), 919, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1014, "\"", 1053, 1);
#nullable restore
#line 17 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 1020, Url.Content(UrlPaths.infoscript), 1020, 33, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e1701fad1cf6a12d429224f6117221844817d114181", async() => {
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1173, "\"", 1211, 1);
#nullable restore
#line 20 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 1180, Url.Content(UrlPaths.bulmacss), 1180, 31, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <link rel=\"stylesheet\" type=\"text/css\"");
                    BeginWriteAttribute("href", " href=\"", 1263, "\"", 1303, 1);
#nullable restore
#line 21 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 1270, Url.Content(UrlPaths.minsitecss), 1270, 33, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1347, "\"", 1382, 1);
#nullable restore
#line 22 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 1353, Url.Content(UrlPaths.jquery), 1353, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1433, "\"", 1483, 1);
#nullable restore
#line 23 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 1439, Url.Content(UrlPaths.jqueryunobtrusiveajax), 1439, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script>\r\n        <script type=\"text/javascript\"");
                    BeginWriteAttribute("src", " src=\"", 1534, "\"", 1576, 1);
#nullable restore
#line 24 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
WriteAttributeValue("", 1540, Url.Content(UrlPaths.mininfoscript), 1540, 36, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></script> \r\n    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e1701fad1cf6a12d429224f6117221844817d118551", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
Write(await Component.InvokeAsync("AdminHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e1701fad1cf6a12d429224f6117221844817d119088", async() => {
                    WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"columns is-multiline is-centered mt-2\">\r\n");
#nullable restore
#line 32 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"column\">\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9e1701fad1cf6a12d429224f6117221844817d119824", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 35 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].RoleId);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9e1701fad1cf6a12d429224f6117221844817d121633", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 36 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].RoleName);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9e1701fad1cf6a12d429224f6117221844817d123444", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 37 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].IsSelected);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
                   Write(Model[i].RoleName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <div class=\"column\">\r\n                    <button class=\"button is-small is-black is-fullwidth has-text-white\">Rol Uygula</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\fatih\source\repos\zepllin\zepllin\Areas\AdminRoleList\Views\AdminRolesList\Index.cshtml"
                                                                                                          WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NormalUserRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591