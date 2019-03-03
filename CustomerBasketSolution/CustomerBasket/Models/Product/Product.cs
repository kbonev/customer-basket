using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models
{
    public abstract class Product : IProduct
    {
        public abstract decimal Price { get; }
        public int _quantity { get; set; }

        public Product()
        {
            _quantity = 1;
        }

        public Product(int quantity)
        {
            _quantity = quantity;
        }

        public int Quantity => _quantity;
        
        public void AddQuantity(int amount) => _quantity += amount;

        public decimal Total() => Price * _quantity;
    }
}
