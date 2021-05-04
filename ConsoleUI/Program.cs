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
            ICarDal InMemoryCarDal = new InMemoryCarDal();

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
