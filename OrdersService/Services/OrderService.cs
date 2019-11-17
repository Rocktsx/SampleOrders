using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

using OrdersService.Application;
using OrdersService.Infrastructure.Extensions;

namespace OrdersService.Services
{
    [Authorize]
    public class OrderService : Orders.OrdersBase
    {
        ILogger<ProductService> _logger;
        IOrderApplication _orderApplication;
        public OrderService(ILogger<ProductService> logger, IOrderApplication orderApplication)
        {
            _logger = logger;
            _orderApplication = orderApplication;
        }

        public async override Task<OrderDto> Add(AddedOrderDto request, ServerCallContext context)
        {
            var order =  await _orderApplication.AddOrderAsync(request.ToOrder());

            return order.ToOrderDto();
        }

        public async override Task<UpdatedOrderResultDto> Delete(OrderIdDto request, ServerCallContext context)
        {
            var result = await _orderApplication.DeleteOrderAsync(request.Id);
            return new UpdatedOrderResultDto() { Count = result };
        }

        public async override Task<OrderDto> GetOrder(OrderIdDto request, ServerCallContext context)
        {
            var order = await _orderApplication.GetOrderAsync(request.Id);
            return order.ToOrderDto();
        }

        public async override Task<FilterOrderResultDto> GetOrders(FilterOrderDto request, ServerCallContext context)
        {
            var orders = await _orderApplication.GetOrdersAsync();
            var result = new FilterOrderResultDto();
            result.Orders.AddRange(orders.ToOrderDtos());
            return result;
        }

        public async override Task<OrderDto> Update(OrderDto request, ServerCallContext context)
        {
            var order = await _orderApplication.UpdateOrderAsync(request.ToOrder());

            return order.ToOrderDto();
        }
    }
}
