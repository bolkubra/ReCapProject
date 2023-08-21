using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constanst;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofact.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Businness;
using Core.Utilities.Results;
using DataAccess.Abtract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("car.add,admin")] // yetki kontorlü
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //business kod
            //validation - doğrulama kod
            //if (car.CarName.Length < 2) // min 2 karakter
            //{
            //    return new ErrorResult(Messages.CarNameInvalid);
            //}
            //ValidationTool.Validate(new CarValidator(), car);
            
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 7)
            //{
            //    return new ErrorDataResult<List<Car>>("System is in maintenance!");

            //}


            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Cars listed!");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id), "Car CarId:" + id + " is provided!");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), "Car details provided!");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId), "Car BrandId:" + brandId + " probided!");
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), "Car ColorId:" + colorId + " provided!");
        }

        public IResult Insert(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult("Car inserted!");
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
