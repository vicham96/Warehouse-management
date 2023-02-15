using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Data.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        bool SaveChanges();

        public void CreateProduct(Product product);
        public void DeleteProduct(Product product); 
    }
}
