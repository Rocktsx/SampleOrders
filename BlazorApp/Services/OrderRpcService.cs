using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Grpc.Net.Client;

using OrdersService;
using BlazorApp.Data;
using BlazorApp.Services.Abstract;
using BlazorApp.Services.Extensions;
using Microsoft.AspNetCore.Http;

namespace BlazorApp.Services
{
    public class OrderRpcService : IOrderService
    {
        OrderRpcServcieSetting _setting;
        GrpcChannel _channel;
        Orders.OrdersClient _client;

        public OrderRpcService(IOptions<OrderRpcServcieSetting> setting, IHttpContextAccessor httpContext)
        {
            _setting = setting.Value;

            _channel = GrpcServiceHelper.CreateAuthenticatedChannel(_setting.OrderServcieHost, httpContext);
            _client = new Orders.OrdersClient(_channel);
        }
        public async Task<Order> AddAsync(Order order)
        {
            var reply = await _client.AddAsync(order.ToAddedOrderDto());

            return reply.ToOrder();
        }

        public async Task<int> DeleteAsync(string orderId)
        {
            var reply = await _client.DeleteAsync(new OrderIdDto() { Id = orderId });
            return reply.Count;
        }

        public async Task<Order> GetOrderAsync(string orderId)
        {
            var reply = await _client.GetOrderAsync(new OrderIdDto() { Id = orderId });
            return reply.ToOrder();
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            var reply = await _client.GetOrdersAsync(new FilterOrderDto());
            return reply.Orders.ToOrders();
        }

        public async Task<Order> UpdateAsync(Order order)
        {
            var reply = await _client.UpdateAsync(order.ToOrderDto());

            return reply.ToOrder();
        }
    }
}
