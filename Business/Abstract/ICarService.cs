﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<Car> GetById(int carId);


        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarsByBrand(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColor(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandAndColor(int brandId, int colorId);

        IResult Delete(Car car);
        IResult Update(Car car);
        IResult Insert(Car car);



        IResult AddTransactionalTest(Car car); // uygulamalarda tutarsızlıkları korumak adına yapılan bir yöntem

       




    }
}
