#pragma checksum "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a299acc30e14846f6e2f1914d37b1412ce8e7b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_IssueByUser), @"mvc.1.0.view", @"/Views/Dashboard/IssueByUser.cshtml")]
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
#line 1 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\_ViewImports.cshtml"
using Library_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\_ViewImports.cshtml"
using Library_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a299acc30e14846f6e2f1914d37b1412ce8e7b97", @"/Views/Dashboard/IssueByUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72aaef0067eb95094098438a8267f129b82381f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_IssueByUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library_Management_System.Models.IssueDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/IndexStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a299acc30e14846f6e2f1914d37b1412ce8e7b974474", async() => {
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
  
    ViewData["Title"] = "IssueByUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Books Issued By User</h4>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Book_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Book_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Book_Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.User_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Issue_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book_Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.User_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Issue_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<h3 class=\"text-danger\">");
#nullable restore
#line 68 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\Library_Management_System\Library_Management_System\Views\Dashboard\IssueByUser.cshtml"
                   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a299acc30e14846f6e2f1914d37b1412ce8e7b9712452", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library_Management_System.Models.IssueDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
