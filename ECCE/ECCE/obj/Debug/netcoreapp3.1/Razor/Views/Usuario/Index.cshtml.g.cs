#pragma checksum "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297a48d20d5bc13f47d298c0fc69b2cdca2b19ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297a48d20d5bc13f47d298c0fc69b2cdca2b19ee", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
                ViewData["Title"] = "Colaboradores";

                Layout = "_Layout_dashboard"; 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr />\n<h4 class=\"font-weight-bold\">Lista de Colaboradores</h4>\n<hr />\n<div>\n");
#nullable restore
#line 12 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
     if (Model.Count > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th></th>
            <th>Código</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Telefone</th>
            <th>CPF</th>
            <th>Editar</th>
            <th>Nova Senha</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td></td>\n    <td>");
#nullable restore
#line 33 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
   Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 34 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 35 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 36 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
   Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 37 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
   Write(item.CPF_CNPJ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 868, "\"", 965, 3);
            WriteAttributeValue("", 878, "window.location.href=\'/usuario/EditarSemSenhaColaborador?CodigoLogin=", 878, 69, true);
#nullable restore
#line 38 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
WriteAttributeValue("", 947, item.CodigoLogin, 947, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 964, "\'", 964, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1068, "\"", 1162, 3);
            WriteAttributeValue("", 1078, "window.location.href=\'/usuario/EditarSenhaColaborador?CodigoLogin=", 1078, 66, true);
#nullable restore
#line 39 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
WriteAttributeValue("", 1144, item.CodigoLogin, 1144, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1161, "\'", 1161, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-key\"></i></button></td>\n</tr>");
#nullable restore
#line 40 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table> ");
#nullable restore
#line 42 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    Sem Registros!\n</div>");
#nullable restore
#line 47 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Usuario/Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
