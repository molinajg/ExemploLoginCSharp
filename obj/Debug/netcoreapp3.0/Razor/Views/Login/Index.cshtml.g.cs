#pragma checksum "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "466391da4dca3027c3bba8697541a20f07fa8232"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\_ViewImports.cshtml"
using ExemploLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\_ViewImports.cshtml"
using ExemploLogin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"466391da4dca3027c3bba8697541a20f07fa8232", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7177c0c34390e4553917870427dd1e33d1439c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/Autenticar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/Incluir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">

    <!-- Outer Row -->
    <div class=""row justify-content-center"">
        <div class=""text-center"">
            <br />
            <h2 class=""display-3"">
                Casa de Memória
                Edmundo Cardoso
            </h2>
        </div>
        <div class=""col-xl-5 col-lg-6 col-md-6"">
            <div class=""card o-hidden border-0 shadow-lg my-5"">
                <div class=""card-body p-0"">
                    <!-- Nested Row within Card Body -->
                    <div class=""row"">
                        <div class=""col-xl-12 col-lg-12 col-md-12"">
                            <div class=""p-5"">
                                <div class=""text-center"">
                                    <h1 class=""text-gray-900 mb-4"">Bem-Vindo!</h1>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "466391da4dca3027c3bba8697541a20f07fa82326528", async() => {
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 29 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                     if (@HttpContextAccessor.HttpContext.Session.GetString("notificacao") != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"row\">\r\n                                            <span class=\"alert alert-warning alert-dismissible\">\r\n                                                ");
#nullable restore
#line 34 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                           Write(HttpContextAccessor.HttpContext.Session.GetString("notificacao"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </span>\r\n                                        </div><br />\r\n");
#nullable restore
#line 37 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                     if (@ViewBag.notificacao != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"row\">\r\n                                            <span class=\"alert alert-warning alert-dismissible\">\r\n                                                ");
#nullable restore
#line 43 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                           Write(ViewBag.notificacao);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </span>\r\n                                        </div><br />\r\n");
#nullable restore
#line 46 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label>E-mail</label>
                                        <input name=""email"" type=""email"" class=""form-control form-control-user"" id=""exampleInputEmail"" aria-describedby=""emailHelp"" placeholder=""Informe o e-mail..."" autofocus required>
                                    </div>
                                    <div class=""form-group"">
                                        <label>Senha</label>
                                        <input name=""senha"" type=""password"" class=""form-control form-control-user"" id=""exampleInputPassword"" placeholder=""Informe a Senha..."" required>
                                    </div>
                                    </br>
                                    <button class=""btn btn-primary btn-user btn-block"" type=""submit"" value=""Index"">
                                        Entrar
                                    </button>
                          ");
                WriteLiteral("      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <br />\r\n                                <div class=\"text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "466391da4dca3027c3bba8697541a20f07fa823212047", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 64 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <button class=\"btn btn-primary btn-user btn-block\" type=\"submit\"><i class=\"fa fa-plus\"></i> Cadastrar novo usuário</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <hr>\r\n                                <div class=\"text-center\">\r\n                                    <a class=\"small\"");
            BeginWriteAttribute("href", " href=\"", 3943, "\"", 3985, 1);
#nullable restore
#line 70 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
WriteAttributeValue("", 3950, Url.Action("Recuperacao", "Login"), 3950, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Recuperar a senha?</a>\r\n                                </div>\r\n                                <div class=\"text-center\">\r\n                                    <a class=\"small\"");
            BeginWriteAttribute("href", " href=\"", 4162, "\"", 4197, 1);
#nullable restore
#line 73 "D:\PROJETOS_CSharp\ExemploLogin\ExemploLogin\Views\Login\Index.cshtml"
WriteAttributeValue("", 4169, Url.Action("Index", "Home"), 4169, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Voltar para Home</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
