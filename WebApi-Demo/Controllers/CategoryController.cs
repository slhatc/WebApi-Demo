using AutoMapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using System.ComponentModel.Design;
using System.Net;

namespace WebApi_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryService _categoryService;
        public CategoryController(IMapper mapper,IUnitOfWork unitOfWork,ICategoryService categoryService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _categoryService = categoryService;
        }
        [Authorize]
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id,CategoryDto categoryDto)
        {
            var control = _categoryService.GetByIdAsync(id);
            if (control.Result != null)
            {
                control.Result.CategoryName = categoryDto.CategoryName;
                control.Result.Description = categoryDto.Description;
                await _categoryService.UpdateAsync(control.Result);
            }
            else
            {
                return BadRequest();
            }
            return NoContent();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(new Categories { CategoryID = id });
            return NoContent();
        }

    }
}
