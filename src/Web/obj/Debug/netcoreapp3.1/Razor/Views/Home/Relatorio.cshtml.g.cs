#pragma checksum "/home/matt/Documents/CaseTempus/src/Web/Views/Home/Relatorio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf8240f6b9f515c61ce61ba71fc15d36d852e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Relatorio), @"mvc.1.0.view", @"/Views/Home/Relatorio.cshtml")]
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
#line 1 "/home/matt/Documents/CaseTempus/src/Web/Views/_ViewImports.cshtml"
using CaseTempus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/matt/Documents/CaseTempus/src/Web/Views/_ViewImports.cshtml"
using CaseTempus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf8240f6b9f515c61ce61ba71fc15d36d852e9a", @"/Views/Home/Relatorio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e47da638ea206ca3df15f34c983799963da3286", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Relatorio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaseTempus.Models.Relatorio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4>Relatórios</h4>

<h4><small class=""text-muted"">Quantidade de clientes</small></h4>

<div class=""row"">
    <div class=""col col-md-3"">
        <div class=""card relatorio"">
            <div class=""card-header bg-primary text-white"">
                Renda Maior que Média
            </div>
            <div class=""card-body"">
                ");
#nullable restore
#line 14 "/home/matt/Documents/CaseTempus/src/Web/Views/Home/Relatorio.cshtml"
           Write(Model.RendaMaiorMedia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    
    <div class=""col col-md-3"">
        <div class=""card relatorio"">
            <div class=""card-header bg-success text-white"">
                Classe A
            </div>
            <div class=""card-body"">
                ");
#nullable restore
#line 25 "/home/matt/Documents/CaseTempus/src/Web/Views/Home/Relatorio.cshtml"
           Write(Model.ClasseA);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    
    <div class=""col col-md-3"">
        <div class=""card relatorio"">
            <div class=""card-header bg-warning text-white"">
                Classe B
            </div>
            <div class=""card-body"">
                ");
#nullable restore
#line 36 "/home/matt/Documents/CaseTempus/src/Web/Views/Home/Relatorio.cshtml"
           Write(Model.ClasseB);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    
    <div class=""col col-md-3"">
        <div class=""card relatorio"">
            <div class=""card-header bg-danger text-white"">
                Classe C
            </div>
            <div class=""card-body"">
                ");
#nullable restore
#line 47 "/home/matt/Documents/CaseTempus/src/Web/Views/Home/Relatorio.cshtml"
           Write(Model.ClasseC);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseTempus.Models.Relatorio> Html { get; private set; }
    }
}
#pragma warning restore 1591
