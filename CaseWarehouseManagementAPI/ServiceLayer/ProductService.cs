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

        public IEnumerable<ProductReadDTO> GetProductsInStock(int limit, int productIndex)
        {
            IEnumerable<Product> products = _repo.GetProducts();
            //Get products in stock based on articles 
            var productsInStock = products.Where(
                product => IsArticleInStock(product)
            );
            var filteredProducts = products.ToList().GetRange(productIndex, limit); 
            return _mapper.Map<IEnumerable<ProductReadDTO>>(products);
        }
        private Boolean IsArticleInStock(Product product)
        {
            if (product.Articles.Count > 0)
            {
                return product.Articles.Find(a => !a.IsInStock) == null;
            }
            return false;

        }
    }
}
