#pragma checksum "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70132068584c31e8a2c7bc2b9b61035cf3c2126a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard__AgentOrderPartialView), @"mvc.1.0.view", @"/Views/Dashboard/_AgentOrderPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70132068584c31e8a2c7bc2b9b61035cf3c2126a", @"/Views/Dashboard/_AgentOrderPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9304427a528002223944c50435216bff61019445", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard__AgentOrderPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedResultDto<ShapedListOfOrderItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
  
    if (ViewBag.isDashboard == null)
    {
        ViewBag.isDashboard = false;
    }
    bool isDashboard = ViewBag.isDashboard;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"mb-5\">\n    <div");
            BeginWriteAttribute("class", " class=\"", 213, "\"", 221, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""mt-5"">
            <h2 class=""brand pl-0"" style=""color:#2078BF;"">Orders</h2>
        </div>

        <div class=""d-flex justify-content-center mt-4"">
            <div class=""bg-white col-sm-12 text-center p-4 table-responsive-sm"" id=""table-container"">
                <table class=""table table-borderless"">
");
#nullable restore
#line 20 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                     if (Model.ResponseData.Count() < 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"brand pl-0\" style=\"color:#2078BF; \">No Order Record</h2>\n");
#nullable restore
#line 23 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                    }
                    else
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <thead>
                            <tr>
                                <th id=""product-detail"">Product Details</th>
                                <th>DeliveryStatus</th>
                                <th>Amount</th>
                                <th>payment Status</th>
                            </tr>
                        </thead>
");
            WriteLiteral("                        <tbody id=\"table-body\">\n");
#nullable restore
#line 38 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                             if (Model != null)
                            {
                                var count = 0;
                                foreach (var item in Model.ResponseData)
                                {
                                    if (isDashboard && count >= 5)
                                    {
                                        break;
                                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td id=\"product-detail\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70132068584c31e8a2c7bc2b9b61035cf3c2126a8611", async() => {
                WriteLiteral("\n                                                <div id=\"product-detail-text\" class=\"text-left\">\n                                                    <h6 class=\"mb-0\"><small>");
#nullable restore
#line 52 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></h6>\n                                                    <h6 class=\"mt-0\"><small>");
#nullable restore
#line 53 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                       Write(item.DateCreated);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></h6>\n                                                </div>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </td>\n\n");
            WriteLiteral("\n");
#nullable restore
#line 60 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                         if (item.Status == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-warning\">Pending</i></td>\n");
#nullable restore
#line 63 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-success\">Delivered</i></td>\n");
#nullable restore
#line 67 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    <td>");
#nullable restore
#line 69 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                   Write(string.Format(new CultureInfo("ng-NG"), "{0:c}", item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n");
            WriteLiteral("\n");
#nullable restore
#line 74 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                         if (item.AgentPaid == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-warning\">Pending</i></td>\n");
#nullable restore
#line 77 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><i class=\"badge badge-pill badge-success\">Payment Received</i></td>\n");
#nullable restore
#line 81 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </tr>\n");
#nullable restore
#line 84 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"

                                    count++;
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tbody>\n");
#nullable restore
#line 90 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\n            </div>\n        </div>\n\n\n\n");
#nullable restore
#line 97 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
         if (Model != null && !isDashboard)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12\">\n                <ul class=\"pagination mt-3\">\n");
#nullable restore
#line 102 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                     for (int i = 1; i <= Model.PageMetaData.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\n                            <button class=\"page-link btn btn-sm\"");
            BeginWriteAttribute("id", " id=\"", 4429, "\"", 4436, 1);
#nullable restore
#line 105 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
WriteAttributeValue("", 4434, i, 4434, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"OrderBtn(this)\">");
#nullable restore
#line 105 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                        </li>\n");
#nullable restore
#line 107 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </div>\n");
#nullable restore
#line 111 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\_AgentOrderPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedResultDto<ShapedListOfOrderItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591