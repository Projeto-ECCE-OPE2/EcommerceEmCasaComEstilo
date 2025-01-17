#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1ca8377e53430da11fc2b3950e06722fb49681b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_MeusPedidos), @"mvc.1.0.view", @"/Views/Menu/MeusPedidos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ca8377e53430da11fc2b3950e06722fb49681b", @"/Views/Menu/MeusPedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_MeusPedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TodosPedidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                ViewData["Title"] = "Meus Pedidos";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        flex-direction: column;
        text-align: center;
        border: none;
        background: #dcdcdc;
    }
    #tabelasempedido {
  
    }
    </style>
<hr />
<h4 class=""font-weight-bold"">Minhas Compras</h4>
<hr />
<div>

");
#nullable restore
#line 22 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card bg-white rounded"">
        <table class=""table table-striped table-sm"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Número da Compra </th>
                    <th>Valor</th>
                    <th>Data</th>
                    <th>Status</th>
                    <th>Ver Itens</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                       Write(item.CodigoVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                       Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                       Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1203, "\"", 1281, 3);
            WriteAttributeValue("", 1213, "window.location.href=\'/pedido/VerIten?CodigoVenda=", 1213, 50, true);
#nullable restore
#line 43 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
WriteAttributeValue("", 1263, item.CodigoVenda, 1263, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1280, "\'", 1280, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div> ");
#nullable restore
#line 48 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
           }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"icon\"><span style=\"font-size: 38px\">:(</span></div>\r\n    <h3>Você ainda não fez nenhuma compra. Essa é sua hora! </h3>\r\n</div>");
#nullable restore
#line 55 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TodosPedidos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
