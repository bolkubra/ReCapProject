using Core.Utilities.Results;
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
        //IDataResult<List<Car>> GetCarDetailsByColorNameAndBrandName(string colorName, string brandName);

        IResult Delete(Car car);
        IResult Update(Car car);
        IResult Insert(Car car);



        IResult AddTransactionalTest(Car car); // uygulamalarda tutarsızlıkları korumak adına yapılan bir yöntem





     
    }
}
