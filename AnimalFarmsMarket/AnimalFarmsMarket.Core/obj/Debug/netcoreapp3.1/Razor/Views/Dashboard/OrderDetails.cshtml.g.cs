#pragma checksum "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f3aab974be32aa0deb4494b4a3317f576fc5a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_OrderDetails), @"mvc.1.0.view", @"/Views/Dashboard/OrderDetails.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f3aab974be32aa0deb4494b4a3317f576fc5a1", @"/Views/Dashboard/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9304427a528002223944c50435216bff61019445", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdersDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
  
    int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-sm-8 d-flex rounded mx-auto"" style=""background: #fff !important; margin-top: 4% !important; border: 1px solid #eee !important; margin-bottom: 40px; padding-bottom: 30px;"">
    <div class=""col-12"">
        <div class=""text-center my-4""><h1 style=""color: #2078BF"">Order Details</h1></div>
        <div class=""row mx-5"">
            <div class=""col-12"">
                <table class=""table table-borderless"">

                    <tbody>

                        <tr>
                            <td>Tracking number</td>
                            <td>");
#nullable restore
#line 21 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                           Write(Model.TrackingNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td>Payment Amount</td>\n                            <td>");
#nullable restore
#line 25 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                           Write(string.Format(new CultureInfo("ng-NG"), "{0:c}", Model.PaymentAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td>Payment Status</td>\n");
#nullable restore
#line 29 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                             if (Model.PaymentStatus == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Pending</td>\n");
#nullable restore
#line 32 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Successful</td>\n");
#nullable restore
#line 36 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tr>\n                        <tr>\n                            <td>Shipped To</td>\n                            <td>");
#nullable restore
#line 41 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                           Write(Model.ShippedTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td>Delivery Date</td>\n                            <td>");
#nullable restore
#line 45 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                           Write(Model.DeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n\n                    </tbody>\n                </table>\n\n                <div");
            BeginWriteAttribute("class", " class=\"", 1849, "\"", 1857, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h5 style=""color: #2078BF"">Ordered Items</h5></div>

                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">
                                #
                            </th>
                            <th scope=""col"">
                                Breed
                            </th>
                            <th scope=""col"">
                                Selling Price
                            </th>
                            <th scope=""col"">
                                Quantity
                            </th>

                            <th scope=""col"">
                                Total
                            </th>
                        </tr>
                    </thead>
");
#nullable restore
#line 74 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                     foreach (var item in Model.OrderItems)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\n\n                            <tr>\n\n                                <td>\n                                    ");
#nullable restore
#line 83 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                                Write(++counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 86 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                               Write(item.Livestock.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 89 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                               Write(string.Format(new CultureInfo("ng-NG"), "{0:c}", item.Livestock.SellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    \n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 93 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 96 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                               Write(string.Format(new CultureInfo("ng-NG"), "{0:c}", item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                            </tr>\n                        </tbody>\n");
#nullable restore
#line 100 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\n            </div>\n            \n\n        </div>\n");
#nullable restore
#line 106 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
         if(Model.Status == 0)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"row justify-content-center\">\n                <div class=\" text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f3aab974be32aa0deb4494b4a3317f576fc5a114266", async() => {
                WriteLiteral("\n                        <input type=\"text\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 4038, "\"", 4057, 1);
#nullable restore
#line 111 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
WriteAttributeValue("", 4046, ViewBag.Id, 4046, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden/>\n                        <button type=\"submit\" class=\"btn btn-success\">Confirm Order</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 116 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
         }
         else
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row justify-content-center\">\n                <div class=\" text-center\">\n                    <button type=\"submit\" class=\"btn btn-primary\" disabled>Order Confirmed</button>\n                </div>\n            </div>\n");
#nullable restore
#line 124 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\OrderDetails.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n    </div>\n\n\n\n\n</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService _authorization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdersDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
