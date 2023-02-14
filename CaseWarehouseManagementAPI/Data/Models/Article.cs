using System.ComponentModel;

namespace CaseWarehouseManagementAPI.Models
{
    public class Article
    {
        public int? Id { get; set; } 
        public string? Name { get; set; }
        [DefaultValue(true)]
        public Boolean IsInStock { get; set; }
    }
}
