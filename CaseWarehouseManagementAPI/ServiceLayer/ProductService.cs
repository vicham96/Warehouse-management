using AutoMapper;
using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.ServiceLayer
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _repo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper; 
        }

        public ProductReadDTO GetProduct(int productId)
        {
            var product = _repo.GetProductById(productId);
            return _mapper.Map<ProductReadDTO>(product);
        }

        public IEnumerable<ProductReadDTO> GetProductsInStock()
        {
            var products = _repo.GetProducts();
            return _mapper.Map<IEnumerable<ProductReadDTO>>(products);

        }
    }
}
