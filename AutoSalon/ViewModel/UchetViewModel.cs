using AutoSalon.Interface;
using AutoSalon.Models;
using AutoSalon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.ViewModel
{
    public class UchetViewModel
    {
        private IOrderClientEmployeeService _orderClientEmployeeService;
        public List<OrderClientEmployee> Orders_client_Employee { get; set; }


        public UchetViewModel(IOrderClientEmployeeService orderClientEmployeeService)
        {
            _orderClientEmployeeService = orderClientEmployeeService;
        }
    }
}
