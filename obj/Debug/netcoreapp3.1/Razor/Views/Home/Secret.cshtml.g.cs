#pragma checksum "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8307fca8a73c26718636860b0fec40fe50d5a8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secret), @"mvc.1.0.view", @"/Views/Home/Secret.cshtml")]
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
#line 1 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
using AspNetCoreIdentity.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8307fca8a73c26718636860b0fec40fe50d5a8a7", @"/Views/Home/Secret.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b55bec701bb5c4324487dfe3a90e1f98fbf801d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secret : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
  
    ViewData["Title"] = "Segredo!";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Segredo!</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
  
    if (this.IfClaim("Produtos", "Adicionar"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Você só verá isso se tiver permissão de adicionar!</p>\r\n");
#nullable restore
#line 14 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 18 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
Write(Html.ActionLink("Secret", "Secret").IfClaimShow(Context, "Produtos", "Adicionar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <br/>\r\n    <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 410, "\"", 485, 3);
            WriteAttributeValue("", 418, "btn", 418, 3, true);
            WriteAttributeValue(" ", 421, "btn-danger", 422, 11, true);
#nullable restore
#line 23 "C:\Users\paulo\Documents\Developer\Projetos\C#\EntendendoMVC\AspNetCoreIdentity\Views\Home\Secret.cshtml"
WriteAttributeValue(" ", 432, Html.Raw(this.IfClaimShow("Produtos", "Adicionar")), 433, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n</div>");
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
