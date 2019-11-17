using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Data;
using BlazorApp.Services.Abstract;

namespace BlazorApp.Services
{
    public class ProductService :IProductService
    {
        private static IList<Product> products = new List<Product>() {
        new Product { ProductId = Guid.NewGuid().ToString(), ProductName = "IPad 2019", UnitPrice = 3499 , Description ="New IPad 2019 "},
        new Product { ProductId = Guid.NewGuid().ToString(), ProductName = "IPhone 11", UnitPrice = 6499 , Description ="New IPhone 11"}
        };

        //public Task<IList<Product>> GetProductsAsync()
        //{
        //    return Task.FromResult(products);
        //}

        //public Task DeleteAsync(string id)
        //{
        //    var product = products.First(item => item.ProductId == id);
        //    if (product != null)
        //    {
        //        products.Remove(product);
        //    }
        //    return Task.CompletedTask;
        //}

        //public Task UpdateAsync(Product product)
        //{
        //    var oldProduct = products.First(item => item.ProductId == product.ProductId);
        //    if (oldProduct != null)
        //    {
        //        oldProduct.ProductName = product.ProductName;
        //        oldProduct.UnitPrice = product.UnitPrice;
        //        oldProduct.Description = product.Description;
        //    }
        //    return Task.CompletedTask;
        //}
        //public Task<Product> AddAsync(Product product)
        //{
            
        //    if (product != null)
        //    {
        //        product.ProductId = Guid.NewGuid().ToString();
        //        products.Add(product);
        //    }

        //    return Task.FromResult(product);
        //}
         
        public Task<Product> GetProductAsync(string id)
        {
            var product = products.FirstOrDefault(item => item.ProductId == id);
            return Task.FromResult(product);
        }

        public Task<int> UpdateProductAsync(Product product)
        {
            var oldProduct = products.First(item => item.ProductId == product.ProductId);
            if (oldProduct != null)
            {
                oldProduct.ProductName = product.ProductName;
                oldProduct.UnitPrice = product.UnitPrice;
                oldProduct.Description = product.Description;
                return Task.FromResult(1);
            }
            return Task.FromResult(0);
        }

        public Task<int> AddProductAsync(Product product)
        {
            if (product != null)
            {
                product.ProductId = Guid.NewGuid().ToString();
                products.Add(product);
                return Task.FromResult(1);
            }
            return Task.FromResult(0);
        }

        public Task<int> DeleteProductAsync(string id)
        {
            var product = products.First(item => item.ProductId == id);
            if (product != null)
            {
                products.Remove(product);
                return Task.FromResult(1);
            }
            return Task.FromResult(0);
        }

        public Task<IEnumerable<Product>> GetProductsAsync(string name)
        {
            return Task.FromResult(products.AsEnumerable());
        }
    }
}
