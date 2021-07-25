using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entitiy.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            var result = _colorDal.GetAll();
            //return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColorsListed);
            if (result.Count < 0)
            {
                return new ErrorDataResult<List<Color>>(Messages.ColorNotFound);
            }
            return new SuccessDataResult<List<Color>>(result, Messages.ColorsListed);
        }
         
        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(co => co.ColorId==colorId), Messages.ColorListed);
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Update(Color color)
        {
            try
            {
                _colorDal.Update(color);
                return new SuccessResult(Messages.ColorUpdated);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.ColorCantUpdated);
            }
        }

        public IResult Delete(Color color)
        {
            try
            {
                _colorDal.Delete(color);
                return new SuccessResult(Messages.ColorDeleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.ColorCantDeleted);
            }
        }
    }
}
