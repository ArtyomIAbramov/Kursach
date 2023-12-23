using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Models
{
    public class OrderClientEmployeeEntity
    {
        public Car Car { get; set; }

        public Employee Employee { get; set; }

        public Client Client { get; set; }

        public OrderClientEmployee OrderClientEmployee { get; set; }
    }
}
