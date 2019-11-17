using BlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync(string name);

        Task<Product> GetProductAsync(string id);
        Task<int> UpdateProductAsync(Product product);
        Task<int> AddProductAsync(Product product);

        Task<int> DeleteProductAsync(string id);
    }
}
