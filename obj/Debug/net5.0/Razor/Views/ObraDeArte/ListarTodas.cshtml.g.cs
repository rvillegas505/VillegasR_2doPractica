#pragma checksum "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970d7db330b213154aec3b41451227b7d8c0a5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ObraDeArte_ListarTodas), @"mvc.1.0.view", @"/Views/ObraDeArte/ListarTodas.cshtml")]
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
#line 1 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\_ViewImports.cshtml"
using VillegasR_2doPractica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\_ViewImports.cshtml"
using VillegasR_2doPractica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970d7db330b213154aec3b41451227b7d8c0a5e3", @"/Views/ObraDeArte/ListarTodas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765b4dc7d4962d73fea5ed52788c9cb0c1bca88a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ObraDeArte_ListarTodas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ObraDeArte>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t<h1>Obras de Arte Siglo xix</h1>\r\n\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Nombre</th>\r\n\t\t\t<th>Anio</th>\r\n\t\t\t<th>Eliminar</th>\r\n\t\t\t\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 15 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml"
         foreach (var obra in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>");
#nullable restore
#line 18 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml"
           Write(obra.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 19 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml"
           Write(obra.AnioCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td> <a");
            BeginWriteAttribute("href", " href=\"", 314, "\"", 350, 2);
            WriteAttributeValue("", 321, "/ObraDeArte/Eliminar/", 321, 21, true);
#nullable restore
#line 20 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml"
WriteAttributeValue("", 342, obra.Id, 342, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a></td>\r\n\t\t\t<td> <a");
            BeginWriteAttribute("href", " href=\"", 381, "\"", 418, 2);
            WriteAttributeValue("", 388, "/ObraDeArte/Modificar/", 388, 22, true);
#nullable restore
#line 21 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml"
WriteAttributeValue("", 410, obra.Id, 410, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Modificar</a></td>\r\n\t\t</tr>\r\n");
#nullable restore
#line 23 "C:\pw3\Practicas segundo parcial\VillegasR-2doPractica\Views\ObraDeArte\ListarTodas.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t</tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ObraDeArte>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
