#pragma checksum "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68e0acbea3f79f43a98822553e247d2f19cf36d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(proLanguages.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace proLanguages.Pages
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
#line 1 "C:\Users\vishva shah\proLanguages\Pages\_ViewImports.cshtml"
using proLanguages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68e0acbea3f79f43a98822553e247d2f19cf36d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824664439e14b1a7f9382f11d696aebbc672eb7a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
  
    ViewData["Title"] = "Programming Languages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
  
    var quoteOfDay = "when you don't create things, you become defined by your tastes rather than ability. your tastes only narrow & exclude people. so create.";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 10 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
Write(quoteOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
  
    quoteOfDay = "Programs must be written for people to read, and only incidentally for machines to execute.";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 15 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
Write(quoteOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
  
    var ProLang = new[] {
        new {
            languageName = "Laravel" ,
            useBy = "Web Developer",
            type = "Open Source PHP language"
        },
        new {
            languageName = "Fortan Language",
            useBy = "Scientists",
            type = "Number Crushing Language"
        },
        new {
            languageName = "COBOL(Common Business Oriented Language)",
            useBy = "Governments and Companies",
            type = " Finance, Administrative and Business Systems"
        },
        new{
            languageName = "Pearl Language",
            useBy = "Web Developers",
            type = "UNIX- Based File Management Language"
        },
        new {
            languageName = "Paython",
            useBy = "Web Developers",
            type = "open source Programming Language"
        } 
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
 for (var i=0; i<ProLang.Length; i++) 
{
    var lang = ProLang[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Name of the Programming Language : ");
#nullable restore
#line 50 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                                        Write(lang.languageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 50 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                                                                           
    var user = ProLang[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Programming Language mostly used by : ");
#nullable restore
#line 52 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                                           Write(user.useBy);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 52 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                                                                       
    var lanType = ProLang[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Type of the Language : ");
#nullable restore
#line 54 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                            Write(lanType.type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 54 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                                                          
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n&nbsp;\r\n<p>Date and Time : ");
#nullable restore
#line 58 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
              Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
            WriteLiteral("@prgrammingLanguage</p>\r\n<p>My Email Id : W0784026@myscc.ca</p>\r\n<p>Time of Last updated : ");
#nullable restore
#line 61 "C:\Users\vishva shah\proLanguages\Pages\Index.cshtml"
                      Write(DateTime.Now - TimeSpan.FromDays(1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n&nbsp:\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
