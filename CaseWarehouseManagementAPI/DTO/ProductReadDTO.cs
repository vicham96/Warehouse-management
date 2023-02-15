using CaseWarehouseManagementAPI.Models;

namespace CaseWarehouseManagementAPI.DTO
{
    public class ProductReadDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
        public List<Article>? Articles { get; set; }
    }
}
