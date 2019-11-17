using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Domain;
using OrdersService.Infrastructure.Extensions;

namespace OrdersService.Application
{
    public interface IProductApplication
    {
        IEnumerable<Product> GetProducts(string name);

        Task<Product> GetProductAsync(string id);
        Task<int> UpdateProduct(Product product);
        Task<int> AddProduct(Product product);

        Task<int> DeleteProduct(string id);
    }
}
