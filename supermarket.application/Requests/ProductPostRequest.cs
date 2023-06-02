using supermarket.model;

namespace supermarket.application.Requests
{
    public class ProductPostRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public CategoryPostRequest Category { get; set; }
    }
}
