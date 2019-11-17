using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Domain
{
    public class OrderItem
    {  
        public string Id { get; set; }

        public string OrderId { get; set; }
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Count { get; set; }

        public OrderItem() { }

        public OrderItem(string id,string productId, string productName,decimal unitPrice,int count)
        {
            Id = id;
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Count = count;
        }
        public decimal GetTotal()
        {
            return UnitPrice * Count;
        }
    }
}
