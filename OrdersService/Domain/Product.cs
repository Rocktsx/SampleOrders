using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Domain
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string Description { get; set; }

        public Product() { }

        public Product(string name, string descrption, decimal unitPrice) :
            this(Guid.NewGuid().ToString(), name, descrption, unitPrice)
        {

        }
        public Product(string id, string name, string descrption, decimal unitPrice)
        {
            Id = id;
            ProductName = name;
            Description = descrption;
            UnitPrice = unitPrice;
        }

    }
}
