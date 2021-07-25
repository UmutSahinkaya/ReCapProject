using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entitiy.Concrete;
using Entitiy.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _cars;

        public CarManager(ICarDal cars)
        {
            _cars = cars;
        }

        public IDataResult<List<Car>> GetAll()
        {
            //Yönetimden Gelen İş Kodları
            return new SuccessDataResult<List<Car>>(_cars.GetAll(),Messages.CarListed);

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.BrandId == BrandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.ColorId == ColorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cars.GetCarDetails());
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >= 0)
            {
                return new ErrorResult(Messages.CarDescInvalidLetterLenght);
            }
            _cars.Add(car);
            return new Result(true, Messages.CarAdded);

        }

        public IResult Update(Car car)
        {
            _cars.Update(car);
            return new Result(true,Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _cars.Delete(car);
            return new Result(true,Messages.CarDeleted);
        }
    }
}
