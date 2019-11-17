using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersService.Domain;

namespace OrdersService.Infrastructure.EntityConfigurations
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("orders");

            builder.HasKey(b => b.Id);

            builder.Property(o => o.OrderDate).IsRequired();


            builder.Property(o => o.Remark).IsRequired(false);
            
            var navigation = builder.Metadata.FindNavigation(nameof(Order.OrderItems));
            
             
        }
    }
}
