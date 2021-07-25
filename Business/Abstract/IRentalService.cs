using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;
using Entitiy.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByCustomerId(int customerId);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
