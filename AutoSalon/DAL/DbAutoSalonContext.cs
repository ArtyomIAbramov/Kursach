using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.DAL
{
    public class DbAutoSalonContext : DbContext
    {
        public DbAutoSalonContext()
          : base("Autosalon2")
        {  }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<OrderClientEmployee> OrdersClientEmployee { get; set; }
        public virtual DbSet<OrderSupplierEmployee> OrdersSupplierEmployee { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
    }
}
