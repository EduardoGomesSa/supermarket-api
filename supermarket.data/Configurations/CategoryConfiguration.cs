
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using supermarket.model;

namespace supermarket.data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categories");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnName("name").HasColumnType("VARCHAR(30)").IsRequired();

            //builder.HasMany(p => p.Products)
            //    .WithOne(p => p.Category)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
