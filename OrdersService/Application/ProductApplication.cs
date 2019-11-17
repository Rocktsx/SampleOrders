using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Domain;
using OrdersService.Infrastructure;

namespace OrdersService.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly OrderDbContext _orderDbContext;

        public ProductApplication(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public async Task<int> AddProduct(Product product)
        {
            _orderDbContext.Products.Add(product);
            return await _orderDbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteProduct(string id)
        {
            if (_orderDbContext.Products.Any(item => item.Id == id))
            {
                var item = await _orderDbContext.Products.FindAsync(id);
                _orderDbContext.Remove(item);
                return await _orderDbContext.SaveChangesAsync();
            }
            return await Task.FromResult(0);
        }

        public async Task<Product> GetProductAsync(string id)
        {
            return await _orderDbContext.Products.FindAsync(id);
        }

        public IEnumerable<Product> GetProducts(string name)
        {
            return _orderDbContext.Products.Where(item => string.IsNullOrEmpty(name) || item.ProductName.Contains(name)).AsEnumerable();
        }

        public async Task<int> UpdateProduct(Product product)
        {
            if (_orderDbContext.Products.Any(item => item.Id == product.Id))
            {
                //var item = await _orderDbContext.Products.FindAsync(product.Id);
                _orderDbContext.Products.Update(product);
                return await _orderDbContext.SaveChangesAsync();
            }
            return await Task.FromResult(0);
        }
    }
}
