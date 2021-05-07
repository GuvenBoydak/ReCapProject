﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car { Id=1, BrandId=1, ColorId=1, ModelYear=2010, DailyPrice=400, Description="320"},
                new Car { Id=2, BrandId=2, ColorId=2, ModelYear=2015, DailyPrice=350, Description="A3"},
                new Car { Id=3, BrandId=3, ColorId=3, ModelYear=2018, DailyPrice=250, Description="Leon"},
                new Car { Id=4, BrandId=3, ColorId=2, ModelYear=2019, DailyPrice=550, Description="Caravella"},
                new Car { Id=5, BrandId=4, ColorId=4, ModelYear=2020, DailyPrice=200, Description="Clio"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var CarDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(CarDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var CarUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            CarUpdate.BrandId = car.BrandId;
            CarUpdate.ColorId = car.ColorId;
            CarUpdate.DailyPrice = car.DailyPrice;
            CarUpdate.ModelYear = car.ModelYear;
            CarUpdate.Description = car.Description;
        }
    }
}
