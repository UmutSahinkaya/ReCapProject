using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entitiy.Concrete;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(re => re.CustomerId == customerId),Messages.RentalListed);
        }

        public IResult Add(Rental rental)
        {
            if (isThatCarDeliveried(rental.CarId))
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }

            return new ErrorResult(Messages.RentalProblem);

        }

        public IResult Update(Rental rental)
        {
            try
            {
                _rentalDal.Update(rental);
                return new SuccessResult(Messages.RentalUpdated);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.RentalCantUpdated);
            }
        }

        public IResult Delete(Rental rental)
        {
            try
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.RentalDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.RentalCantDeleted);
            }
        }
        public bool isThatCarDeliveried(int id)
        {
            var result = _rentalDal.Get(r => r.CarId == id && r.ReturnDate == null); // parametre olarak aldıgın id ye göre rentali getir. ve gelen ilanın returndate i boş olanı getir
            if (result == null)
            {
                return true; // demek ki hiçbir ilan gelmemiş, demek ki return tarihi boş değil yani araç teslim edilmiş.
            }
            return false;
        }
    }
}
