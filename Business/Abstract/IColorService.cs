using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color car);
        void Delete(Color car);
        void Update(Color car);
        Color GetById(int id);
        List<Color> GetAll(Expression<Func<Color, bool>> filter = null);
    }
}
