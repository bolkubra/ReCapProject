using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Abtract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFremework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
              
                var result = from car in context.Cars
                             join b in context.Brands
                                 on car.BrandId equals b.Id
                             join col in context.Colors
                                 on car.ColorId equals col.Id
                             
                             select new CarDetailDto
                             {
                                 CarName = car.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 ModelYear = car.ModelYear, 
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }
    }
}
