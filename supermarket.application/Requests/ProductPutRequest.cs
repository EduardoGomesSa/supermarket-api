namespace supermarket.application.Requests
{
    public class ProductPutRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
