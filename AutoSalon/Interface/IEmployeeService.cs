using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int Id);
        void CreateEmployee(Employee p);
        void UpdateEmployee(Employee p);
        void DeleteEmployee(int id);
    }
}
