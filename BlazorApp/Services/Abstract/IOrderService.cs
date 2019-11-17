using BlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.Abstract
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrdersAsync();

        Task<Order> GetOrderAsync(string orderId);

        Task<Order> AddAsync(Order order);
        Task<Order> UpdateAsync(Order order);

        Task<int> DeleteAsync(string orderId);
    }
}
