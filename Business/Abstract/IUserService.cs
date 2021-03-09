using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        //  List<OperationClaim> GetClaims(User user);
        //  void Add(User user);
        // User GetByMail(string email);
        IDataResult<User> GetBySingleId(string singleId);

        IResult AddUser(User user);
        IResult UpdateUser(User user);
        IResult DeleteUser(string SingleId);
    }
}
