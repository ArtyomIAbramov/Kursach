using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Interface
{
    public interface IOrderSupplierEmployeeService
    {
        void CreateOrder(OrderSupplierEmployee orderSupplierEmployee);
        OrderSupplierEmployee GetOrder(int id);
        List<OrderSupplierEmployee> GetOrders();
    }
}
