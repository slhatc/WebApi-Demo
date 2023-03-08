using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService , IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customers = await _customerService.GetByIdAsync(id);
            return Ok(customers);

        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerDto customerDto)
        {
            var customer = await _customerService.AddAsync(_mapper.Map<Customers>(customerDto));
            return this.StatusCode(201, customer);

        }
    }
}
