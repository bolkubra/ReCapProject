using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFremework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapProjectContext>
    {
        //public void Add(Brand entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Brand entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Brand Get(Expression<Func<Brand, bool>> filter)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        return context.Set<Brand>()
        //            .SingleOrDefault(filter);
        //    }
        //}

        //public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
        //    }
        //}

        //public Brand GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Brand entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
