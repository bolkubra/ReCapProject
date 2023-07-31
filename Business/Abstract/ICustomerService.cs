using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer custmer);
        IResult Update(Customer customer);
        IDataResult<Customer> GetById(int id);
        IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null);
    }
}
