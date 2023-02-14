namespace CaseWarehouseManagementAPI.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
        public int? Quantity { get; set; }
        public List<Article>? Articles { get; set; }

        /*

        public Boolean IsProductInStock()
        {
            if (Articles.Count > 0)
            {
                return Articles.Find(a => !a.IsInStock) == null;
            }
            return false;

        }
        */
    }
}
