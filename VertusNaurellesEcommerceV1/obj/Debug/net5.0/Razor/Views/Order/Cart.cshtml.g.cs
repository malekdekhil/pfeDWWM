#pragma checksum "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97de3e4111990e82c0cf21b1c3c7547330327a28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
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
#line 1 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using VertusNaurellesEcommerceV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using VertusNaurellesEcommerceV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using VertusNaurellesEcommerceV1.Models.ViewsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\_ViewImports.cshtml"
using Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97de3e4111990e82c0cf21b1c3c7547330327a28", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d0e1028a53006edc81640dc389ad2ab5be467b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-danger alert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Stripe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
   
    var totalPrice = ViewBag.TotalAllItems * 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section style=\"margin-top:150px;\" id=\"sectionBasket\" >\r\n    <p class=\"linkHistory\"><a class=\"nav-link LinkH\" href=\"/Order/History\" >Historique</a></p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97de3e4111990e82c0cf21b1c3c7547330327a286175", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
         if (Model != null)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\" container col-lg-8\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                     foreach (var item in Model.ListProducts)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr class=\"trBasket \">\r\n                            <td hidden name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 685, "\"", 708, 1);
#nullable restore
#line 24 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 693, item.ProductId, 693, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                            <td class=\"tdBasket\" name=\"ProductName\"");
                BeginWriteAttribute("value", " value=\"", 814, "\"", 839, 1);
#nullable restore
#line 26 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 822, item.ProductName, 822, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 27 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </td>\r\n");
                WriteLiteral("                          \r\n                            <td  class=\"tdBasket\" name=\"ProductQuantity\"");
                BeginWriteAttribute("value", " value=\"", 1222, "\"", 1251, 1);
#nullable restore
#line 35 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1230, item.ProductQuantity, 1230, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                Quantité ");
#nullable restore
#line 36 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                    Write(item.ProductQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                           \r\n                            <td class=\"tdBasket\" name=\"ProductPrice\"");
                BeginWriteAttribute("value", " value=\"", 1451, "\"", 1477, 1);
#nullable restore
#line 39 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1459, item.ProductPrice, 1459, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                Prix unitaire ");
#nullable restore
#line 40 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                         Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                          \r\n                            <td  class=\"tdBasket\" name=\"Total\"");
                BeginWriteAttribute("value", " value=\"", 1672, "\"", 1691, 1);
#nullable restore
#line 43 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1680, item.Total, 1680, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                Total  ");
#nullable restore
#line 44 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                  Write(item.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <input hidden");
                BeginWriteAttribute("value", " value=\"", 1792, "\"", 1811, 1);
#nullable restore
#line 45 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1800, item.Total, 1800, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td  class=\"tdBasket\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97de3e4111990e82c0cf21b1c3c7547330327a2811390", async() => {
                    WriteLiteral("x");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                                                                                              WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"


                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td class=\"col-4\"");
                BeginWriteAttribute("value", " value=\"", 2210, "\"", 2238, 1);
#nullable restore
#line 55 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
WriteAttributeValue("", 2218, Model.TotalAllItems, 2218, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            Total de la commande: ");
#nullable restore
#line 56 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                             Write(Model.TotalAllItems);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>euro</span>\r\n\r\n");
#nullable restore
#line 58 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                             if (Model.TotalAllItems.Equals(0))
                            {

                            }

                            else
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <script src=\"//checkout.stripe.com/v2/checkout.js\" class=\"stripe-button\" data-key=\"");
#nullable restore
#line 66 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                                                                                              Write(Stripe.Value.PublicKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-amount=\"");
#nullable restore
#line 66 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
                                                                                                                                                    Write(totalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-description=\"paiement\">\r\n\r\n                                </script>\r\n");
#nullable restore
#line 69 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n\r\n            </table>\r\n");
#nullable restore
#line 77 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
         if(Model == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"basketEmpty\">\r\n                 <p> Votre panier est vide</p>\r\n            </div>\r\n");
#nullable restore
#line 83 "C:\Users\malek\Desktop\PfeDWWM\VertusNaurellesEcommerceV1\Views\Order\Cart.cshtml"
           
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
