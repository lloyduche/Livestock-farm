#pragma checksum "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "891e77e04c53e8c92839bcfb9d573130f9f56738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_AssignmentPartialView), @"mvc.1.0.view", @"/Views/Dashboard/AssignmentPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891e77e04c53e8c92839bcfb9d573130f9f56738", @"/Views/Dashboard/AssignmentPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9304427a528002223944c50435216bff61019445", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_AssignmentPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResponseDto<PaginatedResultDto<AssignmentDeliveryViewModel>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
  int count = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
 if (Model!=null)
{
    if (Model.Data.PageMetaData.Page == 1)
    {
        count = 0;
    }
    else
    {
        count = (Model.Data.PageMetaData.Page-1) * Model.Data.PageMetaData.PerPage;
    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"d-flex justify-content-between\">\n\n    <div class=\"container shadow rounded col-12 p-4\" style=\"width\">\n        <table class=\"table table-borderless\">\n            <thead>\n                <tr");
            BeginWriteAttribute("class", " class=\"", 492, "\"", 500, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <th>S/N</th>\n                    <th>Order</th>\n");
#nullable restore
#line 26 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                     if ((await _authorization.AuthorizeAsync(User, "DeliveryRolePolicy")).Succeeded)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>Action</th>\n");
#nullable restore
#line 29 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>Status</th>\n");
#nullable restore
#line 33 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </tr>\n            </thead>\n");
#nullable restore
#line 37 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
             if (Model != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\n\n");
#nullable restore
#line 41 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                     foreach (var item in Model.Data.ResponseData)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=\"", 1126, "\"", 1134, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <td>");
#nullable restore
#line 45 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1214, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                                  Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n");
#nullable restore
#line 47 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                         if ((await _authorization.AuthorizeAsync(User, "DeliveryRolePolicy")).Succeeded)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <a id=\"acceptid\" data-delivery=\"");
#nullable restore
#line 50 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"acceptBtn(event)\" role=\"button\" class=\"btn btn-outline-success mr-1 \">\n                                    Accept\n\n                                </a>\n                            </td>\n");
#nullable restore
#line 55 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"

                        }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        <a id=\"acceptid\" role=\"button\" class=\"btn btn-outline-success mr-1 \">\n                            pending\n\n                        </a>\n                    </td>\n");
#nullable restore
#line 65 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </tr>\n");
#nullable restore
#line 68 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </tbody>\n");
#nullable restore
#line 73 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
              else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\n                    </tbody>\n");
#nullable restore
#line 78 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n");
#nullable restore
#line 82 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
         if (Model.Data.ResponseData.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"display:flex; justify-content:center;height:50px\">\n                <p style=\"margin:7px auto;font-weight:bold\">NO RECORD FOUND</p>\n            </div>\n");
#nullable restore
#line 87 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
#nullable restore
#line 90 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
 if (Model!=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12\">\n        <ul class=\"pagination mt-3\">\n");
#nullable restore
#line 94 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
             for (int i = 1; i <= Model.Data.PageMetaData.TotalPages; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <button class=\"page-link btn btn-sm\"");
            BeginWriteAttribute("id", " id=\"", 2736, "\"", 2743, 1);
#nullable restore
#line 97 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
WriteAttributeValue("", 2741, i, 2741, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"okayBtn(this)\">");
#nullable restore
#line 97 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n            </li>\n");
#nullable restore
#line 99 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n");
#nullable restore
#line 102 "C:\Users\hp\source\repos\livestock farm complete project\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\AssignmentPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResponseDto<PaginatedResultDto<AssignmentDeliveryViewModel>>> Html { get; private set; }
    }
}
#pragma warning restore 1591