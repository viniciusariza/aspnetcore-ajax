#pragma checksum "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7f99b14b9ba7b1d36f13aeaadf48a9962c8161"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7f99b14b9ba7b1d36f13aeaadf48a9962c8161", @"/Views/Animal/GerenciarAnimal.cshtml")]
    public class Views_Animal_GerenciarAnimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ajax/animalajx.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <input type=\"hidden\" id=\"cod\"");
            BeginWriteAttribute("value", " value=\"", 145, "\"", 165, 1);
#nullable restore
#line 9 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 153, ViewBag.Cod, 153, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label>Cliente Selecionado</label>\r\n            <input class=\"form-control\" id=\"cliente\" readonly");
            BeginWriteAttribute("value", " value=\"", 314, "\"", 335, 1);
#nullable restore
#line 12 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 322, ViewBag.Nome, 322, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
        <div class=""form-group"">
            <label>Nome do Animal*</label>
            <input class=""form-control"" id=""animal"" />
        </div>
        <div class=""form-group"">
            <label>Tipo*</label>
            <select class=""form-control"" id=""tipo"">
                <option");
            BeginWriteAttribute("value", " value=\"", 651, "\"", 659, 0);
            EndWriteAttribute();
            WriteLiteral(@">Selecione</option>
                <option value=""1"">Cachorro</option>
                <option value=""2"">Gato</option>
            </select>
        </div>
    </div>
</div>
<button class=""btn btn-success"" onclick=""CadastrarAnimal()"">Adicionar</button>
<hr />
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">

            <table class=""table table-hover"" id=""tabelaAnimal"">
                <thead>
                    <tr>
                        <th>A????o</th>
                        <th>Animal</th>
                        <th>Tipo</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 43 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
                     foreach (var item in ViewBag.Animais)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 1517, "\"", 1540, 2);
            WriteAttributeValue("", 1522, "id_animal_", 1522, 10, true);
#nullable restore
#line 47 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 1532, item.Id, 1532, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1541, "\"", 1557, 1);
#nullable restore
#line 47 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 1549, item.Id, 1549, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <button class=\"btn btn-warning btn-xs\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1633, "\"", 1666, 3);
            WriteAttributeValue("", 1643, "AlterarAnimal(", 1643, 14, true);
#nullable restore
#line 48 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 1657, item.Id, 1657, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1665, ")", 1665, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Alterar</button>\r\n                            </td>\r\n                            <td>\r\n                                <input class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 1814, "\"", 1839, 2);
            WriteAttributeValue("", 1819, "nome_animal_", 1819, 12, true);
#nullable restore
#line 51 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 1831, item.Id, 1831, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1840, "\"", 1858, 1);
#nullable restore
#line 51 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 1848, item.Nome, 1848, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <select class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 1993, "\"", 2019, 2);
            WriteAttributeValue("", 1998, "tipo_alterar_", 1998, 13, true);
#nullable restore
#line 54 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
WriteAttributeValue("", 2011, item.Id, 2011, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <option value=\"1\" ");
#nullable restore
#line 55 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
                                                  Write(item.Tipo == 1 ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Cachorro</option>\r\n                                    <option value=\"2\" ");
#nullable restore
#line 56 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
                                                  Write(item.Tipo == 2 ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Gato</option>\r\n                                </select>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Animal\GerenciarAnimal.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d7f99b14b9ba7b1d36f13aeaadf48a9962c81619899", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
