using AutoSalon.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Models
{
    public class OrderClientEmployee : Notify
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

        private int order_price;
        public int Order_price
        {
            get { return order_price; }
            set
            {
                order_price = value;
                OnPropertyChanged("Order_price");
            }
        }

        private int car_id;
        public int Car
        {
            get { return car_id; }
            set
            {
                car_id = value;
                OnPropertyChanged("Car");
            }
        }

        private int employee_id;
        public int Employee
        {
            get { return employee_id; }
            set
            {
                employee_id = value;
                OnPropertyChanged("Employee");
            }
        }

        private int client_id;
        public int Client
        {
            get { return client_id; }
            set
            {
                client_id = value;
                OnPropertyChanged("Client");
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
