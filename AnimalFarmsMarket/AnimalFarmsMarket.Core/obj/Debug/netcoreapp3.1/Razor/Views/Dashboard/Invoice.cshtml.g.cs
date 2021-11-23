#pragma checksum "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7119cb03cd726f864d07ea16208010e88b675d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Invoice), @"mvc.1.0.view", @"/Views/Dashboard/Invoice.cshtml")]
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
#nullable restore
#line 2 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
using AnimalFarmsMarket.Data.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7119cb03cd726f864d07ea16208010e88b675d5", @"/Views/Dashboard/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9304427a528002223944c50435216bff61019445", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedInvoiceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
  
    if(ViewBag.isDashboard == null){
            ViewBag.isDashboard = false;
        }

    var gender = Enum.GetNames(typeof(Gender));
    var paymentStatus = Enum.GetNames(typeof(PaymentStatus));
    var dataCount = Model.ResponseData.Count();


#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"margin:50px auto 20px auto; width:80%;\">\n    <h3 style=\"color:#2078BF;font-weight:bold\">INVOICE</h3>\n</div>\n\n\n\n");
#nullable restore
#line 21 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
 if (dataCount < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"display:flex; justify-content:center;height:50px\">\n        <p style=\"margin-left: 50px;\n        margin-bottom: 7px;\n        font-weight:bold; color:#2078BF;\">NO INVOICE RECORD</p>\n    </div>\n");
#nullable restore
#line 28 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 30 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
 if (dataCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 705, "\"", 713, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 80%;
        background-color: whitesmoke;
        box-shadow: rgba(32, 120, 191, 0.35) 0px 5px 15px;
        margin:50px auto 20px auto;"">
        <div class=""accordion"" id=""accordionFlushExample"">

            <div style=""display:flex; align-items:center;height:50px"">
                <p style=""margin-left:50px;margin-bottom:7px;font-weight:bold"">ORDER DETAILS</p>
            </div>

");
#nullable restore
#line 42 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
             foreach (var order in @Model.ResponseData)
            {
                var status = "";
                var statusColor = "";
                if(order.PaymentStatus == 0)
                {
                    status = "Pending";
                    statusColor = "badge-warning";
                }
                else
                {
                    status = "Paid";
                    statusColor = "badge-success";

                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div asp-controller=\"Dashboard\"");
            BeginWriteAttribute("asp-action", " asp-action=\"", 1624, "\"", 1637, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"invoiceForm\">\n\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1682, "\"", 1690, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""border-radius:0"">
                        <div class=""heading"" id=""header"">
                            <h2 class=""mb-0"" id=""flush-headingTwo"">
                                <button class=""d-flex btn btn-link btn-block text-left collapsed pl-5"" style=""box-shadow: none; border-color: rgba(0,0,0,.125);font-weight:lighter;text-decoration:none;border-radius:0"" type=""button"" data-toggle=""collapse"" data-target=""#flush-collapseTwo_");
#nullable restore
#line 63 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                                                                                                                                                                                                                                         Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"flush-collapseTwo\">\n                                    ID-");
#nullable restore
#line 64 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                  Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-angle-right\" style=\"width:100px;color:grey;margin-left:auto\"></i>\n                                </button>\n                            </h2>\n                        </div>\n\n                        <div");
            BeginWriteAttribute("id", " id=\"", 2463, "\"", 2495, 2);
            WriteAttributeValue("", 2468, "flush-collapseTwo_", 2468, 18, true);
#nullable restore
#line 69 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
WriteAttributeValue("", 2486, order.Id, 2486, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"flush-headingTwo\" data-parent=\"#accordionFlushExample\">\n                            <div");
            BeginWriteAttribute("class", " class=\"", 2619, "\"", 2627, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""margin:20px 30px 20px 30px;"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"">
                                        <thead>
                                            <tr style=""border-radius:0"">
                                                <th scope=""col"" style=""font-weight:bolder"">Type</th>
                                                <th scope=""col"" style=""font-weight:bolder"">Sex</th>
                                                <th scope=""col"" style=""font-weight:bolder"">Date</th>
                                                <th scope=""col"" style=""font-weight:bolder"">Quantity</th>
                                                <th scope=""col"" style=""font-weight:bolder"">Weight</th>
                                                <th scope=""col"" style=""font-weight:bolder"">Product Amount</th>
                                                <th scope=""col"" style=""font-weight:bolder"">Delivery Amount</");
            WriteLiteral("th>\n                                                <th scope=\"col\" style=\"font-weight:bolder\">Total Amount</th>\n                                            </tr>\n                                        </thead>\n");
#nullable restore
#line 85 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                         foreach (var orderitem in order.OrderItems)
                                        {
                                            var totalamount = @orderitem.Total + order.ShippingPlan.DeliveryCost;
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tbody>\n                                                <tr style=\"border-radius:0\">\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 90 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(orderitem.Livestock.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 91 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(gender[@orderitem.Livestock.Sex]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 92 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(orderitem.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 93 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(orderitem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 94 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(orderitem.Livestock.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 95 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(orderitem.Livestock.SellingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 96 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(order.ShippingPlan.DeliveryCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td style=\"font-weight:normal\">");
#nullable restore
#line 97 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                              Write(totalamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                </tr>\n                                            </tbody>\n");
#nullable restore
#line 100 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </table>
                                </div>
                                <div>
                                    <div class=""ml-1 pb-2"" style=""display:flex"">
                                        <h6>Payment Status : </h6>
                                        
                                        <span");
            BeginWriteAttribute("class", " class=\"", 5656, "\"", 5697, 5);
            WriteAttributeValue("", 5664, "ml-1", 5664, 4, true);
            WriteAttributeValue(" ", 5668, "mt-0", 5669, 5, true);
            WriteAttributeValue(" ", 5673, "mb-1", 5674, 5, true);
            WriteAttributeValue(" ", 5678, "badge", 5679, 6, true);
#nullable restore
#line 108 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
WriteAttributeValue(" ", 5684, statusColor, 5685, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-style:italic;\">");
#nullable restore
#line 108 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                                                              Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                  
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                    </div>


                </div>
");
#nullable restore
#line 119 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n    </div>\n");
#nullable restore
#line 125 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
#nullable restore
#line 132 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
 if (dataCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex flex-wrap flex-sm-wrap col-lg-12 col-sm-12 justify-content-center\" style=\"margin-top:2.5em; margin-bottom:2em\">\n        <nav class=\"pagination-outer\" aria-label=\"Page navigation\">\n            <ul class=\"pagination\">\n\n");
#nullable restore
#line 138 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                 for (int i = 1; i <= Model.PageMetaData.TotalPages; i++)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 6462, "\"", 6470, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <button class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6522, "\"", 6529, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"current\"");
            BeginWriteAttribute("id", " id=\"", 6551, "\"", 6558, 1);
#nullable restore
#line 142 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
WriteAttributeValue("", 6556, i, 6556, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"GoToPage(this)\">");
#nullable restore
#line 142 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                    </li>\n");
#nullable restore
#line 144 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </ul>\n        </nav>\n    </div>\n");
#nullable restore
#line 150 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Invoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedInvoiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
