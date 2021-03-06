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
   public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                 new Car { CarId = 1, BrandId = 1, ColorId = 1,ModelYear = 2007, DailyPrice =250,Descriptions="Dizel" },
                 new Car { CarId = 2, BrandId = 2, ColorId = 3,ModelYear = 1990, DailyPrice = 180, Descriptions = "Benzinli" },
                 new Car { CarId = 3, BrandId = 4, ColorId = 3,ModelYear = 2015, DailyPrice = 120, Descriptions = "Dizel" },
                 new Car { CarId = 4, BrandId = 4, ColorId = 2,ModelYear = 2014, DailyPrice = 90, Descriptions = "Benzinli" },
                 new Car { CarId = 5, BrandId = 1, ColorId = 4,ModelYear = 2021, DailyPrice = 380, Descriptions = "Dizel" },

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

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId ==car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;



        }


    }
}
