#pragma checksum "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7237b9795104e6b0ada63828999369228dc7a7"
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
#line 1 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using LatihanBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using LatihanBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-4 mt-4");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.AddMarkupContent(5, "<hr>\n        ");
            __builder.OpenElement(6, "h3");
            __builder.OpenElement(7, "p");
            __builder.AddAttribute(8, "align", "center");
            __builder.AddAttribute(9, "style", "color: indigo;500");
            __builder.AddContent(10, 
#nullable restore
#line 4 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
                                                         Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        <hr>\n        ");
            __builder.OpenElement(12, "h3");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "align", "center");
            __builder.AddAttribute(15, "style", "color: indigo;500");
            __builder.AddContent(16, 
#nullable restore
#line 6 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
                                                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 6 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
                                                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "  \n        <div class=\"card-footer text-center\"></div>\n        <hr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    \n    ");
            __builder.OpenElement(21, "h3");
            __builder.AddMarkupContent(22, "<div class=\"card-footer text-center\"></div>\n        ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "rounded mx-auto d-block imageThumbnail");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 12 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
                                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    <hr>");
#nullable restore
#line 14 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
     if (ShowFooter)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-footer text-center");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 17 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
                       $"employeedetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "btn btn-outline-danger m-1");
            __builder.AddAttribute(32, "style", "color: danger;");
            __builder.AddMarkupContent(33, "<b>VIEW</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n            ");
            __builder.AddMarkupContent(35, "<a class=\"btn btn-outline-primary m-1\" style=\"color: primary;\"><b>EDIT</b></a>\n            ");
            __builder.AddMarkupContent(36, "<a class=\"btn btn-outline-warning m-1\" style=\"color: warning;\"><b>DELETE</b></a>");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\xampp\htdocs\PEMROGRAMANFRONTEND\test\Tugas 5\Employees\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
