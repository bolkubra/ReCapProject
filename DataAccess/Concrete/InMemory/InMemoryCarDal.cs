using DataAccess.Abtract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
                _cars = new List<Car>
                { 
                    new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=15800,ModelYear=2004,Description="Hasarsız"},
                    new Car {CarId=2,BrandId=1,ColorId=2,DailyPrice=19500,ModelYear=2012,Description="Boyasız"},
                    new Car {CarId=3,BrandId=2,ColorId=3,DailyPrice=20500,ModelYear=2016,Description="Değişensiz"},
                };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); // car'ı tek tek dolaşmayı sağlar 
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColor(int ColorId)
        {
            return _cars.Where(c=>c.ColorId == ColorId).ToList();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
        }
    }
}
