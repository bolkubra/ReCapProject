using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    
    public  interface IBrandService
    {
        //IResult Add(Brand brand);
        //IResult Delete(Brand brand);
        //IResult Update(Brand brand);
        //IDataResult<Brand> GetById(int id);
        //IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null);
        //List<BrandDetailDto> GetBrandDetails();

        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
