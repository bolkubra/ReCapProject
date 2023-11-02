using Business.Abstract;
using Castle.Core.Resource;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {

            _paymentDal = paymentDal;
        }
        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult("Ödeme bilgisi silindi");
        }

        public IDataResult<List<Payment>> GetAll()
        {
            var list = _paymentDal.GetAll();
            return new SuccessDataResult<List<Payment>>(list, "Ödemeler Listelendi");
        }

        public IDataResult<Payment> GetById(int id)
        {
            var data = _paymentDal.Get(p => p.Id == id);
            return new SuccessDataResult<Payment>(data);
        }

        public IResult Insert(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult("Ödeme Bilgisi Eklendi");
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult("Ödeme Bilgisi Güncellendi");
        }
    }
}
