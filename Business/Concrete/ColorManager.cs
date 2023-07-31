using Business.Abstract;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        public IResult Add(Color car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Color car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Color> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color car)
        {
            throw new NotImplementedException();
        }
    }
}
