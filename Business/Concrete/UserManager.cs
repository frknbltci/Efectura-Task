using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Business;
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

        public IResult AddUser(User user)
        {
            IResult result = BusinessRules.Run(CheckIfUserSameSingleId(user.SingleID));
            if (result != null)
            {

                return  new ErrorResult(Messages.UserSameSingleIdError);
                // return result;
            }

            _userDal.Add(user);

            return new SuccessDataResult<User>(user);

        }

        public IResult DeleteUser(string SingleId)
        {

            IResult result = BusinessRules.Run(CheckIfSingleIdNullOrEmpty(SingleId));
            if (result != null)
            {
                return new ErrorResult(Messages.ErrUnnec);
            }
            _userDal.Delete(_userDal.GetList(x => x.SingleID == SingleId).SingleOrDefault());
            return new SuccessResult(Messages.UserDeleteSuccess);
        }

        public IDataResult<User> GetBySingleId(string singleId)
        {
           return new SuccessDataResult<User>(_userDal.GetList(x => x.SingleID == singleId).SingleOrDefault());

        }

        public IResult UpdateUser(User user)
        {
            try
            {
                var InUser = _userDal.GetList(x => x.SingleID == user.SingleID).SingleOrDefault();
                user.CreationDate = InUser.CreationDate;
                user.LastModified = DateTime.Now;
                user.SingleID = InUser.SingleID;
                user.Id = InUser.Id;

                _userDal.Update(user);

                return new SuccessResult(Messages.UpdateSuccess);

            }
            catch (Exception ex)
            {

                return new ErrorResult(Messages.ErrUnnec);
            }
          
        }



     
        private IResult CheckIfUserSameSingleId(string singleId)
        {
            var result = _userDal.GetList(x => x.SingleID == singleId).Any();
            if (result)
            {
                return new ErrorResult(Messages.UserSameSingleIdError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfSingleIdNullOrEmpty(string SingleId)
        {
            if (String.IsNullOrEmpty(SingleId))
            {
                return new ErrorResult(Messages.UserSameSingleIdError);
            }
            return new SuccessResult();
        }
    }
}
