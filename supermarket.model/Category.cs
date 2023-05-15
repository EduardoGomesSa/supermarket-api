
using System.ComponentModel.DataAnnotations.Schema;

namespace supermarket.model
{
    public class Category
    {
        public Category() { }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        //[NotMapped]
        //public List<Product> Products { get; set; }
    }
}
