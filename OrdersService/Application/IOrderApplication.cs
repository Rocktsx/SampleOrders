using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Domain;

namespace OrdersService.Application
{
    public interface IOrderApplication
    {
        Task<IEnumerable<Order>> GetOrdersAsync();

        Task<Order> GetOrderAsync(string orderId);

        Task<Order> AddOrderAsync(Order order);
        Task<Order> UpdateOrderAsync(Order order);

        Task<int> DeleteOrderAsync(string orderId);
    }
}
