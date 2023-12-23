using AutoSalon.Extensions;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using AutoSalon.DAL;
using AutoSalon.Services;
using System.Windows.Controls;

namespace AutoSalon.ViewModel
{
    public class EmployeeViewModel
    {
        private ICommand saveC;
        private ICommand editC;
        private ICommand deleteC;
        IEmployeeService _employeeService;
        ICarService _carService;

        public Employee Entity { get; set; }

        public ObservableCollection<Employee> Employee_list { get; set; }


        public ICommand SaveCommand
        {
            get
            {
                if (saveC == null)
                    saveC = new RelCommand(param => Save(), null);

                return saveC;
            }
        }

        public ICommand EditCommand
        {
            get
            {
                if (editC == null)
                    editC = new RelCommand(param => Edit((int)param), null);

                return editC;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteC == null)
                    deleteC = new RelCommand(param => Delete((int)param), null);

                return deleteC;
            }
        }


        public EmployeeViewModel(IEmployeeService employeeService, ICarService carService)
        {
            _employeeService = employeeService;
            _carService = carService;
            Entity = new Employee();
            Load();
        }

        public void Delete(int id)
        {
            if (MessageBox.Show("Подтверждаете удаление записи?", "Employee", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes)
            {
                try
                {
                    _employeeService.DeleteEmployee(id);
                    MessageBox.Show("Запись успешно удалена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла ошибка при удалении. " + ex.InnerException);
                }
                finally
                {
                    Load();
                }
            }
        }

        public void Save()
        {
            if (Entity != null)
            {
                try
                {
                    if (Entity.Id <= 0)
                    {
                        _employeeService.CreateEmployee(Entity);
                        MessageBox.Show("Запись успешно добавлено в бд");
                    }
                    else
                    {
                        _employeeService.UpdateEmployee(Entity);
                        MessageBox.Show("Запись успешно обновлена");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникли ошибки при запросе в бд");
                }
                finally
                {
                    Load();
                    Reset();
                }
            }
        }

        public void Reset()
        {
            Entity.Id = 0;
            Entity.Account = "";
            Entity.Surname = "";
            Entity.Email = "";
            Entity.Empaddress = "";
            Entity.Emppassport = "";
            Entity.Empphonenumber = "";
            Entity.Name = "";
            Entity.Password = "";
            Entity.Post = "";
            Entity.Salary = "";
            Entity.TotalSold = "";
        }

        public void Edit(int id)
        {
            var model = _employeeService.GetEmployee(id);

            Entity.Id = model.Id;
            Entity.Name = model.Name;
            Entity.Password = model.Password;
            Entity.Post = model.Post;
            Entity.TotalSold = model.TotalSold;
            Entity.Salary = model.Salary;
            Entity.Surname = model.Surname;
            Entity.Account = model.Account;
            Entity.Email = model.Email;
            Entity.Empaddress = model.Empaddress;
            Entity.Emppassport = model.Emppassport;
            Entity.Empphonenumber = model.Empphonenumber;
        }

        private void Load()
        {
            if (Employee_list == null)
            {
                Employee_list = new ObservableCollection<Employee>();
            }
            else
            {
                Employee_list.Clear();

            }
            if (_employeeService.GetAllEmployees().Count > 0)
            {
                foreach (Employee emp in _employeeService.GetAllEmployees())
                {
                    Employee_list.Add(emp);
                }
            }
        }
    }
}
