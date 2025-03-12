namespace WaggyProject.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Icon { get; set; }

        public IList<Product> Products { get; set; }
    }
}
