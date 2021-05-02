using RestAPI.Model;
using RestAPI.Repositories.Helper.interfaces;
using RestAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Repositories
{
    public partial class CustomerRepository : ICustomerRepository
    {
        private IDatabaseHelper _dbHelper;
        public CustomerRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool Create(CustomerModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_customer_create",
                "@customer_email", model.customer_email,
                "@customer_password", model.customer_password);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
