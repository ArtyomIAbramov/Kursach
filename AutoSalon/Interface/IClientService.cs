using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public interface IClientService
    {
        List<Client> GetAllClients();
        Client GetClient(int Id);
        void CreateClient(Client p);
        void UpdateClient(Client p);
        void DeleteClient(int id);
    }
}
