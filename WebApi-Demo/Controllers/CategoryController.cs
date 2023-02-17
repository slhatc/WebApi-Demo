using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(IMapper mapper,ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return Ok(_mapper.Map<List<CategoryDto>>(categories));

        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Categories>(categoryDto));
            var categories = _mapper.Map<CategoryDto>(category);
            return this.StatusCode(201, categories);

        }
    }
}
