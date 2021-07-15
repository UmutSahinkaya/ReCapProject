using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entitiy.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1,ColorId = 1,BrandId = 1,DailyPrice = 150,Description = "BMW 320D",ModelYear ="2015"},
                new Car{Id=2,ColorId = 1,BrandId = 2,DailyPrice = 200,Description = "Audi A3",ModelYear = "2016"},
                new Car{Id=3,ColorId = 2,BrandId = 3,DailyPrice = 50,Description = "Şahin SLX",ModelYear = "2017"},
                new Car{Id=4,ColorId = 2,BrandId = 3,DailyPrice = 10000,Description = "Masserati GranTurismo",ModelYear ="2018"},
                new Car{Id=5,ColorId = 3,BrandId = 4,DailyPrice = 450,Description = "Audi A6",ModelYear = "2019"}
            };
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        { 
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.BrandId == car.BrandId);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(p => p.BrandId == car.BrandId);
            _cars.Remove(CarToDelete);
        }
    }
}
