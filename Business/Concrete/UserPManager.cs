using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserPManager : IUserPService
    {
        IUserPDal _userPDal;

        public UserPManager(IUserPDal userDal)
        {
            _userPDal = userDal;
        }

        public List<OperationClaim> GetClaims(UserP user)
        {
            return _userPDal.GetClaims(user);
        }

        public void Add(UserP user)
        {
            _userPDal.Add(user);
        }

        public UserP GetByMail(string email)
        {
            return _userPDal.Get(u => u.Email == email);
        }
    }
}
