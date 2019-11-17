using BlazorApp.Data;
using BlazorApp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class OrderService : IOrderService
    {
        private static IList<Order> orders = new List<Order>();

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(orders.AsEnumerable());
        }

        public Task<int> DeleteAsync(string id)
        {
            var order = orders.First(item => item.OrderId == id);
            if (order != null)
            {
                orders.Remove(order);
                return Task.FromResult(1);
            }
            return Task.FromResult(0);
        }

        public async Task<Order> UpdateAsync(Order order)
        {
            var oldOrder = orders.First(item => item.OrderId == order.OrderId);
            if (oldOrder != null)
            {
                await oldOrder.UpdateAsync(order);
            }
            return order;
        }
        public Task<Order> AddAsync(Order order)
        {

            if (order != null)
            {
                order.OrderId = Guid.NewGuid().ToString();
                orders.Add(order);
            }

            return Task.FromResult(order);
        }


        public Task<Order> GetOrderAsync(string orderId)
        {
            var order = orders.FirstOrDefault(item => item.OrderId == orderId);
            return Task.FromResult(order);
        }

    }
}
