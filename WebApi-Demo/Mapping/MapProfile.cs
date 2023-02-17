using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using System.Reflection.Metadata;

namespace WebApi_Demo.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Products, ProductDto>().ReverseMap();
            CreateMap<Categories, CategoryDto>().ReverseMap();
        }
    }
}
