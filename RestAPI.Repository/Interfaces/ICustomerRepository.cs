using RestAPI.Model;

namespace RestAPI.Repositories.Interfaces
{
    public partial interface ICustomerRepository
    {
        bool Create(CustomerModel model);
    }
}
