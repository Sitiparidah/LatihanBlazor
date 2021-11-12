#pragma checksum "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281cca8f7d7455285c4f5ccc1746c510920cf37e"
// <auto-generated/>
#pragma warning disable 1591
namespace LatihanBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using LatihanBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using LatihanBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\xampp\htdocs\UTS\Employees\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b><p align=\"center\" style=\"color: indigo;500\">EMPLOYEES LIST </p></b></h3>");
#nullable restore
#line 5 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner\"></div>");
#nullable restore
#line 8 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
#nullable restore
#line 13 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
         foreach (var emp in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LatihanBlazor.Pages.DisplayEmployee>(4);
            __builder.AddAttribute(5, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EmployeeManagement.Models.Employee>(
#nullable restore
#line 15 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
                                       emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
                                                        ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 15 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
                                                                                         EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 18 "C:\xampp\htdocs\UTS\Employees\Pages\EmployeePage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591