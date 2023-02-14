namespace CaseWarehouseManagementAPI.Models
{
    public class Product
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
        public List<Article>? Articles { get; set; }
        public int? Quantity { get; set; }

        public Boolean IsProductInStock()
        {
            if (Articles.Count > 0)
            {
                return Articles.Find(a => !a.IsInStock) == null;
            }
            return false;

        }
    }
}
