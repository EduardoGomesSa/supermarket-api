using System.ComponentModel.DataAnnotations.Schema;

namespace supermarket.model
{
    public class Product
    {
        public Product() { }

        public Product(int id, string name, string description, decimal price, int amount, int categoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
            CategoryId = categoryId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
