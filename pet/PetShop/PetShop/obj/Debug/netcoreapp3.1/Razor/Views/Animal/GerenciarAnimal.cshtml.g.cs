#pragma checksum "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eabc4fc47eca61996b53888963b9e70a9784843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_GerenciarAnimal), @"mvc.1.0.view", @"/Views/Animal/GerenciarAnimal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eabc4fc47eca61996b53888963b9e70a9784843", @"/Views/Animal/GerenciarAnimal.cshtml")]
    public class Views_Animal_GerenciarAnimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""form-group"">
            <label>Cliente Selecionado</label>
            <input class=""form-control"" id=""cliente"" readonly value=""Claudinha"" />
        </div>
        <div class=""form-group"">
            <label>Nome do Animal*</label>
            <input class=""form-control"" id=""animal"" />
        </div>
        <div class=""form-group"">
            <label>Tipo*</label>
            <select class=""form-control"" id=""tipo"">
                <option>Selecione</option>
            </select>
        </div>
    </div>
</div>
<button class=""btn btn-success"" onclick=""Check(5)"">Adicionar</button>
<hr />
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Ação</th>
                        <th>Animal</th>
                        <th>Tipo</th>
                    </tr>
                </th");
            WriteLiteral(@"ead>
                <tbody>
                    <tr>
                        <td>
                            <button class=""btn btn-warning btn-xs"">Alterar</button>
                        </td>
                        <td>
                            <input class=""form-control"" id=""animalconsulta"" value=""Bob"" />
                        </td>
                        <td>
                            <select class=""form-control"" id=""tipoconsulta"">
                                <option>Gato</option>
                            </select>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>
");
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