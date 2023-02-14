using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.DataAccess
{
    public class ProductDataAccess
    {
        public void updateProduct(int productId)
        {
            // Update product when it is sold 
        }

        public IEnumerable<Product> getProducts()
        {
            // Retrieve all products from database 
            return new List<Product>();
        }

        public Product getSingleProduct(Guid id)
        {
            return new Product(); 
        }
    }
}
