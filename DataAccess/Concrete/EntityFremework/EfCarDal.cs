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

            //using (ReCapProjectContext context = new ReCapProjectContext())
            //{

            //    var result = from c in context.Cars
            //                 join b in context.Brands
            //                 on c.BrandId equals b.BrandId
            //                 join co in context.Colors
            //                 on c.ColorId equals co.ColorId
            //                 select new CarDetailDto()
            //                 {
            //                     CarName = c.CarName,
            //                     BrandName = b.BrandName,
            //                     ColorName = co.ColorName,
            //                     DailyPrice = c.DailyPrice
            //                 };
            //    return result.ToList();


            //}

            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                
                                 CarName = car.CarName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName
                             };
                return result.ToList();

            }


        }

        

    }


}
