using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.ServiceLayer
{
    public interface IProductService
    {
        IEnumerable<Product> GetProductsInStock(int limit, int productIndex);
        ProductReadDTO GetProduct(int productId);
    }
}
