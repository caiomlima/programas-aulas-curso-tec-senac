#pragma checksum "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61244fee322355e4d61964a2e2b9eeafac9106e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Procurar), @"mvc.1.0.view", @"/Views/Home/Procurar.cshtml")]
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
#line 1 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\_ViewImports.cshtml"
using Mvc_BO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\_ViewImports.cshtml"
using Mvc_BO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61244fee322355e4d61964a2e2b9eeafac9106e5", @"/Views/Home/Procurar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4da8e614531ff9dbad313682f184027eeb9324b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Procurar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc_BO.Models.Aluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
  
    ViewData["Title"] = "Detalhes do Aluno";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes do Aluno</h1>\r\n\r\n<div>\r\n    <h4>Aluno</h4>\r\n");
#nullable restore
#line 11 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
     if(Model == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd>Nenhuma informação foi encontrada com o critério informado</dd>\r\n");
#nullable restore
#line 13 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 16 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n");
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 1664, "\"", 1695, 1);
#nullable restore
#line 50 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
WriteAttributeValue("", 1670, Url.Content(@Model.Foto), 1670, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1696, "\"", 1714, 1);
#nullable restore
#line 50 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
WriteAttributeValue("", 1702, Model.Texto, 1702, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 53 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayNameFor(model => model.Texto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 56 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
           Write(Html.DisplayFor(model => model.Texto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
#nullable restore
#line 59 "C:\Users\caio.mlima5\Desktop\Aulas Senac\ASP.NET\# Database e Entity\Mvc_BO\Mvc_BO\Views\Home\Procurar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61244fee322355e4d61964a2e2b9eeafac9106e510307", async() => {
                WriteLiteral("Voltar à Listagem de Alunos");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc_BO.Models.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591