using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserPManager : IUserService
    {
        IUserDal _userPDal;

        public UserPManager(IUserDal userPDal)
        {
            _userPDal = userPDal;
        }

        public List<OperationClaim> GetClaims(User userp)
        {
            return _userPDal.GetClaims(userp);
        }

        public void Add(User userp)
        {
            _userPDal.Add(userp);
        }

        public User GetByMail(string email)
        {
            return _userPDal.Get(u => u.Email == email);
        }
    }
}
