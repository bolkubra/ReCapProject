using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abtract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager()
        {

        }

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult <List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            //if (DateTime.Now.Hour == 7)
            //{
            //    return new ErrorDataResult<List<Car>>("System is in maintenance!");

            //}


            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Cars listed!");
        }

        public IDataResult <Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
           return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
