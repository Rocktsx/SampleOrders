using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public string Remark { get; set; }

        public readonly List<OrderItem> OrderItems = new List<OrderItem>();


        public Order() { }
        public Order(string id, DateTime orderDate, string remark, List<OrderItem> orderItems)
        {
            OrderId = id;
            OrderDate = orderDate;
            Remark = remark;

            OrderItems.AddRange(orderItems);
        }
        public Task UpdateAsync(Order order)
        {
            OrderDate = order.OrderDate;
            Remark = order.Remark;
            OrderItems.Clear();
            foreach(var item in order.OrderItems)
            {
                OrderItems.Add(item);
            }

            return Task.CompletedTask;
        }
        public Task DeleteProductAsync(string productId)
        {
            var detail = OrderItems.First(item => item.ProductId == productId);
            if (detail != null)
            {
                OrderItems.Remove(detail);
            }
            return Task.CompletedTask;
        }

        public Task UpdateProductAsync(string productId, int count)
        {
            var oldrDetail = OrderItems.First(item => item.ProductId == productId);
            if (oldrDetail != null)
            { 
                oldrDetail.Count = count; 
            }
            return Task.CompletedTask;
        }
        public Task AddProductAsync(Product product, int count)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            
            if (!OrderItems.Any(item => item.ProductId == product.ProductId))
            {
                var item = new OrderItem(product.ProductId, product.ProductName, product.UnitPrice, count);
                OrderItems.Add(item);
            }
            else
            {
                var oldrDetail = OrderItems.First(item => item.ProductId == product.ProductId);
                oldrDetail.Count += count;
            }
            return Task.CompletedTask;
        }

        public decimal GetTotal()
        {
            
                return OrderItems.Sum(item => item.GetTotal());
             
        }
    }
}
