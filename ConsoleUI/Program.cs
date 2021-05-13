using Business.Concrete;
using DataAccess.Abstract;
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
            //CarGetAllTest();

            //CarGetByBrandIdTest();
            //CarGetByColorIdTest();

            //ColorGetAllTest();
            //ColorGetByIdTest();


            //BrandGetAllTest();
            //BrandGetByIdTest();

            //CarDetailDtoGetCarDetail();

            //CustomerAddTest();

            //RentalAddTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental1 = new Rental
            {
                Id = 5,
                CarId = 5,
                CustomerId = 5,
                RentDate = new DateTime(2021, 05, 10),
                ReturnDate = new DateTime(2021, 05, 15),
            };

            var result1 = rentalManager.Add(rental1);

            if (result1.Success==true)
            {
                Console.WriteLine(result1.Message);
            }
            else
            {
                Console.WriteLine(result1.Message);
            }

            Console.WriteLine("*****************************");

            var result2 = rentalManager.GetAll();

            if (result2.Success == true)
            {
                foreach (var rental in result2.Data)
                {
                    Console.WriteLine("Customer Id  / " + rental.CustomerId + " " + " / Rent Day   " + rental.RentDate + " " + " / Return Day   " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void CustomerAddTest()
        {
            Customer customer1 = new Customer
            {
                Id = 7,
                UserId = 7,
                CompanyName = "ByCarRent"

            };

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer1);

            var result1 = customerManager.GetAll();

            if (result1.Success == true)
            {
                foreach (var customer in result1.Data)
                {
                    Console.WriteLine(customer.UserId + " " + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result1.Message);
            }
        }

        private static void CarDetailDtoGetCarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllCarDetail().Data)
            {
                Console.WriteLine(car.CarId + " * " + car.BrandName + " * " + car.ColorName + " * " + car.DailyPrice);
            }
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetById(1).Data)
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetById(1).Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
            Console.WriteLine("-------------------------");
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
            Console.WriteLine("-------------------------");
        }

        private static void CarGetByColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " +
                    car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                Console.WriteLine("-------------------------");
            }
        }

        private static void CarGetByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " +
                    car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                Console.WriteLine("-------------------------");
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Id + " " + car.BrandId + " " +
                        car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                    Console.WriteLine("-------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
