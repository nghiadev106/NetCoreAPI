using Microsoft.AspNetCore.Mvc;
using RestAPI.Model;
using RestAPI.Services.Interfaces;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [Route("create-item")]
        [HttpPost]
        public CustomerModel CreateItem([FromBody] CustomerModel model)
        {
            _customerServices.Create(model);
            return model;
        }
    }
}
