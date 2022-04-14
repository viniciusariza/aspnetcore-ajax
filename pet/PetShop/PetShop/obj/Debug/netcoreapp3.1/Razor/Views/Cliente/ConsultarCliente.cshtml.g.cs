#pragma checksum "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb2a9b26ad7dc0ca2f547f2032b52dfb19811dd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_ConsultarCliente), @"mvc.1.0.view", @"/Views/Cliente/ConsultarCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2a9b26ad7dc0ca2f547f2032b52dfb19811dd9", @"/Views/Cliente/ConsultarCliente.cshtml")]
    public class Views_Cliente_ConsultarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ajax/clienteajx.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""form-group"">
            <input class=""form-control"" type=""text"" placeholder=""Digite aqui para pesquisar o cliente..."" id=""filtro"" onkeyup=""FiltrarCliente()""/>
        </div>
        <div class=""card"">
            <table class=""table table-hover"" id=""tabelaCliente"">
                <thead>
                    <tr>
                        <th>Ação</th>
                        <th>Cliente</th>
                        <th>Telefone</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 22 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
                     foreach (var item in ViewBag.ListarClientes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 838, "\"", 887, 2);
            WriteAttributeValue("", 845, "/Cliente/AlterarCliente?id=", 845, 27, true);
#nullable restore
#line 26 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
WriteAttributeValue("", 872, item.IdCliente, 872, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-xs\">Alterar</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 1032, 4);
            WriteAttributeValue("", 974, "/Animal/GerenciarAnimal?id=", 974, 27, true);
#nullable restore
#line 27 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
WriteAttributeValue("", 1001, item.IdCliente, 1001, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1016, "&nome=", 1016, 6, true);
#nullable restore
#line 27 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
WriteAttributeValue("", 1022, item.Nome, 1022, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-xs\">Gerenciar Animal</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1190, 4);
            WriteAttributeValue("", 1128, "/Atendimento/NovoAtendimento?idNome=", 1128, 36, true);
#nullable restore
#line 28 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
WriteAttributeValue("", 1164, item.IdCliente, 1164, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1179, "-", 1179, 1, true);
#nullable restore
#line 28 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
WriteAttributeValue("", 1180, item.Nome, 1180, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-xs\">Atendimento</a>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 30 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
                           Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 33 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Cliente\ConsultarCliente.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb2a9b26ad7dc0ca2f547f2032b52dfb19811dd97497", async() => {
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
