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

        public UserPManager(IUserPDal userPDal)
        {
            _userPDal = userPDal;
        }

        public List<OperationClaim> GetClaims(UserP userp)
        {
            return _userPDal.GetClaims(userp);
        }

        public void Add(UserP userp)
        {
            _userPDal.Add(userp);
        }

        public UserP GetByMail(string email)
        {
            return _userPDal.Get(u => u.Email == email);
        }
    }
}
