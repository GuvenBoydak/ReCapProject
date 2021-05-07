using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarGetAllTest();
            //CarGetByBrandIdTest();
            //CarGetByColorIdTest();

            //ColorGetAllTest();
            //ColorGetByIdTest();


            //BrandGetAllTest();
            //BrandGetByIdTest();

            CarDetailDtoGetCarDetail();
 

        }

        private static void CarDetailDtoGetCarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllCarDetail())
            {
                Console.WriteLine(car.CarId + " * " + car.BrandName + " * " + car.ColorName + " * " + car.DailyPrice);
            }
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetById(1))
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetById(1))
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
            Console.WriteLine("-------------------------");
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
            Console.WriteLine("-------------------------");
        }

        private static void CarGetByColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " +
                    car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                Console.WriteLine("-------------------------");
            }
        }

        private static void CarGetByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " +
                    car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                Console.WriteLine("-------------------------");
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " +
                    car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
