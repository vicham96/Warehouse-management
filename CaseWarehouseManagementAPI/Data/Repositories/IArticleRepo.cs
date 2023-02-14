using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.Data.Repositories
{
    public interface IArticleRepo
    {
        IEnumerable<Article> GetArticles();
        Article GetArticleById(int articleId);
    }
}
