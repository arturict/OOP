using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public OrderItem() { }

        public double GetAmount() { 
            return Quantity; }
    }
}
