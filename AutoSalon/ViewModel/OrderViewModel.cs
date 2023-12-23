using AutoSalon.Extensions;
using AutoSalon.Interface;
using AutoSalon.Models;
using AutoSalon.Services;
using AutoSalon.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace AutoSalon.ViewModel
{
    public class OrderViewModel : Notify
    {
        ICarService _carService;
        IEmployeeService _employeeService;
        IClientService _clientService;
        IOrderClientEmployeeService _orderClientEmployeeService;
        IOrderSupplierEmployeeService _orderSupplierEmployeeService;
        ISupplierService _supplierService;

        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public Car Car { get; set; }
        public Supplier Supplier { get; set; }

        public List<Client> Clients { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Car> Cars { get; set; }
        public List<Supplier> Suppliers { get; set; }

        public Client Entity { get; set; }

        public DateTime DateTime { get; set; }

        private ICommand addNewClientCommand;
        public ICommand AddClientCommand
        {
            get
            {
                if (addNewClientCommand == null)
                    addNewClientCommand = new RelCommand(param => AddClient(), null);

                return addNewClientCommand;
            }
        }


        private ICommand select_client;
        public ICommand SelectClientCommand
        {
            get
            {
                if (select_client == null)
                    select_client = new RelCommand(param => SelectClient(), null);

                return select_client;
            }
        }

        private ICommand choose_client;
        public ICommand ChooseClientCommand
        {
            get
            {
                if (choose_client == null)
                {
                    choose_client = new RelCommand(param => ChooseClient((int)param), null);
                }
                return choose_client;
            }
        }

        private ICommand select_car;
        public ICommand SelectCarCommand
        {
            get
            {
                if (select_car == null)
                    select_car = new RelCommand(param => SelectCar(), null);

                return select_car;
            }
        }

        private ICommand saveNewClientCommand;
        public ICommand SaveNewClientCommand
        {
            get
            {
                if (saveNewClientCommand == null)
                    saveNewClientCommand = new RelCommand(param => Save(), null);

                return saveNewClientCommand;
            }
        }

        private ICommand choose_car;
        public ICommand ChooseCarCommand
        {
            get
            {
                if (choose_car == null)
                    choose_car = new RelCommand(param => ChooseCar((int)param), null);

                return choose_car;
            }
        }

        private ICommand select_employee;
        public ICommand SelectEmployeeCommand
        {
            get
            {
                if (select_employee == null)
                    select_employee = new RelCommand(param => SelectEmployee(), null);

                return select_employee;
            }
        }

        private ICommand choose_employee;
        public ICommand ChooseEmployeeCommand
        {
            get
            {
                if (choose_employee == null)
                {
                    choose_employee = new RelCommand(param => ChooseEmployee((int)param), null);
                }
                return choose_employee;
            }
        }

        private ICommand create_order;
        public ICommand CreateCommand
        {
            get
            {
                if (create_order == null)
                    create_order = new RelCommand(param => CreateOrder(), null);

                return create_order;
            }
        }

        public OrderViewModel(ICarService carService, IEmployeeService employeeService, IClientService clientService, IOrderClientEmployeeService orderClientEmployeeService) 
        { 
            _carService = carService;
            _employeeService = employeeService;
            _clientService = clientService;
            _orderClientEmployeeService = orderClientEmployeeService;

            LoadAllEC();
        }

        public OrderViewModel(ICarService carService, IEmployeeService employeeService, ISupplierService supplierService, IOrderSupplierEmployeeService orderSupplierEmployeeService)
        {
            _carService = carService;
            _employeeService = employeeService;
            _supplierService = supplierService;
            _orderSupplierEmployeeService = orderSupplierEmployeeService;

            LoadAllES();
        }

        private void LoadAllES()
        {
            Employee = new Employee() { Id = -1 };
            Car = new Car() { Id = -1 };
            Supplier = new Supplier() { Id = -1 };

            DateTime = DateTime.Now;

            Suppliers = _supplierService.GetAllSuppliers();
            Employees = _employeeService.GetAllEmployees();
            Cars = _carService.GetAllCars();
        }

        private void LoadAllEC()
        {
            Client = new Client() { Id = -1};
            Employee = new Employee() { Id = -1 };
            Car = new Car() { Id = -1 };
            Entity = new Client();

            DateTime = DateTime.Now;

            Clients = _clientService.GetAllClients();
            Employees = _employeeService.GetAllEmployees();
            Cars = _carService.GetAllCars().Where(x => x.Position == Position.InShop)?.ToList();
        }

        public void SelectClient()
        {
            SelectClientView win = new SelectClientView(this);

            win.ShowDialog();
        }

        public void ChooseClient(int id)
        {
            var model = _clientService.GetClient(id);

            Client.Id = model.Id;
            Client.Name = model.Name;
            Client.Surname = model.Surname;
            Client.Phonenumber = model.Phonenumber;
            Client.Address = model.Address;
            Client.Passport = model.Passport;
            Client.Surname = model.Surname;

            MessageBox.Show("Клиент выбран");
        }

        public void SelectEmployee()
        {
            SelectEmployeeView win = new SelectEmployeeView(this);

            win.ShowDialog();
        }

        public void ChooseEmployee(int id)
        {
            var model = _employeeService.GetEmployee(id);

            Employee.Id = model.Id;
            Employee.Name = model.Name;
            Employee.Password = model.Password;
            Employee.Post = model.Post;
            Employee.TotalSold = model.TotalSold;
            Employee.Salary = model.Salary;
            Employee.Surname = model.Surname;
            Employee.Account = model.Account;
            Employee.Email = model.Email;
            Employee.Empaddress = model.Empaddress;
            Employee.Emppassport = model.Emppassport;
            Employee.Empphonenumber = model.Empphonenumber;

            MessageBox.Show("Сотрудник выбран");
        }

        public void SelectCar()
        {
            SelectCarView win = new SelectCarView(this);

            win.ShowDialog();
        }

        public void ChooseCar(int id)
        {
            var model = _carService.GetCar(id);

            Car.Id = model.Id;
            Car.BrandNew = model.BrandNew;
            Car.Model = model.Model;
            Car.Color = model.Color;
            Car.Cost = model.Cost;
            Car.Max_speed = model.Max_speed;
            Car.Power = model.Power;

            MessageBox.Show("Машина выбрана");
        }

        public void CreateOrder()
        {
            if(Car.Id < 0 || Client.Id < 0 || Employee.Id < 0)
            {
                MessageBox.Show("Не все данные заполнены!");
                return;
            }
            else
            {
                OrderClientEmployee orderClientEmployee = new OrderClientEmployee();
                orderClientEmployee.Order_date = DateTime;
                orderClientEmployee.Order_price = Car.Cost;
                orderClientEmployee.Car = Car.Id;
                orderClientEmployee.Employee = Employee.Id;
                orderClientEmployee.Client = Client.Id;
                orderClientEmployee.Contract_code = (DateTime.Now.Ticks - new DateTime(2023, 9, 23).Ticks).ToString().Substring(0, 7);

                if (_employeeService.GetEmployee(Employee.Id).TotalSold == null)
                    _employeeService.GetEmployee(Employee.Id).TotalSold = "0";

                _employeeService.GetEmployee(Employee.Id).TotalSold = (int.Parse(_employeeService.GetEmployee(Employee.Id).TotalSold) + Car.Cost).ToString();
                _clientService.GetClient(Client.Id).CarsNames += Car.Model + ", ";

                _orderClientEmployeeService.CreateOrder(orderClientEmployee);

                OrderSuccessView win = new OrderSuccessView();

                win.ShowDialog();
            }
        }

        private void AddClient()
        {
            AddNewClientView win = new AddNewClientView(this);

            win.ShowDialog();
        }

        public void Save()
        {
            if (Entity != null)
            {
                try
                {
                    if (Entity.Id <= 0)
                    {
                        _clientService.CreateClient(Entity);
                        MessageBox.Show("Запись успешно добавлено в бд");
                        Clients = _clientService.GetAllClients();
                    }
                    else
                    {
                        _clientService.UpdateClient(Entity);
                        MessageBox.Show("Запись успешно обновлена");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникли ошибки при запросе в бд");
                }
                finally
                {
                    Reset();
                }
            }
        }

        public void Reset()
        {
            Entity.Id = 0;
            Entity.Name = "";
            Entity.Surname = "";
            Entity.Phonenumber = "";
            Entity.Address = "";
            Entity.Passport = "";
            Entity.Cars = null;
        }
    }
}
