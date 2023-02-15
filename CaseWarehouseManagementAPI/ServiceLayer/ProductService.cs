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

        public ProductReadDTO CreateProduct(ProductCreateDTO productDTO)
        {
            if (productDTO == null)
            {
                throw new ArgumentNullException("Payload must be given.");
            }

            var productModel = _mapper.Map<Product>(productDTO);
            _repo.CreateProduct(productModel);
            var productReadDto = _mapper.Map<ProductReadDTO>(productModel);
            return productReadDto; 
        }

        public ProductReadDTO GetProduct(int productId)
        {
            var product = _repo.GetProductById(productId);
            if (productId == null)
            {
                throw new ArgumentNullException(nameof(productId));
            }
            return _mapper.Map<ProductReadDTO>(product);
        }

        public IEnumerable<ProductReadDTO> GetProductsInStock()
        {
            var products = _repo.GetProducts();
            return _mapper.Map<IEnumerable<ProductReadDTO>>(products);

        }

        public void SellProduct(int productId)
        {
            var productModelFromRepo = _repo.GetProductById(productId);
            if (productModelFromRepo == null)
            {
                throw new ArgumentException("The product with the given id does not exist.");
            }
            _repo.DeleteProduct(productModelFromRepo);
            _repo.SaveChanges();
        }
    }
}
