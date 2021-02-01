using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, Brand="Eagle", BrandId=1, ColorName="White", ColorId=1, DailyPrice=20000, ModelYear=1994, Description="It is looking like an eagle."},
                new Car{CarId=2, Brand="Hawk", BrandId=2, ColorName="Red", ColorId=2, DailyPrice=25000, ModelYear=1990, Description="It is looking like a hawk."},
                new Car{CarId=3, Brand="Falcon", BrandId=3, ColorName="Blue", ColorId=3, DailyPrice=22500, ModelYear=1993, Description="It is looking like a falcon."},
                new Car{CarId=4, Brand="Anatolia", BrandId=4, ColorName="White", ColorId=1, DailyPrice=30000, ModelYear=1976, Description="It is from Anatolia."},
                new Car{CarId=5, Brand="Femrari", BrandId=5, ColorName="White", ColorId=1, DailyPrice=1000, ModelYear=2010, Description="It is a cheap car."},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Brand = car.Brand;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ColorName = car.ColorName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
