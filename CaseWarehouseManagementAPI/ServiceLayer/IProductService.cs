using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.ServiceLayer
{
    public interface IProductService
    {
        IEnumerable<ProductReadDTO> GetProductsInStock();
        ProductReadDTO GetProduct(int productId);
        ProductReadDTO CreateProduct(ProductCreateDTO productDTO);
        void SellProduct(int productId);
    }
}
