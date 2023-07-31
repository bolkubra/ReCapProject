using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public IResult Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer custmer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
