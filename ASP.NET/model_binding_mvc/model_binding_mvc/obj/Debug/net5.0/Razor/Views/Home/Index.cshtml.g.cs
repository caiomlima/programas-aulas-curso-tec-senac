#pragma checksum "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ace71e0ce7a09f500b41cb67bec037c64a6d8e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\_ViewImports.cshtml"
using model_binding_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\_ViewImports.cshtml"
using model_binding_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ace71e0ce7a09f500b41cb67bec037c64a6d8e3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8088ee37ffea20c65da269fff1eb0059a06e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"text-center\">Usando Partial Views</h1>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Home\Index.cshtml"
Write(Html.Partial("_AlertaView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Home\Index.cshtml"
Write(Html.Partial("_MenuView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr>\r\n\r\nASP.NET CORE\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\model_binding_mvc\model_binding_mvc\Views\Home\Index.cshtml"
  
    Html.RenderPartial("_RodapeView");

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
