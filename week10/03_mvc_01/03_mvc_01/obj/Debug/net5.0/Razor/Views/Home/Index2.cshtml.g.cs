#pragma checksum "C:\Users\Web ve Mobil Prog\source\repos\MahirAksin\week10\03_mvc_01\03_mvc_01\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda211230bcda806a791eebd4187f429161514bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda211230bcda806a791eebd4187f429161514bb", @"/Views/Home/Index2.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Web ve Mobil Prog\source\repos\MahirAksin\week10\03_mvc_01\03_mvc_01\Views\Home\Index2.cshtml"
  

    string adSoyad = "Mahir";

    for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li style=\"color:yellow\">");
#nullable restore
#line 9 "C:\Users\Web ve Mobil Prog\source\repos\MahirAksin\week10\03_mvc_01\03_mvc_01\Views\Home\Index2.cshtml"
                            Write(adSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <div></div>\r\n");
#nullable restore
#line 11 "C:\Users\Web ve Mobil Prog\source\repos\MahirAksin\week10\03_mvc_01\03_mvc_01\Views\Home\Index2.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
