using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersService.Domain;

namespace OrdersService.Infrastructure.EntityConfigurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.HasKey(b => b.Id);
            builder.Property<string>("Id");

            builder.Property<string>("ProductName")
                .IsRequired();
            builder.Property<string>("Description")
               .IsRequired(false); 

            builder.Property<decimal>("UnitPrice").HasColumnType("decimal(20,7)")
                .IsRequired();
        }
    }
}
