#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d60de5241005a9f27018fdf596f9f70436ccc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Endereco), @"mvc.1.0.view", @"/Views/Menu/Endereco.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d60de5241005a9f27018fdf596f9f70436ccc8", @"/Views/Menu/Endereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Endereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_endereco>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                ViewData["Title"] = "Endereços";

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-10\"><h4 class=\"font-weight-bold\">Lista de Endereços</h4></div>\r\n</div>\r\n<hr />\r\n<div class=\"card bg-white rounded\" style=\"margin-bottom:1em\">\r\n");
#nullable restore
#line 11 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-sm"" style=""margin-bottom: 0"">
        <thead class=""thead-dark"">
            <tr>
                <th>Descrição</th>
                <th>Cep</th>
                <th>Cidade</th>
                <th>Número</th>
                <th>Bairro</th>
                <th>UF</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                   Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                   Write(item.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                   Write(item.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                   Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                   Write(item.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
                   Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1140, "\"", 1219, 3);
            WriteAttributeValue("", 1150, "window.location.href=\'/menu/EditarEnd?CodigoEnd=", 1150, 48, true);
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
WriteAttributeValue("", 1198, item.CodigoEndereco, 1198, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1218, "\'", 1218, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\r\n");
            WriteLiteral("\r\n\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 43 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\r\n    Sem Registros!\r\n</div>\r\n");
#nullable restore
#line 49 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\Endereco.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n</div>\r\n<button type=\"button\" class=\"btn btn-info btn-sm\" onclick=\"window.location.href=\'../menu/Editassenha\'\">Voltar</button>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_endereco>> Html { get; private set; }
    }
}
#pragma warning restore 1591
