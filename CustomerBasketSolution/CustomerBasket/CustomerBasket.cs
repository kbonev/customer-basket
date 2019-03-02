using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerBasket.Models;

namespace CustomerBasket
{
    public class CustomerBasket : ICustomerBasket
    {
        private List<Product> _products = new List<Product>();
        private List<IDiscount> _discounts = new List<IDiscount>();

        public CustomerBasket(List<Product> products, List<IDiscount> discounts)
        {
            _products = products;
            _discounts = discounts;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal Total()
        {
            return _products.Sum(x => x.Total()) - _discounts.Sum(x => x.Calculate(_products));
        }
    }
}
