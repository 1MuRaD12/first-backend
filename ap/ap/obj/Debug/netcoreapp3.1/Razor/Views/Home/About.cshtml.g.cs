#pragma checksum "C:\Users\User\Desktop\New folder (5)\ap\ap\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27064652ff09579be314d080f7d23ac81f24a76e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27064652ff09579be314d080f7d23ac81f24a76e", @"/Views/Home/About.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 style=\"color:aqua;\">About</h1>\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\New folder (5)\ap\ap\Views\Home\About.cshtml"
  
    int number = 5;

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Number: ");
#nullable restore
#line 6 "C:\Users\User\Desktop\New folder (5)\ap\ap\Views\Home\About.cshtml"
         Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n<span>praduc:");
#nullable restore
#line 7 "C:\Users\User\Desktop\New folder (5)\ap\ap\Views\Home\About.cshtml"
        Write(ViewBag.praduc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n<span>praduc:");
#nullable restore
#line 8 "C:\Users\User\Desktop\New folder (5)\ap\ap\Views\Home\About.cshtml"
        Write(ViewData["count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n<span>praduc type:");
#nullable restore
#line 9 "C:\Users\User\Desktop\New folder (5)\ap\ap\Views\Home\About.cshtml"
             Write(TempData["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
