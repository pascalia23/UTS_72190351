using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor344.Models;
using Blazor344.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor344.Pages
{
    public partial class DepartmentPage
    {
        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
           Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}