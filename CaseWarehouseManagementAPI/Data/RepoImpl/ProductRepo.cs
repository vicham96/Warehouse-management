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
            if (productId == null)
            {
                throw new ArgumentNullException(nameof(productId)); 
            }
            return _context.Products
                .Include(p => p.Articles)
                .FirstOrDefault(p => p.Id == productId);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products
                .Include(p => p.Articles)
                .Where(p => p.Articles.Any(a => a.IsInStock))
                .ToList();
        }

        public void DeleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Remove(product);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0); 
        }

        public void CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product)); 
            }

            _context.Add(product); 
        }
    }
}
