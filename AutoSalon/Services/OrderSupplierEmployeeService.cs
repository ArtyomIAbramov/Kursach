using AutoSalon.DAL;
using AutoSalon.Interface;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public class OrderSupplierEmployeeService : IOrderSupplierEmployeeService
    {
        private DbAutoSalonContext db;
        public OrderSupplierEmployeeService(DbAutoSalonContext dbRepos)
        {
            db = dbRepos;
        }

        public void CreateOrder(OrderSupplierEmployee orderSupplierEmployee)
        {
            OrderSupplierEmployee order = new OrderSupplierEmployee();

            order.Id = orderSupplierEmployee.Id;
            order.Order_date = orderSupplierEmployee.Order_date;
            order.Order_price = orderSupplierEmployee.Order_price;
            order.Car = orderSupplierEmployee.Car;
            order.Employee = orderSupplierEmployee.Employee;
            order.Supplier = orderSupplierEmployee.Supplier;
            order.Contract_code = orderSupplierEmployee.Contract_code;

            db.OrdersSupplierEmployee.Add(order);
            db.SaveChanges();
        }

        public OrderSupplierEmployee GetOrder(int id)
        {
            return db.OrdersSupplierEmployee.Find(id);
        }

        public List<OrderSupplierEmployee> GetOrders()
        {
            return db.OrdersSupplierEmployee.ToList();
        }
    }
}
