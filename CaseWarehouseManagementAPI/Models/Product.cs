namespace CaseWarehouseManagementAPI.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
        public List<Article>? Articles { get; set; }
        public Boolean? IsInStock { get; set; }
        //public DateTime? CreatedDate { get; set; }
    }
}
