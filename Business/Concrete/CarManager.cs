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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        //[CacheRemoveAspect("ICarService.Get")]
        //[TransactionScopeAspect] //>> Hata yönetimi
        //[PerformanceAspect(5)] //>> Bu metodun çalışması 5 sn geçerse beni uyar. Sadece bu metodu kontrol eder. Ama AspectInterceptorSelector içine yazılırsa tüm metodları kontrol eder.
        public IResult Insert(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {

                _carDal.Add(car);
                return new SuccessResult("eklendi");

            }
            else
            {
                return new ErrorResult("eklenemedi");
            }

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("silindi");
        }

        //[CacheRemoveAspect("ICarService.Get")] //>>Bellekte ICarService'deki bütün Get'leri sil demek
        //[CacheRemoveAspect("Get")] //>> Bellekte içerisinde Get olan tüm keyleri sil demek
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("güncellendi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 00)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "listelendi");
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId== carId));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId));
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

       
    }
}
