using System.ComponentModel;

namespace CaseWarehouseManagementAPI.Models
{
    public class Article
    {
        public Guid? Id { get; set; } 
        public string?Name { get; set; }

        [DefaultValue(true)]
        public Boolean IsInStock { get; set; }
    }
}
