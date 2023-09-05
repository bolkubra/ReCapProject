using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult("Renk Bilgisi Silindi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            var list = _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(list, "REnkler Listelendi");
        }

        public IDataResult<Color> GetById(int id)
        {
            var data = _colorDal.Get(c => c.ColorId == id);
            return new SuccessDataResult<Color>(data);
        }

        public IResult Insert(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult("Renk Bilgisi Eklendi");
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult("Renk Bilgisi Güncellendi");
        }
    }
}
