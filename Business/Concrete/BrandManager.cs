using Business.Abstract;
using Business.Constanst;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Marka Eklendi");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Marka Bilgisi Silindi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var list = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(list, "Markalar Listelendi");
        }

        public IDataResult<Brand> GetById(int id)
        {
            var data = _brandDal.Get(b => b.BrandId == id);
            return new SuccessDataResult<Brand>(data);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Marka Bilgisi Güncellendi");
        }
    }
}
