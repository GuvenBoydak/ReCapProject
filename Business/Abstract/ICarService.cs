﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int id);

        List<Car> GetCarsByColorId(int id);

        void Inserd(Car car);

        void Delete(Car car);

        void Update(Car car);

        List<CarDetailDto> GetAllCarDetail();
    }
}
