#pragma checksum "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb60e79f0be06145485ad0a6d4bbec09322f46e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
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
#line 1 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using VertusNaurellesEcommerceV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using VertusNaurellesEcommerceV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using VertusNaurellesEcommerceV1.Models.ViewsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using Domains;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb60e79f0be06145485ad0a6d4bbec09322f46e", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d0e1028a53006edc81640dc389ad2ab5be467b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domains.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CardProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
  
    ViewData["Title"] = "Serach";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"sectionSearch\">\r\n\r\n\r\n");
#nullable restore
#line 9 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
         if (Model.Count() <= 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"SearchEmpty\">Nous navons pas trouver de resultat</p>\r\n");
#nullable restore
#line 14 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"containerCard\">\r\n\r\n");
#nullable restore
#line 17 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
             foreach (var item in Model.Where(x => x.Quantity >= 1))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eb60e79f0be06145485ad0a6d4bbec09322f46e5169", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 23 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <p>tettttttttttttttttttttttttt </p>
        <p>tettttttttttttttttttttttttt </p>
        <p>tettttttttttttttttttttttttt </p>
        <p>tettttttttttttttttttttttttt </p>
        <p>tettttttttttttttttttttttttt </p>
        <p>tettttttttttttttttttttttttt </p>
");
#nullable restore
#line 32 "E:\ProjetsPfe\DWWM\PfeDWWM\VertusNaurellesEcommerceV1\Views\Product\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // AddCart---------------------------------------------------
        function AddCart(id) {

            var xhr = new XMLHttpRequest();
            let link = '/Product/AddToCart/' + id;

            xhr.open(""Post"", link, true);
            xhr.send();

        }



    </script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domains.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
