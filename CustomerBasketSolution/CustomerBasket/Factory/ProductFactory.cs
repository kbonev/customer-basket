using CustomerBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Factory
{
    public static class ProductFactory
    {
        public static Product Get(string type, int quanitity = 1)
        {
            switch (type.ToLower())
            {
                case "butter":
                    return new Product("Butter", 0.8m, quanitity);
                case "bread":
                    return new Product("Bread", 1m, quanitity);
                case "milk":
                    return new Product("Milk", 1.15m, quanitity);
                default:
                    throw new Exception("Product not found");
            }
        } 
    }
}
