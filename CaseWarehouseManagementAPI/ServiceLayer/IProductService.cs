using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.DTO;

namespace CaseWarehouseManagementAPI.ServiceLayer
{
    public interface IProductService
    {
        IEnumerable<ProductReadDTO> GetProductsInStock(int limit, int productIndex);
        ProductReadDTO GetProduct(int productId);
    }
}
