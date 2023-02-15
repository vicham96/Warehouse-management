using AutoMapper;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<IEnumerable<Article>, IEnumerable<ArticleReadDTO>>();
            CreateMap<Article, ArticleReadDTO>();
            CreateMap<Product, ProductReadDTO>();
            CreateMap<ProductCreateDTO, Product>(); 
        }
    }
}
