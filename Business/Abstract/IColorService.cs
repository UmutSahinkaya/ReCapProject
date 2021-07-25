﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;
using Entitiy.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}