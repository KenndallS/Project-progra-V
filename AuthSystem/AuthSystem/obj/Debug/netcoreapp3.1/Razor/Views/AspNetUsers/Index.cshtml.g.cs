#pragma checksum "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd92c6f8a6bd3894989e9a63bf183872bc9dd690"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AspNetUsers_Index), @"mvc.1.0.view", @"/Views/AspNetUsers/Index.cshtml")]
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
#line 1 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\_ViewImports.cshtml"
using AuthSystem;

#line default
#line hidden
#line 2 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\_ViewImports.cshtml"
using AuthSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd92c6f8a6bd3894989e9a63bf183872bc9dd690", @"/Views/AspNetUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e36433eadb792ac9a42d34be1d1c371fa61293e0", @"/Views/_ViewImports.cshtml")]
    public class Views_AspNetUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AuthSystem.Models.AspNetUsers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd92c6f8a6bd3894989e9a63bf183872bc9dd6904551", async() => {
                WriteLiteral("Crear un nuevo usuario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#line 16 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 19 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 22 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 25 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 28 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 31 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 34 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 37 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 40 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 43 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 46 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 49 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 52 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 55 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 58 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#line 61 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#line 66 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#line 70 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 73 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NormalizedUserName));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 76 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 79 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NormalizedEmail));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 82 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailConfirmed));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 85 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordHash));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 88 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SecurityStamp));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 91 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConcurrencyStamp));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 94 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 97 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumberConfirmed));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 100 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TwoFactorEnabled));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 103 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LockoutEnd));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 106 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LockoutEnabled));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 109 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccessFailedCount));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 112 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#line 115 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd92c6f8a6bd3894989e9a63bf183872bc9dd69015857", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd92c6f8a6bd3894989e9a63bf183872bc9dd69018006", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd92c6f8a6bd3894989e9a63bf183872bc9dd69020161", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#line 123 "C:\Users\alexa\Documents\GitHub\Project-progra\AuthSystem\AuthSystem\Views\AspNetUsers\Index.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AuthSystem.Models.AspNetUsers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
