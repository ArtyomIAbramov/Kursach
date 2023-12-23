using AutoSalon.Extensions;
using AutoSalon.Interface;
using AutoSalon.Services;
using AutoSalon.Util;
using AutoSalon.Views;
using AutoSalon.Views.OrderClientEmployee;
using Ninject;
using System.Windows.Input;

namespace AutoSalon.ViewModel
{
    public class HomeViewModel
    {
        private ICommand _employeeCommand;
        private ICommand _priceListCommand;
        private ICommand _storeCommand;
        private ICommand _newBuyCommand;
        private ICommand _newSellCommand;
        private ICommand _uchetCommand;
        private ICommand _clientsCommand;

        private ICarService _carService;
        private IClientService _clientService;
        private IEmployeeService _employeeService;
        private IOrderClientEmployeeService _orderClientEmployeeService;
        private IOrderSupplierEmployeeService _orderSupplierEmployeeService;
        private ISupplierService _supplierService;


        public HomeViewModel()
        {
            var kernel = new StandardKernel(new NinjectRegistrations(), new ReposModule("Autosalon2"));

            _carService = kernel.Get<ICarService>();
            _clientService = kernel.Get<IClientService>();
            _employeeService = kernel.Get<IEmployeeService>();
            _orderClientEmployeeService = kernel.Get<IOrderClientEmployeeService>();
            _orderSupplierEmployeeService = kernel.Get<IOrderSupplierEmployeeService>();
            _supplierService = kernel.Get<ISupplierService>();
        }

        public ICommand EmployeesCommand
        {
            get
            {
                if (_employeeCommand == null)
                    _employeeCommand = new RelCommand(param => EmployeeWindow(), null);

                return _employeeCommand;
            }
        }

        public ICommand PriceListCommand
        {
            get
            {
                if (_priceListCommand == null)
                    _priceListCommand = new RelCommand(param => PriceListWindow(), null);

                return _priceListCommand;
            }
        }

        public ICommand StoreCommand
        {
            get
            {
                if (_storeCommand == null)
                    _storeCommand = new RelCommand(param => StoreWindow(), null);

                return _storeCommand;
            }
        }

        public ICommand NewBuyCommand
        {
            get
            {
                if (_newBuyCommand == null)
                    _newBuyCommand = new RelCommand(param => NewBuyWindow(), null);

                return _newBuyCommand;
            }
        }

        public ICommand NewSellCommand
        {
            get
            {
                if (_newSellCommand == null)
                    _newSellCommand = new RelCommand(param => NewSellWindow(), null);

                return _newSellCommand;
            }
        }

        public ICommand UchetCommand
        {
            get
            {
                if (_uchetCommand == null)
                    _uchetCommand = new RelCommand(param => UchetWindow(), null);

                return _uchetCommand;
            }
        }

        public ICommand ClientsCommand
        {
            get
            {
                if (_clientsCommand == null)
                    _clientsCommand = new RelCommand(param => ClientsWindow(), null);

                return _clientsCommand;
            }
        }



        public void EmployeeWindow()
        {
            EmployeeView win = new EmployeeView(_employeeService, _carService);
            win.ShowDialog();
        }
        public void PriceListWindow()
        {
            PriceList view = new PriceList(_carService);
            view.ShowDialog();
        }
        public void StoreWindow()
        {
            CarsInStock win = new CarsInStock(_carService);
            win.ShowDialog();
        }
        public void NewBuyWindow()
        {
            OrderFormView win = new OrderFormView(_carService, _employeeService, _clientService, _orderClientEmployeeService);
            win.ShowDialog();
        }
        public void NewSellWindow()
        {
            OrderSupplierFormView win = new OrderSupplierFormView(_carService, _employeeService, _supplierService, _orderSupplierEmployeeService);
            win.ShowDialog();
        }
        public void UchetWindow()
        {
            UchetView win = new UchetView(_orderClientEmployeeService);
            win.ShowDialog();
        }
        public void ClientsWindow()
        {
            ClientsView win = new ClientsView(_clientService);
            win.ShowDialog();
        }
    }
}
