using EmployeeManagement.Models;
using LatihanBlazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanBlazor.Pages
{
    public partial class EmployeeDetails
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected string Coordinates { get; set; }
        
        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX}  Y = {e.ClientY}";
        }

        protected string ButtonText  { get; set; } = "HIDE F00TER";
        protected string CssClass { get; set; } = null;

        protected void Button_Click()
        {
            if (ButtonText == "HIDE F00TER")
            {
                ButtonText = "SH0W F00TER";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "HIDE F00TER";
            }
        }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
    }
}
