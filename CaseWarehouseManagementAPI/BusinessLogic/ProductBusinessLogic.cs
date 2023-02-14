using CaseWarehouseManagementAPI.DataAccess;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.BusinessLogic
{
    public class ProductBusinessLogic
    {
        public void SellProduct(int productId)
        {
            //Validate some stuff 
            var dataAccess = new ProductDataAccess();
            //If contains at least one article that is not in stock then don't do anything
            dataAccess.updateProduct(productId);
        }

        public IEnumerable<Product> GetProducts(int limit, int index)
        {
            //Validate some stuff 
            var dataAccess = new ProductDataAccess();
            var products = dataAccess.getProducts();
            //Get products in stock based on articles 
            var productsInStock = products.Where(
                product => true
                );
            return productsInStock; 
        }

        public Product GetDetailedProduct(Guid productId)
        {
            //Validate some stuff 
            var dataAccess = new ProductDataAccess();
            var product = dataAccess.getSingleProduct(productId);
            return product;
        }
    }
}
