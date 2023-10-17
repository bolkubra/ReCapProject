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
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId
                             select new CarDetailDto
                             {
                                
                                 CarName = car.CarName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 CarImage = carImage.ImagePath,
                             };
                return result.ToList();

            }


        }

        public List<CarDetailDto> GetCarsByBrand(int brandId)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId
                             where brand.BrandId == brandId
                             select new CarDetailDto()
                             {
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,     
                                 ModelYear = car.ModelYear,
                                 CarImage = carImage.ImagePath,

                             };
                return result.ToList();
            }

        }

        public List<CarDetailDto> GetCarsByColor(int colorId)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join carImage in context.CarImages on car.CarId equals carImage.CarId
                             where color.ColorId == colorId
                             select new CarDetailDto()
                             {
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 CarImage = carImage.ImagePath

                             };
                return result.ToList();
            }
        }
    }


}
