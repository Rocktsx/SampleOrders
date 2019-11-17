using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using OrdersService.Application;
using OrdersService.Infrastructure.Extensions;

namespace OrdersService.Services
{
    [Authorize]
    public class ProductService : Products.ProductsBase
    {
        ILogger<ProductService> _logger;
        IProductApplication _productApplication;
        public ProductService(ILogger<ProductService> logger, IProductApplication productApplication)
        {
            _logger = logger;
            _productApplication = productApplication;
        }
        public override async Task<ProductDto> GetProduct(ProductIdDto request, ServerCallContext context)
        {
            var product = await _productApplication.GetProductAsync(request.Id);
            var result = product == null ? null : product.ToProductDto();
            return result;
        }
        public override async Task GetProducts(FilterProductDto request, IServerStreamWriter<ProductDto> responseStream, ServerCallContext context)
        {
            var products = _productApplication.GetProducts(request.Name);
            foreach (var product in products)
            {
                await responseStream.WriteAsync(product.ToProductDto());
            }

        }
        public override async Task<ProductDto> Add(AddedProductDto request, ServerCallContext context)
        {
            var product = request.ToProduct();
            await _productApplication.AddProduct(product);

            return product.ToProductDto();

        }

        public override async Task<UpdatedResultDto> Delete(ProductIdDto request, ServerCallContext context)
        {
            var result = await _productApplication.DeleteProduct(request.Id);
            return new UpdatedResultDto() { Count = result };
        }

        public override async Task<UpdatedResultDto> Update(ProductDto request, ServerCallContext context)
        {
            var result = await _productApplication.UpdateProduct(request.ToProduct());
            return new UpdatedResultDto() { Count = result };
        }
    }
}
