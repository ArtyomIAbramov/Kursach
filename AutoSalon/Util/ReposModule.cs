using AutoSalon.DAL;
using AutoSalon.Repos;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Util
{
    public class ReposModule : NinjectModule
    {
        private string connectionString;
        public ReposModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IDbSQL>().To<DbSQL>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
