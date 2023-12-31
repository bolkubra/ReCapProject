﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService :IEntityService<Rental>
    {
        //IDataResult<List<Rental>> GetAll(); // liste yolladığımız zaman
        //IDataResult<Rental> GetById(int id);
        //IResult Add(Rental rental);
        //IResult Update(Rental rental);
        //IResult Delete(Rental rental);

        IResult IsSuitableToRent(int rentid, DateTime startDate, DateTime endDate);

    }
}
