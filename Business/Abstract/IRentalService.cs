using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService :IEntityService<Rental>
    {
        public IResult IsSuitableToRent(Rental entity);
    }
}
