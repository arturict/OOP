﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double GetAmount()
        {
            return Product.Price * Quantity;
        }
        public override string ToString()
        {
            return Quantity + "x " + Product.ToString();
        }
    }

}
