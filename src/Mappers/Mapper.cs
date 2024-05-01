using AutoMapper;
using static sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.DTOs.ProductDto;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;


public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<Product, ProductReadDto>();
        CreateMap<ProductReadDto, Product>();
    }
}