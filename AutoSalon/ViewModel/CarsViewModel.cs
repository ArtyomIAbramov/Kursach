using AutoSalon.Models;
using AutoSalon.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.ViewModel
{
    public class CarsViewModel
    {
        private ICarService _carService;

        public List<Car> Cars_in_shop_list { get; set; }
        public List<Car> Cars_in_stock_list { get; set; }
        public CarsViewModel(ICarService carService)
        {
            _carService = carService;

            Cars_in_stock_list = _carService.GetAllCars()?.Where(x => x.Position == Position.InStock)?.ToList();

            Cars_in_shop_list = _carService.GetAllCars()?.Where(x => x.Position == Position.InShop)?.ToList();
        }
    }
}
