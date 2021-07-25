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
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(us => us.UserId == userId), Messages.UserListed);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Update(User user)
        {
            try
            {
                _userDal.Update(user);
                return new SuccessResult(Messages.UserUpdated);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.UserCantUpdated);
            }
        }

        public IResult Delete(User user)
        {
            try
            {
                _userDal.Delete(user);
                return new SuccessResult(Messages.UserDeleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.UserCantDeleted);
            }
        }
    }
}
