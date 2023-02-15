using System.ComponentModel;

namespace CaseWarehouseManagementAPI.Models
{
    public class Article
    {
        public int? Id { get; set; } 
        public string? Name { get; set; }
        public int? Stock { get; set; }
        public int? AmountOf { get; set; }
    }
}
