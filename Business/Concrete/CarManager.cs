using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _cars;

        public CarManager(ICarDal cars)
        {
            _cars = cars;
        }

        public List<Car> GetAll()
        {
            //Yönetimden Gelen İş Kodları
            return _cars.GetAll();

        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _cars.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _cars.GetAll(c => c.ColorId == ColorId);
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >= 0)
            {
                _cars.Add(car);
                Console.WriteLine("Araba Sisteme eklendi.");
            }
            else
            {
                Console.WriteLine("Arabanın açıklaması en az iki harf ve günlük bedeli 0 dan farklı değer olmalı.");
            }
            
        }

        public void Update(Car car)
        {
            _cars.Update(car);
        }

        public void Delete(Car car)
        {
            _cars.Delete(car);
        }
    }
}
