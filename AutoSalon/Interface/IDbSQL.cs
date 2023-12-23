using AutoSalon.Interface;
using AutoSalon.Models;
using AutoSalon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Repos
{
    public interface IDbSQL
    {
        ICarService Cars { get; }
        IClientService Clients { get; }
        IEmployeeService Employees { get; }
        IOrderClientEmployeeService OrderClientEmployee { get; }
        IOrderSupplierEmployeeService OrderSupplierEmployee { get; }
        ISupplierService Suppliers { get; }

        int Save();
    }
}
