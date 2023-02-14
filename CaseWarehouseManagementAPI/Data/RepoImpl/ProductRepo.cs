using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Data.RepoImpl
{
    public class ProductRepo : IProductRepo
    {
        private readonly DataContext _context;

        public ProductRepo(DataContext context)
        {
            _context = context;
        }
        public Product GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.Id == productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
