using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entitiy.Concrete;
using Entitiy.DTOs;

namespace DataAccess.Abstract
{   public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
