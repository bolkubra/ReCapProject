using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abtract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //List<Car> GetAll();
        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);

        //List<Car> GetAllByColor(int ColorId);

        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetailsByCarId(int carId);
        List<CarDetailDto> GetCarsByBrand(int id);
        List<CarDetailDto> GetCarsByColor(int id);
                

    }
}
