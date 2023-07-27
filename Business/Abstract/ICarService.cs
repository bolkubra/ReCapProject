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
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetById(int id);
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);

        List<CarDetailDto> GetCarDetails();
        //List<CarDetailDto> GetCarDetails();
    }
}
