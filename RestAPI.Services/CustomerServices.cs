using RestAPI.Model;
using RestAPI.Repositories.Interfaces;
using RestAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Services
{
    public partial class CustomerServices: ICustomerServices
    {
        private ICustomerRepository _res;
        public CustomerServices(ICustomerRepository res)
        {
            _res = res;
        }
        public bool Create(CustomerModel model)
        {
            return _res.Create(model);
        }
    }
}
