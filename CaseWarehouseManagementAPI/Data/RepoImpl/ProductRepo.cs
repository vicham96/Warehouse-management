using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

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
            return _context.Products
                .Include(p => p.Articles)
                .Where(p => p.Articles.Any(a => a.IsInStock))
                .ToList();
        }
    }
}
