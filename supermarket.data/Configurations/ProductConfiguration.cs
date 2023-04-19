using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using supermarket.model;

namespace supermarket.data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnName("name").HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Price).HasColumnName("price").HasColumnType("money").IsRequired();
            builder.Property(p => p.Amount).HasColumnName("amount").HasColumnType("integer").IsRequired().HasDefaultValue(1);
        }
    }
}
