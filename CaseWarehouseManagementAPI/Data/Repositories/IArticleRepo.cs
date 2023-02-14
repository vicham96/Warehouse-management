using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Data.Repositories
{
    public interface IArticleRepo
    {
        IEnumerable<Article> GetProducts();
        Article GetProductById(int articleId);
    }
}
