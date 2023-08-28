using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IEntityService<Car>
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult AddTransactionalTest(Car car); // uygulamalarda tutarsızlıkları korumak adına yapılan bir yöntem





        //List<CarDetailDto> GetCarDetails();
    }
}
