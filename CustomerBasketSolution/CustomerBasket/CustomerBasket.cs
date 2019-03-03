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
        private List<IProduct> _products = new List<IProduct>();
        private List<IDiscount> _discounts = new List<IDiscount>();

        public CustomerBasket(List<IProduct> products, List<IDiscount> discounts)
        {
            _products = products;
            _discounts = discounts;
        }
        
        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public decimal Total() =>  _products.Sum(x => x.Total()) - _discounts.Sum(x => x.Calculate(_products));
    }
}
