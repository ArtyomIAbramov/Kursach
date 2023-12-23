using AutoSalon.Interface;
using AutoSalon.Models;
using AutoSalon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.ViewModel
{
    public class UchetViewModel
    {
        private IOrderClientEmployeeService _orderClientEmployeeService;
        private ICarService _carService;
        private IEmployeeService _employeeService;
        private IClientService _clientService;

        public List<OrderClientEmployeeEntity> Orders_client_Employee_Entity { get; set; }

        public List<OrderClientEmployee> Orders_client_Employee { get; set; }

        public UchetViewModel(ICarService carService, IEmployeeService employeeService, IClientService clientService, IOrderClientEmployeeService orderClientEmployeeService)
        {
            _orderClientEmployeeService = orderClientEmployeeService;
            _carService = carService;
            _employeeService = employeeService;
            _clientService = clientService;

            Load();
        }

        private void Load() 
        {
            Orders_client_Employee = _orderClientEmployeeService.GetOrders();

            Orders_client_Employee_Entity = new List<OrderClientEmployeeEntity>();

            foreach (OrderClientEmployee emp in Orders_client_Employee)
            {
                OrderClientEmployeeEntity temp = new OrderClientEmployeeEntity();
                temp.OrderClientEmployee = emp;
                temp.Car = _carService.GetCar(emp.Car);
                temp.Client = _clientService.GetClient(emp.Client);
                temp.Employee = _employeeService.GetEmployee(emp.Employee);
                Orders_client_Employee_Entity.Add(temp);
            }
        }
    }
}
