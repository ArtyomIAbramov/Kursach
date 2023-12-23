using AutoSalon.DAL;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace AutoSalon.Services
{
    public class EmployeeService : IEmployeeService
    {
        private DbAutoSalonContext db;
        public EmployeeService(DbAutoSalonContext dbRepos)
        {
            db = dbRepos;
        }

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }


        public Employee GetEmployee(int Id)
        {
            return db.Employees.Find(Id);
        }

        public void CreateEmployee(Employee p)
        {
            Employee employee = new Employee();

                employee.Id = p.Id;
                employee.Name = p.Name;
                employee.Password = p.Password;
                employee.Post = p.Post;
                employee.Salary = p.Salary;
                employee.TotalSold = p.TotalSold;
                employee.Surname = p.Surname;
                employee.Account = p.Account;
                employee.Email = p.Email;
                employee.Empaddress = p.Empaddress;
                employee.Emppassport = p.Emppassport;
             employee.Empphonenumber = p.Empphonenumber;

            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void UpdateEmployee(Employee p)
        {

            Employee employee = db.Employees.Find(p.Id);

            if (p != null)
            {
                employee.Id = p.Id;
                employee.Name = p.Name;
                employee.Password = p.Password;
                employee.Post = p.Post;
                employee.TotalSold = p.TotalSold;
                employee.Salary = p.Salary;
                employee.Surname = p.Surname;
                employee.Account = p.Account;
                employee.Email = p.Email;
                employee.Empaddress = p.Empaddress;
                employee.Emppassport = p.Emppassport;
                employee.Empphonenumber = p.Empphonenumber;
                db.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            Employee p = db.Employees.Find(id);
            if (p != null)
            {
                db.Employees.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
