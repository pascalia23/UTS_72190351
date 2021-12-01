using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor344.Models;

namespace Blazor344.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetAll();
         Task<Employee> GetById(int id);
    }
}