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
    public class EfColorDal : EfEntityRepositoryBase<Color,ReCapProjectContext> ,IColorDal
    {
        //public void Add(Color entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Color entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Color Get(Expression<Func<Color, bool>> filter)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        return context.Set<Color>()
        //            .SingleOrDefault(filter);
        //    }
        //}

        //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
        //    }
        //}

        //public Color GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Color entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
