using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserPService
    {
        List<OperationClaim> GetClaims(UserP user);
        void Add(UserP user);
        UserP GetByMail(string email);
    }
}
