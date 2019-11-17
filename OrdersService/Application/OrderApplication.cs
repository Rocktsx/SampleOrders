using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Domain;
using OrdersService.Infrastructure;

namespace OrdersService.Application
{
    public class OrderApplication : IOrderApplication
    {
        private readonly OrderDbContext _orderDbContext;

        public OrderApplication(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            order.Id = Guid.NewGuid().ToString();

            foreach (var item in order.OrderItems)
            {
                item.Id = Guid.NewGuid().ToString();
                item.OrderId = order.Id;
            }
            var entity = _orderDbContext.Orders.Add(order).Entity;

            _orderDbContext.OrderItems.AddRange(order.OrderItems);
            await _orderDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<int> DeleteOrderAsync(string orderId)
        {
            if (_orderDbContext.Orders.Any(item => item.Id == orderId))
            {
                var item = await _orderDbContext.Orders.FindAsync(orderId);
                _orderDbContext.Orders.Remove(item);

                await _orderDbContext.SaveChangesAsync();
            }
            return await Task.FromResult(0);
        }

        public async Task<Order> GetOrderAsync(string orderId)
        {
            var order = await _orderDbContext.Orders.FindAsync(orderId);
            if (order != null)
            {
                order.OrderItems = _orderDbContext.OrderItems.Where(o => o.OrderId == order.Id).ToList();
            }
            return order;
        }

        public  Task<IEnumerable<Order>> GetOrdersAsync()
        {
            var orders = _orderDbContext.Orders.ToList();
            foreach (var item in orders)
            {
                item.OrderItems = _orderDbContext.OrderItems.Where(o => o.OrderId == item.Id).ToList();

            }
            return Task.FromResult(orders.AsEnumerable());
          
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            if (_orderDbContext.Orders.Any(item => item.Id == order.Id))
            {
                var items = _orderDbContext.OrderItems.Where(o => o.OrderId == order.Id);
                _orderDbContext.OrderItems.RemoveRange(items);
                foreach (var item in order.OrderItems)
                {
                    item.OrderId = order.Id;
                    item.Id = Guid.NewGuid().ToString(); 
                }
                _orderDbContext.AddRange(order.OrderItems);
                var entity = _orderDbContext.Orders.Update(order).Entity;

                await _orderDbContext.SaveChangesAsync();
                return entity;
            }
            return order;
        }
    }
}
