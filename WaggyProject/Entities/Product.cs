using System.ComponentModel.DataAnnotations.Schema;

namespace WaggyProject.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public decimal Price { get; set; }
        public int Review { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
