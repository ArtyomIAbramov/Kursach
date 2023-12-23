using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Interface
{
    public interface IOrderClientEmployeeService
    {
        void CreateOrder(OrderClientEmployee orderClientEmployee);
        OrderClientEmployee GetOrder(int id);
        List<OrderClientEmployee> GetOrders();
    }
}
