using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    
    public  interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
        IDataResult <Brand> GetById(int id);
        IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null);
        //List<CarDetailDto> GetCarDetails();
    }
}
