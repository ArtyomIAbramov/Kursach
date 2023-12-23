using AutoSalon.Interface;
using AutoSalon.Services;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderClientEmployeeService>().To<OrderClientEmployeeService>();
            Bind<IClientService>().To<ClientService>();
            Bind<ICarService>().To<CarService>();
            Bind<IEmployeeService>().To<EmployeeService>();
            Bind<IOrderSupplierEmployeeService>().To<OrderSupplierEmployeeService>();
            Bind<ISupplierService>().To<SupplierService>();
        }
    }
}
