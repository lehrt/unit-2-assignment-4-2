#pragma checksum "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Employer/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f746982f103c3c74dfa47e76ed6f2a7d8a6f53d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_Delete), @"mvc.1.0.view", @"/Views/Employer/Delete.cshtml")]
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
#line 1 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/_ViewImports.cshtml"
using TechJobsPersistent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/_ViewImports.cshtml"
using TechJobsPersistent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f746982f103c3c74dfa47e76ed6f2a7d8a6f53d", @"/Views/Employer/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562d117cb780fcefb28ecb393f9c812ee41d2558", @"/Views/_ViewImports.cshtml")]
    public class Views_Employer_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Delete Employer</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f746982f103c3c74dfa47e76ed6f2a7d8a6f53d3649", async() => {
                WriteLiteral("\n");
#nullable restore
#line 10 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Employer/Delete.cshtml"
     foreach (var employer in ViewBag.employers)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-group\">\n            <label>\n                <span>");
#nullable restore
#line 14 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Employer/Delete.cshtml"
                 Write(employer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                <input type=\"checkbox\" name=\"eventIds\"");
                BeginWriteAttribute("value", " value=\"", 379, "\"", 399, 1);
#nullable restore
#line 15 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Employer/Delete.cshtml"
WriteAttributeValue("", 387, employer.Id, 387, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\n            </label>\n        </div>\n");
#nullable restore
#line 18 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Employer/Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <input type=\"submit\" value=\"Delete Selected Employer(s)\" class=\"btn btn-danger\">\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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