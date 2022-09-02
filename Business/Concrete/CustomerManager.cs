﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal; 

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            //İş kodları
            return _customerDal.GetAll();
        }

        public Customer GetById(string customerId)
        {
            //İş kodları
            return _customerDal.Get(c => c.CustomerId == customerId);
        }
    }
}
