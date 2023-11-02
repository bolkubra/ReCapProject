using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;

        public RentalManager(IRentalDal rental)
        {
            _rentalDal = rental;
        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Kiralama Bilgisi Silindi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var list = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(list, "Kiralama Bilgileri Listelendi");
        }

        public IDataResult<Rental> GetById(int id)
        {
            var data = _rentalDal.Get(r => r.RentalId == id);
            return new SuccessDataResult<Rental>(data);
        }

        public IResult Insert(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult("Kiralama Bilgisi Eklendi");
        }

        public IResult IsSuitableToRent(int rentid, DateTime startDate, DateTime endDate)
        {
            var rentals = _rentalDal.GetAll(r => r.CarId == rentid);

            if (rentals != null)
            {
                foreach (var rental in rentals)
                {
                    if (startDate >= rental.RentStartDate && startDate < rental.RentEndDate
           || endDate > rental.RentStartDate && endDate <= rental.RentEndDate
           || startDate <= rental.RentStartDate && endDate >= rental.RentEndDate)
                    {
                        // Rezervasyon mevcut, oda dolu
                        return new ErrorResult("Kiralama işlemine uygun değil");
                    }
                }


                return new SuccessResult("Kiralamaya Uygun");

            }
            else
            {
                return new ErrorResult("Kiralama işlemine uygun değildir");
            }


        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Kiralama Bilgisi Güncellendi");
        }
    }
}
