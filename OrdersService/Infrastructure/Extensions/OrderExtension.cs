using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using OrdersService.Domain;


namespace OrdersService.Infrastructure.Extensions
{
    public static class OrderExtension
    {
        public static Order ToOrder(this OrderDto dto)
        {
            DateTime.TryParse(dto.OrderDate, out DateTime orderDate);
            return new Order(dto.Id, orderDate, dto.Remark, dto.Items.ToOrderItems());
        }
        public static Order ToOrder(this AddedOrderDto dto)
        {
            DateTime.TryParse(dto.OrderDate, out DateTime orderDate);
            return new Order(string.Empty, orderDate, dto.Remark, dto.Items.ToOrderItems());
        }
        public static OrderDto ToOrderDto(this Order order)
        {
            var result = new OrderDto()
            {
                Id = order.Id,
                OrderDate = order.OrderDate.ToString(),
                Remark = order.Remark,
            };
            result.Items.AddRange(order.OrderItems.ToOrderItemDtos());

            return result;
        }
        public static List<OrderItem> ToOrderItems(this RepeatedField<OrderItemDto> itemDtos)
        {
            var result = new List<OrderItem>(itemDtos.Count);
            foreach (var item in itemDtos)
            {
                result.Add(new OrderItem(item.Id,item.ProductId, item.ProductName, (decimal)Math.Round(item.UnitPrice), item.Count));
            }

            return result;
        }
        public static RepeatedField<OrderItemDto> ToOrderItemDtos(this List<OrderItem> items)
        {
            var result = new RepeatedField<OrderItemDto>();
            foreach (var item in items)
            {
                result.Add(new OrderItemDto()
                {
                    Id =item.Id,
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    UnitPrice = (float)item.UnitPrice,
                    Count = item.Count
                });
            }

            return result;
        }
        public static RepeatedField<OrderDto> ToOrderDtos(this IEnumerable<Order> items)
        {
            var result = new RepeatedField<OrderDto>();
            foreach (var item in items)
            {
                result.Add( item.ToOrderDto());
            }

            return result;
        }
    }
}
