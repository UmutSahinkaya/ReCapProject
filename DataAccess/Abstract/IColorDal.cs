using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entitiy.Concrete;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
    }
}
