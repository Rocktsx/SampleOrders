using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersService.Domain;

namespace OrdersService.Infrastructure.EntityConfigurations
{
    public class OrderItemEntityTypeConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("orderItems");

            builder.HasKey("Id");

            builder.Property("Id").ValueGeneratedOnAdd(); 

            builder.Property<string>("OrderId")
                .IsRequired();


            builder.Property<string>("ProductId")
                .IsRequired();

            builder.Property<string>("ProductName")
                .IsRequired(false);

            builder.Property(o=>o.UnitPrice).HasColumnType("decimal(20,7)")
                .IsRequired(); 
        }
    }
}
