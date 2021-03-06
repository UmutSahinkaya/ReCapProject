using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;
using Entitiy.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetByUserId(int userId);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);

    }
}
