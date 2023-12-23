using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Interface
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplier(int Id);
        void CreateSupplier(Supplier p);
        void UpdateSupplier(Supplier p);
        void DeleteSuppliert(int id);
    }
}
