using System;
using System.Collections.Generic;
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

        public List<Car> GetById(int Id)
        {
            return _cars.GetById(Id);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
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
