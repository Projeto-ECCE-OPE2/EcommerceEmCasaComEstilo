#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490636581fa3e0488607b49eb4ae79f48e366781"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490636581fa3e0488607b49eb4ae79f48e366781", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    ViewData["Title"] = "Produto";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th><h4>Usuários</h4></th>\r\n            <th></th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">

            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                       Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 915, "\"", 1016, 5);
            WriteAttributeValue("", 925, "window.location.href=\'/produto/editar?CodigoProduto=", 925, 52, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 977, item.CodigoLogin, 977, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 994, "&Descricao=", 994, 11, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1005, item.Nome, 1005, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1015, "\'", 1015, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1112, "\"", 1193, 3);
            WriteAttributeValue("", 1122, "window.location.href=\'/produto/excluir?CodigoProduto=", 1122, 53, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1175, item.CodigoLogin, 1175, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1192, "\'", 1192, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 44 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Sem Registros!\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
