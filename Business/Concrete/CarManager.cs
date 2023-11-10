using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constanst;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofact.Caching;
using Core.Aspects.Autofact.Performance;
using Core.Aspects.Autofact.Transaction;
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
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        //[SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
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

        [CacheAspect] // key,value
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 7)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);

            }
           

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "listelendi");
        }

        [CacheAspect]
        [PerformanceAspect(5)] // bu metodun çalışması 5snyi geçerse beni uyar
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
            var result = _carDal.GetCarDetails();
            foreach (var item in result)
            {
                if (item.CarImage == null)
                {
                    item.CarImage = "default.jpg";
                }
            }
            return new SuccessDataResult<List<CarDetailDto>>(result);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByCarId(carId));
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Insert(car);
            if (car.DailyPrice < 1000)
            {
                throw new Exception("");
            }
            Insert(car);
            return null;
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrand(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByBrand(id));
        }


        public IDataResult<List<CarDetailDto>> GetCarsByColor(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByColor(id));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandAndColor(int brandId , int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsByBrandAndColor(brandId,colorId));
        }
    }
}
