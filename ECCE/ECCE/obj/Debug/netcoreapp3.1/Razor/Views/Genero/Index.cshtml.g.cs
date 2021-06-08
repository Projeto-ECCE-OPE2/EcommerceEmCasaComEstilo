#pragma checksum "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17092fd34a27e4818083621cd33520f156653731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genero_Index), @"mvc.1.0.view", @"/Views/Genero/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17092fd34a27e4818083621cd33520f156653731", @"/Views/Genero/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Genero_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_genero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
                ViewData["Title"] = "Gênero";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr />
<div class=""row"">
    <div class=""col-md-10""><h4 class=""font-weight-bold"">Lista de Gêneros</h4></div>
    <div class="" col-md-2"">
        <button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/genero/cadastrogenero'"">Novo Gênero</button>
    </div>
</div>
<hr />
<div>
");
#nullable restore
#line 15 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 32 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
   Write(item.CodigoGenero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 33 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
   Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td></td>\n    <td></td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 941, "\"", 1046, 5);
            WriteAttributeValue("", 951, "window.location.href=\'/genero/editar?CodigoGenero=", 951, 50, true);
#nullable restore
#line 36 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
WriteAttributeValue("", 1001, item.CodigoGenero, 1001, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1019, "&Descricao=", 1019, 11, true);
#nullable restore
#line 36 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
WriteAttributeValue("", 1030, item.Descricao, 1030, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1045, "\'", 1045, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\n");
            WriteLiteral("    \n</tr>                ");
#nullable restore
#line 39 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\n</table>\n");
#nullable restore
#line 42 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    Sem Registros!\n</div>\n");
#nullable restore
#line 48 "/home/jrcb/RiderProjects/EcommerceEmCasaComEstilo_VersaoFinal/ECCE/ECCE/Views/Genero/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_genero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
