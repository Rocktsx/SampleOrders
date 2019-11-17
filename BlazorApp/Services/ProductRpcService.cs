using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
    public class ProductRpcService : IProductService
    {
        OrderRpcServcieSetting _setting;
        GrpcChannel _channel;
        Products.ProductsClient _client;
        IHttpContextAccessor _httpContext;

        public ProductRpcService(IOptions<OrderRpcServcieSetting> setting, IHttpContextAccessor httpContext)
        {
            _setting = setting.Value;
            _httpContext = httpContext;

            // GrpcChannel.ForAddress(_setting.OrderServcieHost);
            _channel = GrpcServiceHelper.CreateAuthenticatedChannel(_setting.OrderServcieHost, httpContext); 
            _client = new Products.ProductsClient(_channel);
            
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string name)
        {
            //throw new NotImplementedException();
            var reply = _client.GetProducts(new FilterProductDto { Name = name } );

            List<Product> products = new List<Product>();
            var stream = reply.ResponseStream;
            CancellationTokenSource source = new CancellationTokenSource();
            while (await stream.MoveNext(source.Token))
            {
                products.Add(stream.Current.ToProduct());
            }

            return products;
        }

        public async Task<Product> GetProductAsync(string id)
        {
            var dto = await _client.GetProductAsync(new ProductIdDto { Id = id });
            return dto.ToProduct();
        }

        public async Task<int> UpdateProductAsync(Product product)
        {
            var reply = await _client.UpdateAsync(product.ToProductDto());

            return reply.Count;
        }

        public async Task<int> AddProductAsync(Product product)
        {
            var reply = await _client.AddAsync(product.ToAddedProductDto());
            if (reply != null)
            {
                product.ProductId = reply.Id;
            }
            return reply == null ? 0 : 1;
        }

        public async Task<int> DeleteProductAsync(string id)
        {
            var reply = await _client.DeleteAsync(new ProductIdDto { Id = id });

            return reply.Count;
        }
    }
}
