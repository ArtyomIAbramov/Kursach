using AutoSalon.Extensions;
using AutoSalon.Models;
using AutoSalon.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using AutoSalon.Views;
using System.ComponentModel;

namespace AutoSalon.ViewModel
{
    public class ClientsViewModel
    {
        IClientService _clientService;

        public List<Client> Client_list { get; set; }

        public ClientsViewModel(IClientService clientService)
        {
            Client_list = clientService.GetAllClients();
        }
    }
}
