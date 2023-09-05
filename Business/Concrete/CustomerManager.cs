using Business.Abstract;
using Castle.Core.Resource;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal) { 
        
            _customerDal = customerDal;
        }
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult("Müşteri Bilgisi Silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var list = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(list, "Müşteriler Listelendi");
        }

        public IDataResult<Customer> GetById(int id)
        {
            var data = _customerDal.Get(c => c.CustomerId == id);
            return new SuccessDataResult<Customer>(data);
        }

        public IResult Insert(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("Müşteri Bilgisi Eklendi");
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult("Müşteri Bilgisi Güncellendi");
        }
    }
}
