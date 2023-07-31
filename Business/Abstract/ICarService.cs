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
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult< Car> GetById(int id);
        IDataResult <List<Car>> GetAll(Expression<Func<Car, bool>> filter = null);

        IDataResult <List<CarDetailDto>> GetCarDetails();
        //List<CarDetailDto> GetCarDetails();
    }
}
