using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
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
            
            //CarTest();
            //ColorTest();
            //BrandTest();

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
