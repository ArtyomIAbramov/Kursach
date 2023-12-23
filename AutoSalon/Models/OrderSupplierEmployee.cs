using AutoSalon.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Models
{
    public class OrderSupplierEmployee : Notify
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private DateTime order_date;
        public DateTime Order_date
        {
            get { return order_date; }
            set
            {
                order_date = value;
                OnPropertyChanged("Order_date");
            }
        }

        private string order_price;
        public string Order_price
        {
            get { return order_price; }
            set
            {
                order_price = value;
                OnPropertyChanged("Order_price");
            }
        }

        private Car car;
        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                OnPropertyChanged("Car");
            }
        }

        private Employee employee;
        public Employee Employee
        {
            get { return employee; }
            set
            {
                employee = value;
                OnPropertyChanged("Employee");
            }
        }

        private Supplier supplier;
        public Supplier Supplier
        {
            get { return supplier; }
            set
            {
                supplier = value;
                OnPropertyChanged("Supplier");
            }
        }

        private string contract_code;
        public string Contract_code
        {
            get { return contract_code; }
            set
            {
                contract_code = value;
                OnPropertyChanged("Contract_code");
            }
        }
    }
}
