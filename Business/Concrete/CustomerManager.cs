using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customers customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customers customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customers> GetById(int customerId)
        {
            return new SuccessDataResult<Customers>(_customerDal.Get(c => c.CustomerId == customerId));
        }

        public IResult Update(Customers customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
