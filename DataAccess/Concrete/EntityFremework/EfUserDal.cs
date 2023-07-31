using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Abtract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFremework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectContext>, IUserDal
    {
        //public void Add(User entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(User entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public User Get(Expression<Func<User, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(User entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
