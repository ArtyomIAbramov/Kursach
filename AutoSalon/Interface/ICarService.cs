using AutoSalon.Models;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCar(int Id);
        void CreateCar(Car p);
        void UpdateCar(Car p);
        void DeleteCar(int id);
        Position GetPosition(int id);
    }
}
