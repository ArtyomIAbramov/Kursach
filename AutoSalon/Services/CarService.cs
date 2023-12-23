using AutoSalon.DAL;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public class CarService : ICarService
    {
        private DbAutoSalonContext db;
        public CarService(DbAutoSalonContext dbRepos)
        {
            db = dbRepos;
        }

        public List<Car> GetAllCars()
        {
            return db.Cars.ToList();
        }


        public Car GetCar(int Id)
        {
            return db.Cars.Find(Id);
        }

        public void CreateCar(Car p)
        {
            Car car = new Car();

            car.Id = p.Id;
            car.BrandNew = p.BrandNew;
            car.Model = p.Model;
            car.Color = p.Color;
            car.Cost = p.Cost;
            car.Max_speed = p.Max_speed;
            car.Count = p.Count;
            car.Power = p.Power;
            car.Position = p.Position;

            db.Cars.Add(car);
            db.SaveChanges();
        }

        public void UpdateCar(Car p)
        {

            Car car = db.Cars.Find(p.Id);

            if (p != null)
            {
                car.Id = p.Id;
                car.BrandNew = p.BrandNew;
                car.Model = p.Model;
                car.Color = p.Color;
                car.Cost = p.Cost;
                car.Max_speed = p.Max_speed;
                car.Count = p.Count;
                car.Power = p.Power;
                car.Position = p.Position;

                db.SaveChanges();
            }
        }

        public void DeleteCar(int id)
        {
            Car p = db.Cars.Find(id);
            if (p != null)
            {
                db.Cars.Remove(p);
                db.SaveChanges();
            }
        }

        public Position GetPosition(int id)
        {
            Car car = db.Cars.Find(id);

            if (car != null)
            {
                return car.Position;
            }
            return Position.Default;
        }
    }
}
