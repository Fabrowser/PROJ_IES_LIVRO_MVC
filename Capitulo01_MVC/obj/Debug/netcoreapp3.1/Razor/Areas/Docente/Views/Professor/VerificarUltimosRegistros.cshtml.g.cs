#pragma checksum "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f71973a78b57ee0506e19642f0cd92075bda53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Docente_Views_Professor_VerificarUltimosRegistros), @"mvc.1.0.view", @"/Areas/Docente/Views/Professor/VerificarUltimosRegistros.cshtml")]
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
#line 1 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\_ViewImports.cshtml"
using Capitulo01_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\_ViewImports.cshtml"
using Capitulo01_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f71973a78b57ee0506e19642f0cd92075bda53", @"/Areas/Docente/Views/Professor/VerificarUltimosRegistros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f3cda03e09ee6507e0aba86fe9f2d94f82ba2b", @"/Areas/Docente/Views/_ViewImports.cshtml")]
    public class Areas_Docente_Views_Professor_VerificarUltimosRegistros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Modelo.Docente.CursoProfessor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarProfessor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE\thtml>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f71973a78b57ee0506e19642f0cd92075bda534197", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>VerificarUltimosRegistros</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f71973a78b57ee0506e19642f0cd92075bda535276", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
               Write(Html.DisplayNameFor(model => model.Curso));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
               Write(Html.DisplayNameFor(model => model.Professor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CursoID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProfessorID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\fabri\source\repos\Capitulo01_MVC\Capitulo01_MVC\Areas\Docente\Views\Professor\VerificarUltimosRegistros.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f71973a78b57ee0506e19642f0cd92075bda537860", async() => {
                    WriteLiteral("\r\n            Voltar\tpara\tAdicionar\r\n            Professor\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Modelo.Docente.CursoProfessor>> Html { get; private set; }
    }
}
#pragma warning restore 1591