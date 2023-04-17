using AutoMapper;
using cleanarch.Application.DTOs;
using cleanarch.Domain.Entities;

namespace cleanarch.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
