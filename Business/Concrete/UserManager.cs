using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager: IUserService
    {

        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<User> AddUser(User user)
        {
            try
            {
                _userDal.Add(user);

                return new SuccessDataResult<User>(user);

            }
            catch (Exception)
            {
                return new ErrorDataResult<User>(Messages.UserAddErr);
            }
            
        }

        public IDataResult<User> GetBySingleId(string singleId)
        {
           return new SuccessDataResult<User>(_userDal.GetList(x => x.SingleID == singleId).SingleOrDefault());

        }



        //public void Add(User user)
        //{
        //    _userDal.Add(user);
        //}



    }
}
