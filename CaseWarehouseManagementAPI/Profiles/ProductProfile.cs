using AutoMapper;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductReadDTO>();
        }
    }
}
