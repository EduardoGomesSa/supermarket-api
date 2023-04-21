namespace supermarket.model
{
    public class Product
    {
        public Product(int id, string name, string description, decimal price, int amount, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public Category Category { get; set; }

    }
}
