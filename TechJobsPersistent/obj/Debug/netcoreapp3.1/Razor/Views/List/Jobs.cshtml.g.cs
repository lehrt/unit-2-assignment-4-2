#pragma checksum "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b036eb1002528a712373d2abadcd548dd4ed6425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Jobs), @"mvc.1.0.view", @"/Views/List/Jobs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b036eb1002528a712373d2abadcd548dd4ed6425", @"/Views/List/Jobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562d117cb780fcefb28ecb393f9c812ee41d2558", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Jobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container body-content\">\r\n\r\n    <h1>");
#nullable restore
#line 3 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
   Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n            <th>Employer</th>\r\n            <th>Skills</th>\r\n        </tr>\r\n");
#nullable restore
#line 12 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
         foreach (var job in ViewBag.jobs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
               Write(job.JobId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
               Write(job.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
               Write(job.EmployerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
               Write(job.SkillText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/List/Jobs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
