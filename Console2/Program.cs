using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

            //BrandTest();

            //ColorTest();








            /*Console.WriteLine("Brand Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByBrandId(2))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nColor Id'si 3 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByColorId(3))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n");

            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = -250, ModelYear = 1998, Descriptions = " Dizel" });
            brandManager.Add(new Brand { BrandName = "F" });
           */
        }

       /* private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var car in colorManager.GetAll())
            {
                Console.WriteLine(car.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var car in brandManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }*/

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.BrandName+'-'+car.ColorName);
            }
        }
    }

 }

