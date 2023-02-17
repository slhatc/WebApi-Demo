using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(product));

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _productService.GetAllAsync();
       
            return Ok(_mapper.Map<List<ProductDto>>(customers));

        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Products>(productDto));
            var productsDto = _mapper.Map<ProductDto>(product);
            return this.StatusCode(201,productsDto);

        }
    }
}
