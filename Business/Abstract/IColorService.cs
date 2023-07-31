using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color car);
        IResult Delete(Color car);
        IResult Update(Color car);
        IDataResult <Color >GetById(int id);
        IDataResult <List<Color>> GetAll(Expression<Func<Color, bool>> filter = null);
    }
}
