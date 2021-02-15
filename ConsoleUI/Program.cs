using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentACar();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result1 = rentalManager.GetAll();
            foreach ( var rental in result1.Data)
            {
                Console.WriteLine(rental.RentalId+" --- "+rental.CarId + " --- " +rental.CustomerId + " --- " + rental.RentDate );
            }

            
            //ResultTest();
            //CarTest();
            //ColorTest();
            //BrandTest();

        }

        private static void RentACar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 10, CustomerId =5, RentalId = 7, RentDate = new DateTime(2021, 2, 5) });
            Console.WriteLine(result.Message);
        }

        private static void ResultTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Car's name: " + car.Description + " Brand: " + car.BrandName + " Car's color: " + car.ColorName);
                    Console.WriteLine("\n**********************************************\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void BrandTest()
        //{
        //    Console.WriteLine("\n**********************************************\n");

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    Console.WriteLine(brandManager.GetById(1).BrandName);
        //}

        //private static void ColorTest()
        //{
        //    Console.WriteLine("\n**********************************************\n");
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var colors in colorManager.GetAll())
        //    {
        //        Console.WriteLine(colors.ColorName + " ----  " + colors.ColorId);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    //Arabaları listeleme
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description + " : " + car.DailyPrice);
        //    }


        //    Console.WriteLine("\n**********************************************\n");
        //    //Seçilen arabayı getirme
        //    Console.WriteLine(carManager.GetById(1).Description);


        //    Console.WriteLine("\n**********************************************\n");
        //    //Arabaları rengine göre listeleme

        //    foreach (var car in carManager.GetCarsByColorId(1))
        //    {
        //        Console.WriteLine(car.Description);

        //    }
        //}
    }
}
