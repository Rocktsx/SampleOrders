using System;
using BlazorApp.Data;
using OrdersService;

namespace BlazorApp.Services.Extensions
{
    public static class ProductExtension
    {
        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.ProductId,
                Name = product.ProductName,
                Description = product.Description,
                UnitPrice = (float)product.UnitPrice
            };
        }
        public static Product ToProduct(this ProductDto dto)
        { 
            return new Product(dto.Id,dto.Name, dto.Description, (decimal)Math.Round(dto.UnitPrice, 2));
        }
        public static Product ToProduct(this AddedProductDto dto)
        {
            return new Product(dto.Name, dto.Description, (decimal)Math.Round(dto.UnitPrice, 2));
            
        }

        public static AddedProductDto ToAddedProductDto(this Product product)
        {
            return new AddedProductDto
            { 
                Name = product.ProductName,
                Description = product.Description,
                UnitPrice = (float)product.UnitPrice
            };
        }
    }
}
