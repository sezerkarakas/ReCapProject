using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Brand + " : " + car.Description + " : " + car.DailyPrice);
            }

            Console.WriteLine("**********************************************");

            foreach (var car in carManager.GetById(5))
            {
                Console.WriteLine(car.Brand + " - BrandId: " + car.BrandId + " - CarId: " + car.CarId + " - ColorId: " + car.ColorId + " - " + car.ColorName + " - Price: " + car.DailyPrice + " - " + car.Description);
            }
        }
    }
}
