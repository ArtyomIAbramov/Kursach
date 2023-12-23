using AutoSalon.Interface;
using AutoSalon.Models;
using AutoSalon.Repos;
using AutoSalon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.DAL
{
    public class DbSQL : IDbSQL
    {
        private DbAutoSalonContext db;
        private EmployeeService employeeServ;
        private CarService carServ;
        private ClientService clientServ;
        private OrderClientEmployeeService orderClientEmployeeServ;
        private OrderSupplierEmployeeService orderSupplierEmployeeServ;
        private SupplierService supplierServ;

        public DbSQL()
        {
            db = new DbAutoSalonContext();
        }

        public IEmployeeService Employees
        {
            get
            {
                if (employeeServ == null)
                    employeeServ = new EmployeeService(db);
                return employeeServ;
            }
        }

        public ICarService Cars
        {
            get
            {
                if (carServ == null)
                    carServ = new CarService(db);
                return carServ;
            }
        }

        public IClientService Clients
        {
            get
            {
                if (clientServ == null)
                    clientServ = new ClientService(db);
                return clientServ;
            }
        }

        public IOrderClientEmployeeService OrderClientEmployee
        {
            get
            {
                if (orderClientEmployeeServ == null)
                    orderClientEmployeeServ = new OrderClientEmployeeService(db);
                return orderClientEmployeeServ;
            }
        }

        public IOrderSupplierEmployeeService OrderSupplierEmployee
        {
            get
            {
                if (orderSupplierEmployeeServ == null)
                    orderSupplierEmployeeServ = new OrderSupplierEmployeeService(db);
                return orderSupplierEmployeeServ;
            }
        }

        public ISupplierService Suppliers
        {
            get
            {
                if (supplierServ == null)
                    supplierServ = new SupplierService(db);
                return supplierServ;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
