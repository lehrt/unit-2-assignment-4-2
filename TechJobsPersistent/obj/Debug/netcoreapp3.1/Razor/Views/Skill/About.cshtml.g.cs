#pragma checksum "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a32b4b5069863480ced2ad3bf19461484cf01c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_About), @"mvc.1.0.view", @"/Views/Skill/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32b4b5069863480ced2ad3bf19461484cf01c9f", @"/Views/Skill/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562d117cb780fcefb28ecb393f9c812ee41d2558", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TechJobsPersistent.Models.JobSkill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No jobs with the given skill!</h1>\r\n");
#nullable restore
#line 6 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Jobs with the Skill: ");
#nullable restore
#line 9 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
                        Write(Model[0].Skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Skill Description: ");
#nullable restore
#line 10 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
                     Write(Model[0].Skill.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 13 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
         foreach (var jobSkill in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 15 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
           Write(jobSkill.Job.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 18 "/Users/theresalehr/Desktop/Visual Studio/unit_2/assignment-4/TechJobsPersistent/TechJobsPersistent/Views/Skill/About.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TechJobsPersistent.Models.JobSkill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
