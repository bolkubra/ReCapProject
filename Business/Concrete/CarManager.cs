using Business.Abstract;
using DataAccess.Abtract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _carDal.GetAll();
        }

        public IEnumerable<object> GetAllByCarID(int v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetAllByCarId(int v)
        {
            throw new NotImplementedException();
        }
    }
}
