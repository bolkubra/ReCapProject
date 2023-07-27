using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        public void Add(Color car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color car)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color car)
        {
            throw new NotImplementedException();
        }
    }
}
