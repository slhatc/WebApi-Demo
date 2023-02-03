using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var customers = await _customerService.GetByIdAsync(id);
            return Ok(customers);

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);

        }
    }
}
