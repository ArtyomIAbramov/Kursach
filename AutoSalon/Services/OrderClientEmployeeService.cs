using AutoSalon.DAL;
using AutoSalon.Interface;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoSalon.Services
{
    public class OrderClientEmployeeService : IOrderClientEmployeeService
    {
        private DbAutoSalonContext db;
        public OrderClientEmployeeService(DbAutoSalonContext dbRepos)
        {
            db = dbRepos;
        }

        public void CreateOrder(OrderClientEmployee orderClientEmployee)
        {
            db.OrdersClientEmployee.Add(orderClientEmployee);
            db.SaveChanges();
        }

        public OrderClientEmployee GetOrder(int id)
        {
            return db.OrdersClientEmployee.Find(id);
        }

        public List<OrderClientEmployee> GetOrders()
        {
            return db.OrdersClientEmployee.ToList();
        }
    }
}
