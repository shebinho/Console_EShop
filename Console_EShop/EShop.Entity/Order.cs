using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Entity
{
    public class Order
    {
        public ProductCatalog Product  { get; private set; }

        public int Quantity { get; set; }

        public double TotalProductPrice { get; private set; }

        public Order(ProductCatalog productOrder,int quantity,double totalProductPrice)
        {
            Product = productOrder;
            Quantity = quantity;
            TotalProductPrice = totalProductPrice;
        }
    }
}
