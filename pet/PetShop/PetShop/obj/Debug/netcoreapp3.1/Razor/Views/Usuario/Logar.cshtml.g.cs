#pragma checksum "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Usuario\Logar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af5c9adf25d4b099d643536a102579ec396b50c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Logar), @"mvc.1.0.view", @"/Views/Usuario/Logar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af5c9adf25d4b099d643536a102579ec396b50c", @"/Views/Usuario/Logar.cshtml")]
    public class Views_Usuario_Logar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
#nullable restore
#line 3 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Usuario\Logar.cshtml"
Write(await Html.PartialAsync("_head"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8af5c9adf25d4b099d643536a102579ec396b50c3190", async() => {
                WriteLiteral(@"
    <div class=""login-box"">
        <div class=""login-logo"">
            <a href=""#""><b>Sistema</b>Login</a>
        </div>
        <!-- /.login-logo -->
        <div class=""card"">
            <div class=""card-body login-card-body"">
                <p class=""login-box-msg"">Acesse o Sistema</p>

                <form action=""/Usuario/ValidarAcesso"" method=""post"">
                    <div class=""input-group mb-3"">
                        <input type=""email"" class=""form-control"" placeholder=""Email"" name=""email"">
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <span class=""fas fa-envelope""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""input-group mb-3"">
                        <input type=""password"" class=""form-control"" placeholder=""Senha"" name=""senha"">
                        <div class=""input-group-append""");
                WriteLiteral(@">
                            <div class=""input-group-text"">
                                <span class=""fas fa-lock""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <!-- /.col -->
                        <div class=""col-12"">
                            <button type=""submit"" class=""btn btn-primary btn-block"">Acessar</button>
                        </div>
                        <!-- /.col -->
                    </div>
                </form>
            </div>
            <!-- /.login-card-body -->
        </div>
    </div>
    ");
#nullable restore
#line 43 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Usuario\Logar.cshtml"
Write(await Html.PartialAsync("_scripts"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 45 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Usuario\Logar.cshtml"
     if(ViewBag.Ret != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            toastr.warning(RetornaMsg(");
#nullable restore
#line 47 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Usuario\Logar.cshtml"
                                 Write(ViewBag.Ret);

#line default
#line hidden
#nullable disable
                WriteLiteral("));\r\n        </script>\r\n");
#nullable restore
#line 49 "D:\Cursos\Asp Net Core\aspnetcore-wm\pet\PetShop\PetShop\Views\Usuario\Logar.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
