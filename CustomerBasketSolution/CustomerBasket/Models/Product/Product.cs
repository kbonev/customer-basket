using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models
{
    public class Product : IProduct
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A Name should be given to the product");

                _name = value;
            }
        }

        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price cannot be less than 0");

                _price = value;
            }
        }

        private int _quantity = 1;
        public int Quantity => _quantity;

        public Product(string name, decimal price)
        {
            Name = name;           
            Price = price;
        }

        public Product(string name, decimal price, int quantity): this(name, price)
        {
            _quantity = quantity;
        }        
        
        public void AddQuantity(int amount) => _quantity += amount;

        public decimal Total() => Price * _quantity;
    }
}
