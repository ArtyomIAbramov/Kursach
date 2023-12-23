using AutoSalon.DAL;
using AutoSalon.Interface;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public class SupplierService : ISupplierService
    {
        private DbAutoSalonContext db;
        public SupplierService(DbAutoSalonContext dbRepos)
        {
            db = dbRepos;
        }
        public List<Supplier> GetAllSuppliers()
        {
            return db.Supplier.ToList();
        }


        public Supplier GetSupplier(int Id)
        {
            return db.Supplier.Find(Id);
        }

        public void CreateSupplier(Supplier p)
        {
            Supplier supplier = new Supplier();

            supplier.Id = p.Id;
            supplier.Name = p.Name;
            supplier.Surname = p.Surname;
            supplier.Phonenumber = p.Phonenumber;
            supplier.Address = p.Address;
            supplier.Salary = p.Salary;
            supplier.Passport = p.Passport;
            supplier.Cars = p.Cars;

            db.Supplier.Add(supplier);
            db.SaveChanges();
        }

        public void UpdateSupplier(Supplier p)
        {

            Supplier supplier = db.Supplier.Find(p.Id);

            if (p != null)
            {
                supplier.Id = p.Id;
                supplier.Name = p.Name;
                supplier.Surname = p.Surname;
                supplier.Phonenumber = p.Phonenumber;
                supplier.Address = p.Address;
                supplier.Salary = p.Salary;
                supplier.Passport = p.Passport;
                supplier.Cars = p.Cars;

                db.SaveChanges();
            }
        }

        public void DeleteSuppliert(int id)
        {
            Supplier p = db.Supplier.Find(id);
            if (p != null)
            {
                db.Supplier.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
