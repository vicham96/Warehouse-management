using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Data.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        
    }
}
