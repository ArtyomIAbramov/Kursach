using AutoSalon.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Models
{
    public partial class Employee : Notify
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
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");


            }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        private string post;
        public string Post
        {
            get { return post; }
            set
            {
                post = value;
                OnPropertyChanged("Post");
            }
        }
        private string empphonenumber;
        public string Empphonenumber
        {
            get { return empphonenumber; }
            set
            {
                empphonenumber = value;
                OnPropertyChanged("Empphonenumber");
            }
        }
        private string empaddress;
        public string Empaddress
        {
            get { return empaddress; }
            set
            {
                empaddress = value;
                OnPropertyChanged("Empaddress");
            }
        }
        private string emppassport;
        public string Emppassport
        {
            get { return emppassport; }
            set
            {
                emppassport = value;
                OnPropertyChanged("Emppassport");
            }
        }
        private string account;
        public string Account
        {
            get { return account; }
            set
            {
                account = value;
                OnPropertyChanged("Account");
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        private string salary;
        public string Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }

        private string totalSold;
        public string TotalSold
        {
            get { return totalSold; }
            set
            {
                totalSold = value;
                OnPropertyChanged("TotalSold");
            }
        }

        private List<Car> soldCars;
        public List<Car> SoldCars
        {
            get { return soldCars; }
            set
            {
                soldCars = value;
                OnPropertyChanged("SoldCars");
            }
        }
    }
}
