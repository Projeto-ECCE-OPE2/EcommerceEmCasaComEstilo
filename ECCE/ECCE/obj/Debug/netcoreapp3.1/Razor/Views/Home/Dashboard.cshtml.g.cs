#pragma checksum "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421af27fa017229965fea7be948060debc12776f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421af27fa017229965fea7be948060debc12776f", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TodosPedidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
                ViewData["Title"] = "Genero";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\n<h4 class=\"font-weight-bold\">Lista de Vendas</h4>\n<hr />\n<div>\n\n");
#nullable restore
#line 11 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>Venda</th>
            <th>Cliente</th>
            <th>Valor</th>
            <th>Data</th>
            <th>Status</th>
            <th>Editar Status</th>
            <th>Ver Itens</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 29 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
   Write(item.CodigoVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 31 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
   Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 32 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
   Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 33 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 831, "\"", 908, 3);
            WriteAttributeValue("", 841, "window.location.href=\'/pedido/Editar?CodigoVenda=", 841, 49, true);
#nullable restore
#line 34 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 890, item.CodigoVenda, 890, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 907, "\'", 907, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit \"></i></button></td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1012, "\"", 1091, 3);
            WriteAttributeValue("", 1022, "window.location.href=\'/pedido/VerItens?CodigoVenda=", 1022, 51, true);
#nullable restore
#line 35 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1073, item.CodigoVenda, 1073, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1090, "\'", 1090, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></button></td>\n</tr>\n");
#nullable restore
#line 37 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table> ");
#nullable restore
#line 39 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
         }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    Sem Registros!\n</div>");
#nullable restore
#line 44 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Dashboard.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TodosPedidos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
