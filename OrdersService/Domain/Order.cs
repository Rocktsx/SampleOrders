using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Domain
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }

        public string Remark { get; set; }

        public List<OrderItem> OrderItems = new List<OrderItem>();

        public Order() { }

        public Order (string id, DateTime orderDate, string remark, List<OrderItem> orderItems)
        {
            Id = id;
            OrderDate = orderDate;
            Remark = remark;

            OrderItems.AddRange(orderItems); 
        }
        public void Update(Order order)
        {
            OrderDate = order.OrderDate;
            Remark = order.Remark;
            OrderItems.Clear();
            foreach(var item in order.OrderItems)
            {
                OrderItems.Add(item);
            }

        }
        public void DeleteProduct(string productId)
        {
            var detail = OrderItems.First(item => item.ProductId == productId);
            if (detail != null)
            {
                OrderItems.Remove(detail);
            }
        }

        public void UpdateProduct(string productId, int count)
        {
            var oldrDetail = OrderItems.First(item => item.ProductId == productId);
            if (oldrDetail != null)
            { 
                oldrDetail.Count = count; 
            } 
        }
        public void AddProduct(Product product, int count)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            
            if (!OrderItems.Any(item => item.ProductId == product.Id))
            {
                var item = new OrderItem(string.Empty,product.Id, product.ProductName, product.UnitPrice, count);
                OrderItems.Add(item);
            }
            else
            {
                var oldrDetail = OrderItems.First(item => item.ProductId == product.Id);
                oldrDetail.Count += count;
            } 
        }

        public decimal GetTotal()
        {
            
            return OrderItems.Sum(item => item.GetTotal());
             
        }
    }
}
